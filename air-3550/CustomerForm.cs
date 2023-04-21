using air_3550.Database;
using air_3550.Models;
using air_3550.Services;
using Dapper;
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

            // Get the destination combo box source
            comboBoxTo.DataSource = new List<Airport>(airports);
            comboBoxTo.DisplayMember = "CityState";
            comboBoxTo.ValueMember = "AirportID";
            comboBoxTo.SelectedIndex = -1;

            // Get the dataGridView source--all of the scheduled flights
            // TODO: Join create a method in ScheduledFlightsRepository to join all relevant info.
            List<Booking>? book = db.Bookings.GetAll();
            dataGridView1.DataSource = book;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Add the profile info
            buildTableLayout();
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

        private void SearchFlights()
        {



            if (comboBoxFrom.SelectedIndex != -1 && comboBoxTo.SelectedIndex != -1)
            {
                bool roundTrip = radioButtonRoundTrip.Checked;
                string originAirportId = (string)comboBoxFrom.SelectedValue;
                string destinationAirportId = (string)comboBoxTo.SelectedValue;
                List<Booking> searchResults = db.Bookings.Search(originAirportId, destinationAirportId, roundTrip);
                dataGridViewSearchResults.DataSource = searchResults;
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

            List<ScheduledFlight> allScheduledFlights = db.ScheduledFlights.GetAll();
            Dictionary<int, ScheduledFlight> scheduledFlightLookup = allScheduledFlights.ToDictionary(sf => sf.ScheduledFlightID);

            List<List<ScheduledFlight>> results = FlightPathCalculator.GetAllRoutes(originAirportID, destinationAirportID);

            List<List<Flight>> routes = results
                    .Select(sl => db.Flights.GetByScheduledFlightIDAndDate(sl.Select(s => s.ScheduledFlightID).ToList(), departureDate)).ToList();

            List<List<(Flight flight, ScheduledFlight scheduledFlight)>> combined = routes
                .Where(route => route.All(f => f.EmptySeats != 0))
                .Select(route => route
                    .Select(flight => (flight, scheduledFlight: allScheduledFlights[flight.ScheduledFlightID]))
                    .ToList())
                .ToList();

            List<BookingFlightViewModel> flightDisplays = combined
                .Select(route =>
                {
                    (Flight firstFlight, ScheduledFlight firstScheduledFlight) = route.First();
                    (Flight lastFlight, ScheduledFlight lastScheduledFlight) = route.Last();
                    List<int> flightIDs = route.Select(flightTuple => flightTuple.flight.FlightID).ToList();

                    return new BookingFlightViewModel
                    {
                        DepartureAirport = firstScheduledFlight.OriginAirportID,
                        ArrivalAirport = lastScheduledFlight.DestinationAirportID,
                        DepartureDate = firstFlight.DepartureDate,
                        ArrivalDate = lastFlight.ArrivalDate,
                        DepartureTime = firstScheduledFlight.DepartureTime,
                        ArrivalTime = lastScheduledFlight.ArrivalTime,
                        NumberOfConnections = route.Count - 1,
                        FlightIDs = flightIDs
                    };
                }).ToList();
            dataGridViewSearchResults.DataSource = flightDisplays;
        }
    }
}
