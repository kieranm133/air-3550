using air_3550.Database;
using air_3550.Models;
using air_3550.Services;
using Dapper;
using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace air_3550
{
    public partial class CustomerForm : Form
    {
        private DatabaseManager db;
        private List<Booking> bookings;
        private List<Airport> airports;
        private User userRecord;
        private Customer customerRecord;
        public CustomerForm(User user)
        {
            InitializeComponent();
            db = DatabaseManager.Instance;
            this.bookings = db.Bookings.GetAll();
            this.airports = db.Airports.GetAll();
            this.userRecord = user;
            this.customerRecord = db.Customers.GetByID(user.UserID);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // Get the origin combo box source
            comboBoxFrom.DataSource = new List<Airport>(airports);
            comboBoxFrom.DisplayMember = "CityState";
            comboBoxFrom.ValueMember = "AirportID";
            comboBoxFrom.SelectedIndex = -1;
            comboBoxFrom.DropDownStyle = ComboBoxStyle.DropDownList;

            // Get the destination combo box source
            comboBoxTo.DataSource = new List<Airport>(airports);
            comboBoxTo.DisplayMember = "CityState";
            comboBoxTo.ValueMember = "AirportID";
            comboBoxTo.SelectedIndex = -1;
            comboBoxTo.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] payment = {"Credit", "Points" };
            paymentMethod.DataSource = payment;
            paymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;

            // Get the dataGridView source--all of the scheduled flights
            // TODO: Join create a method in ScheduledFlightsRepository to join all relevant info.
            List<Booking>? book = db.Bookings.GetAll();
            bookingView.DataSource = book;
            bookingView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Add the profile info
            buildTableLayout();
            LoadBookingData();
        }

        private void btnLogoutCus_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void getTicketInfo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox changed = sender as ComboBox;
            ComboBox other = (changed == comboBoxFrom ? comboBoxTo : comboBoxFrom);

            if (changed.SelectedIndex != -1 && other.SelectedIndex != -1)
            {
                if (changed.SelectedIndex == other.SelectedIndex)
                {
                    // Set the other ComboBox to have no selection
                    other.SelectedIndex = -1;
                    buttonSearch.Enabled = false;
                }
                else
                {
                    buttonSearch.Enabled = true;
                }
            }
        }

        private void radioButtonRoundTrip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOneWay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOneWay.Checked)
            {
                dateTimePickerArrival.Enabled = false;
            }
            else
            {
                dateTimePickerArrival.Enabled = true;
            }
        }

        private void buildTableLayout()
        {
            dataGridViewProfile.Rows.Add("First name", this.customerRecord.FirstName);
            dataGridViewProfile.Rows.Add("Last name", this.customerRecord.LastName);
            dataGridViewProfile.Rows.Add("Address", this.customerRecord.Address);
            dataGridViewProfile.Rows.Add("Phone", this.customerRecord.Phone);
            dataGridViewProfile.Rows.Add("Age", this.customerRecord.Age);
            dataGridViewProfile.Rows.Add("Points used", this.customerRecord.PointsUsed);
            dataGridViewProfile.Rows.Add("Points available", this.customerRecord.PointsAvailable);
            dataGridViewProfile.Rows.Add("Credit card", $"**** **** **** {this.customerRecord.CreditCard.Substring(this.customerRecord.CreditCard.Length - 4)}");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string departureDate = dateTimePickerDeparture.Value.ToShortDateString();
            string originAirportID = (string)comboBoxFrom.SelectedValue;
            string destinationAirportID = (string)comboBoxTo.SelectedValue;
            double price = 50;

            List<ScheduledFlight> allScheduledFlights = db.ScheduledFlights.GetAll();

            Dictionary<int, ScheduledFlight> scheduledFlightLookup = allScheduledFlights.ToDictionary(sf => sf.ScheduledFlightID);

            List<List<ScheduledFlight>> results = FlightPathCalculator.GetAllRoutes(originAirportID, destinationAirportID);

            List<List<Flight>> routes = results
                    .Select(sl => db.Flights.GetByScheduledFlightIDAndDate(sl.Select(s => s.ScheduledFlightID).ToList(), departureDate)).ToList();

            List<List<(Flight flight, ScheduledFlight scheduledFlight)>> combined = routes
                .Where(route => route.All(f => f.EmptySeats != 0))
                .Select(route => route
                    .Select(flight => (flight, scheduledFlight: scheduledFlightLookup[flight.ScheduledFlightID]))
                    .ToList())
                .ToList();

            List<BookingFlightViewModel> flightDisplays = combined
                .Select(route =>
                {
                    (Flight firstFlight, ScheduledFlight firstScheduledFlight) = route.First();
                    (Flight lastFlight, ScheduledFlight lastScheduledFlight) = route.Last();
                    List<int> flightIDs = route.Select(flightTuple => flightTuple.flight.FlightID).ToList();

                    price = price + (firstScheduledFlight.Distance + lastScheduledFlight.Distance) * 0.12 + (8 * (route.Count - 1));
                    TimeSpan depart = TimeSpan.Parse(firstScheduledFlight.DepartureTime);
                    TimeSpan arrival = TimeSpan.Parse(lastScheduledFlight.DepartureTime);

                    if (depart.Hours < 5 || arrival.Hours < 5)
                    {
                        price *= 0.8;
                    } else if (depart.Hours < 8 || arrival.Hours >= 7)
                    {
                        price *= 0.9;
                    }

                    price = Math.Round(price, 2, MidpointRounding.AwayFromZero);

                    return new BookingFlightViewModel
                    {
                        DepartureAirport = firstScheduledFlight.OriginAirportID,
                        ArrivalAirport = lastScheduledFlight.DestinationAirportID,
                        DepartureDate = firstFlight.DepartureDate,
                        ArrivalDate = lastFlight.ArrivalDate,
                        DepartureTime = firstScheduledFlight.DepartureTime,
                        ArrivalTime = lastScheduledFlight.ArrivalTime,
                        NumberOfConnections = route.Count - 1,
                        FlightIDs = flightIDs,
                        Price = price
                    };
                }).ToList();
            dataGridViewSearchResults.DataSource = flightDisplays;
        }
        private void LoadBookingData()
        {
            // Get the dataGridView source--all of the scheduled flights
            // TODO: Join create a method in ScheduledFlightsRepository to join all relevant info.
            List<Booking>? bookings = db.Bookings.Search(this.customerRecord.UserID);
            bookingView.DataSource = bookings;
            bookingView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void bookFlightBtn_Click(object sender, EventArgs e)
        {
            bookFlightBtn.Enabled = false;
            // Get the Airport models
            Booking bookingToAdd = new Booking();
            DataGridViewRow selectedRow = dataGridViewSearchResults.SelectedRows[0];
            BookingFlightViewModel selectedFlight = (BookingFlightViewModel)selectedRow.DataBoundItem;
            List<int> flightIDs = selectedFlight.FlightIDs;
            

            if (selectedFlight.Price*100 > customerRecord.PointsAvailable && paymentMethod.SelectedItem == "Points")
            {
                MessageBox.Show("Not enough points for flight. Please select credit.", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                bookingToAdd.CustomerID = this.customerRecord.UserID;
                if (selectedFlight.NumberOfConnections == 2)
                {
                    bookingToAdd.FlightID1 = flightIDs.ElementAt(0);
                    bookingToAdd.FlightID2 = flightIDs.ElementAt(1);
                    bookingToAdd.FlightID3 = flightIDs.ElementAt(2);
                }
                else if (selectedFlight.NumberOfConnections == 1)
                {
                    bookingToAdd.FlightID1 = flightIDs.ElementAt(0);
                    bookingToAdd.FlightID2 = flightIDs.ElementAt(1);
                    bookingToAdd.FlightID3 = null;
                }
                else
                {
                    bookingToAdd.FlightID1 = flightIDs.ElementAt(0);
                    bookingToAdd.FlightID2 = null;
                    bookingToAdd.FlightID3 = null;
                }
                if (radioButtonRoundTrip.Checked)
                {
                    bookingToAdd.TripType = "Round Trip";
                }
                else
                {
                    bookingToAdd.TripType = "One Way";
                }
                bookingToAdd.BookingDate = DateTime.Now.Date.ToString("d");

                if (paymentMethod.SelectedItem == "Points")
                {
                    bookingToAdd.PaymentMethod = "Points";
                    bookingToAdd.PricePaid = 0;
                    bookingToAdd.PointsUsed = (int)selectedFlight.Price * 100;
                }
                else
                {
                    bookingToAdd.PaymentMethod = "Credit";
                    bookingToAdd.PointsUsed = 0;
                    bookingToAdd.PricePaid = selectedFlight.Price;
                }

                bookingToAdd.IsCancelled = false;
                db.Bookings.Add(bookingToAdd);
                LoadBookingData();
            }

            bookFlightBtn.Enabled = true;
        }
    }
}
