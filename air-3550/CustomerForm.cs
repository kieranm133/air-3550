using air_3550.Database;
using air_3550.Models;
using air_3550.Repositories;
using air_3550.Services;
using Dapper;
using GeoCoordinatePortable;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = air_3550.Models.User;

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

            string[] payment = { "Credit", "Points" };
            paymentMethod.DataSource = payment;
            paymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;

            // Get the dataGridView source--all of the scheduled flights
            // TODO: Join create a method in ScheduledFlightsRepository to join all relevant info.
            bookingView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dateTimePickerDeparture.MinDate = DateTime.Today;
            dateTimePickerReturn.MinDate = DateTime.Today.AddDays(1);

            dateTimePickerDeparture.MaxDate = DateTime.Today.AddMonths(6);
            dateTimePickerReturn.MaxDate = DateTime.Today.AddMonths(6);
            // Add the profile info
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
            dataGridView2.Rows.Clear();
            DataGridViewRow selectedRow = bookingView.SelectedRows[0];
            Booking booking = (Booking)selectedRow.DataBoundItem;
            FlightWithInfo flightInfo = new FlightWithInfo();
            flightInfo = db.Flights.GetAllFlightInfoByID(booking.FlightID1);

            dataGridView2.Rows.Add("FlightID", booking.FlightID1);
            dataGridView2.Rows.Add("First name", this.customerRecord.FirstName);
            dataGridView2.Rows.Add("Last name", this.customerRecord.LastName);
            dataGridView2.Rows.Add("Date", flightInfo.Flight.DepartureDate);
            dataGridView2.Rows.Add("From", flightInfo.OriginAirport.City);
            dataGridView2.Rows.Add("To", flightInfo.DestinationAirport.City);
            dataGridView2.Rows.Add("Departure", flightInfo.ScheduledFlight.DepartureTime);
            dataGridView2.Rows.Add("Arrival", flightInfo.ScheduledFlight.ArrivalTime);
            dataGridView2.Rows.Add("Account", customerRecord.UserID);
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
                dateTimePickerReturn.Enabled = false;
                dataGridViewSearchResultsReturn.Enabled = false;
                dataGridViewSearchResultsReturn.DataSource = null;
            }
            else
            {
                dateTimePickerReturn.Enabled = true;
                dataGridViewSearchResultsReturn.Enabled = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelFlightsNotFound.Visible = false;
            string dateStringDeparture = dateTimePickerDeparture.Value.ToString("yyyy-MM-dd");
            string dateStringReturn = dateTimePickerReturn.Value.ToString("yyyy-MM-dd");
            string originAirportID = (string)comboBoxFrom.SelectedValue;
            string destinationAirportID = (string)comboBoxTo.SelectedValue;
            if (radioButtonOneWay.Checked)
            {
                dataGridViewSearchResultsOutbound.DataSource = searchFlights(dateStringDeparture, originAirportID, destinationAirportID);
                dataGridViewSearchResultsReturn.DataSource = null;
                if (dataGridViewSearchResultsOutbound.DataSource == null)
                {
                    labelFlightsNotFound.Visible = true;
                }
            }
            else
            {
                dataGridViewSearchResultsOutbound.DataSource = searchFlights(dateStringDeparture, originAirportID, destinationAirportID);
                dataGridViewSearchResultsReturn.DataSource = searchFlights(dateStringReturn, destinationAirportID, originAirportID);
                if (dataGridViewSearchResultsOutbound.DataSource == null && dataGridViewSearchResultsReturn.DataSource == null)
                {
                    labelFlightsNotFound.Visible = true;
                }
            }

        }
        private void UpdateBookFlightBtnState(object sender, EventArgs e)
        {
            bool isOneWaySelected = radioButtonOneWay.Checked;
            bool isRoundTripSelected = radioButtonRoundTrip.Checked;
            bool hasOutboundSelection = dataGridViewSearchResultsOutbound.SelectedRows.Count > 0;
            bool hasReturnSelection = dataGridViewSearchResultsReturn.SelectedRows.Count > 0;

            if (isOneWaySelected && hasOutboundSelection)
            {
                bookFlightBtn.Enabled = true;
            }
            else if (isRoundTripSelected && hasOutboundSelection && hasReturnSelection)
            {
                bookFlightBtn.Enabled = true;
            }
            else
            {
                bookFlightBtn.Enabled = false;
            }
        }

        private void LoadBookingData()
        {
            db.Customers.UpdateCustomerPoints();
            this.customerRecord = db.Customers.GetByID(userRecord.UserID);
            string points = "Points Available: ";
            points += customerRecord.PointsAvailable;
            buildMyProfile();
            // Get the dataGridView source--all of the scheduled flights
            // TODO: Join create a method in ScheduledFlightsRepository to join all relevant info.
            List<Booking>? bookings = db.Bookings.GetAllByIDWithoutCancellations(this.customerRecord.UserID);
            bookingView.DataSource = bookings;
            bookingView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            label11.Text = points;
        }

        private void bookFlightBtn_Click(object sender, EventArgs e)
        {


            bookFlightBtn.Enabled = false;

            bool isRoundtrip = radioButtonRoundTrip.Checked;
            bool outboundIsSelected = dataGridViewSearchResultsOutbound.SelectedRows.Count > 0;
            bool returnIsSelected = dataGridViewSearchResultsReturn.SelectedRows.Count > 0;
            // Get the Airport models

            DataGridViewRow selectedRow = dataGridViewSearchResultsOutbound.SelectedRows[0];
            BookingFlightViewModel outboundFlight = (BookingFlightViewModel)selectedRow.DataBoundItem;
            if (isRoundtrip)
            {

                selectedRow = dataGridViewSearchResultsOutbound.SelectedRows[0];
                BookingFlightViewModel returnFlight = (BookingFlightViewModel)selectedRow.DataBoundItem;
                bookDialog(outboundFlight, returnFlight);
            }
            else
            {
                bookDialog(outboundFlight);
            }

            bookFlightBtn.Enabled = true;
        }
        private void bookDialog(BookingFlightViewModel outboundFlight, BookingFlightViewModel? returnFlight = null)
        {
            double totalPrice = outboundFlight.Price + (returnFlight != null ? returnFlight.Price : 0);
            int totalPoints = (int)(totalPrice * 100);
            if (totalPoints > customerRecord.PointsAvailable && paymentMethod.SelectedItem == "Points")
            {
                MessageBox.Show("Not enough points for flight. Please select credit.", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string creditMessage = $"Are you sure you want to book the flight(s) for ${totalPrice}?";
                string pointsMessage = $"Are you sure you want to book the flight(s) for {totalPoints} points?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string title = "Confirmation";
                DialogResult result = MessageBox.Show(paymentMethod.SelectedItem == "Points" ? pointsMessage : creditMessage, title, buttons);

                if (result == DialogResult.Yes)
                {
                    bookFlight(outboundFlight);
                    if (returnFlight != null) { bookFlight(returnFlight); };
                    if (paymentMethod.SelectedItem == "Points")
                    {
                        this.customerRecord.PointsAvailable -= totalPoints;
                        db.Customers.Update(this.customerRecord);
                        string transactionMessage = $@"Transaction successful!
                                           Name:{customerRecord.FirstName} {customerRecord.LastName}
                                           Total: ${totalPoints} points";
                        MessageBox.Show(transactionMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string transactionMessage = $@"Transaction successful!
                                           Name:{customerRecord.FirstName} {customerRecord.LastName}
                                           Credit card: **** **** **** {this.customerRecord.CreditCard.Substring(this.customerRecord.CreditCard.Length - 4)}
                                           Total: ${totalPrice}";
                        MessageBox.Show(transactionMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadBookingData();
                }
                else
                {

                }
            }
        }
        private void buildMyProfile()
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

        private List<BookingFlightViewModel> searchFlights(string departureDate, string originAirportID, string destinationAirportID)
        {
            List<ScheduledFlight> allScheduledFlights = db.ScheduledFlights.GetAll();

            Dictionary<int, ScheduledFlight> scheduledFlightLookup = allScheduledFlights.ToDictionary(sf => sf.ScheduledFlightID);

            List<List<ScheduledFlight>> results = FlightPathCalculator.GetAllRoutes(originAirportID, destinationAirportID);
            if (results == null) return null;

            List<List<Flight>?> routes = results
                    .Select(sl => db.Flights.GetByScheduledFlightIDAndDate(sl.Select(s => s.ScheduledFlightID).ToList(), departureDate)).ToList();
            if (routes == null || routes.Count == 0 || routes[0].Count == 0)
            {
                return null;
            }
            List<List<(Flight flight, ScheduledFlight scheduledFlight)>> combined = routes
                .Where(route => route.All(f => f.EmptySeats != 0))
                .Select(route => route
                    .Select(flight => (flight, scheduledFlight: scheduledFlightLookup[flight.ScheduledFlightID]))
                    .ToList())
                .ToList();

            List<BookingFlightViewModel> flightDisplays = combined
                .Select(route =>
                {
                    // TODO: Fix this to deal with multiple different flights in the route.
                    (Flight firstFlight, ScheduledFlight firstScheduledFlight) = route.First();
                    (Flight lastFlight, ScheduledFlight lastScheduledFlight) = route.Last();
                    List<int> flightIDs = route.Select(flightTuple => flightTuple.flight.FlightID).ToList();
                    double totalDistance = 0.0;
                    route.ForEach(flightTuple => totalDistance += flightTuple.scheduledFlight.Distance);
                    double price = 50 + totalDistance * 0.12 + (8 * (route.Count - 1));
                    TimeSpan depart = TimeSpan.Parse(firstScheduledFlight.DepartureTime);
                    TimeSpan arrival = TimeSpan.Parse(lastScheduledFlight.DepartureTime);

                    if (depart.Hours < 5 || arrival.Hours < 5)
                    {
                        price *= 0.8;
                    }
                    else if (depart.Hours < 8 || arrival.Hours >= 7)
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
                        Connections = route.Count - 1,
                        FlightIDs = flightIDs,
                        Price = price
                    };
                }).ToList();
            return flightDisplays;
        }
        private Booking bookFlight(BookingFlightViewModel selectedFlight)
        {
            List<int> flightIDs = selectedFlight.FlightIDs;
            Booking bookingToAdd = new Booking();
            bookingToAdd.CustomerID = this.customerRecord.UserID;
            if (selectedFlight.Connections == 2)
            {
                bookingToAdd.FlightID1 = flightIDs.ElementAt(0);
                bookingToAdd.FlightID2 = flightIDs.ElementAt(1);
                bookingToAdd.FlightID3 = flightIDs.ElementAt(2);
            }
            else if (selectedFlight.Connections == 1)
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
            bookingToAdd.BookingDate = DateTime.Now.Date.ToString("yyyy-MM-dd");

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
            db.Bookings.Insert(bookingToAdd);
            return bookingToAdd;
        }

        private void dateTimePickerDeparture_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerReturn.MinDate = dateTimePickerDeparture.Value.AddDays(1);
        }

        private void btnSubmitPasswordChange_Click(object sender, EventArgs e)
        {
            string currentPassHash = AuthService.HashPassword(txtCurrentPass.Text);
            // If the password is not equal to the current password, don't allow the change.
            if (this.userRecord.PasswordHash != currentPassHash)
            {
                string msg = "The current password entered was incorrect. Please try again.";
                MessageBox.Show(msg, "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.userRecord.PasswordHash = AuthService.HashPassword(txtNewPass.Text);
                db.Users.Update(userRecord);
                string msg = "Your password was successfully changed!";
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtCurrentPass.Clear();
            txtNewPass.Clear();
        }

        // Check if the flight is within the constraints to be able to cancel. If it is, then allow the user to click the button.
        private void bookingView_SelectionChanged(object sender, EventArgs e)
        {
            btnCancelFlight.Enabled = false;
            Booking selectedBooking = (Booking)bookingView.CurrentRow.DataBoundItem;

            if (selectedBooking != null)
            {

                FlightWithInfo info = db.Flights.GetAllFlightInfoByID(selectedBooking.FlightID1);
                DateTime flightTime = DateTime.ParseExact(info.Flight.DepartureDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                flightTime = flightTime + (DateTime.ParseExact(info.ScheduledFlight.DepartureTime, "HH:mm", CultureInfo.InvariantCulture) - DateTime.Today);
                // If it's at least an hour before flightTime, allow a user to cancel their flight. Otherwise, do not allow it.
                if (flightTime >= DateTime.Now.AddHours(1))
                {
                    btnCancelFlight.Enabled = true;
                }
                else
                {
                    btnCancelFlight.Enabled = false;
                }
            }
        }

        // TODO: Cancel the user's flight by disabling the booking. 
        private void btnCancelFlight_Click(object sender, EventArgs e)
        {
            btnCancelFlight.Enabled = false;
            Booking selectedBooking = (Booking)bookingView.CurrentRow.DataBoundItem;
            if (selectedBooking != null)
            {
                // First, calculate the total points value to refund to the user.
                // If they used credit, refund price * 100. If they used points, just refund the points.
                int totalPointsRefund = (int)(selectedBooking.PricePaid != 0 ? selectedBooking.PricePaid * 100 : selectedBooking.PointsUsed);
                // Confirm the cancellation with the user.
                string confirmationMessage = $"Are you sure you want to cancel the booking?\nYour account will be credited {totalPointsRefund} points.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(confirmationMessage, "Confirm cancellation", buttons);
                if (result == DialogResult.Yes)
                {
                    this.customerRecord.PointsAvailable += totalPointsRefund;
                    db.Customers.Update(this.customerRecord);
                    db.Bookings.CancelByID(selectedBooking.BookingID);
                    LoadBookingData();
                    string msg = $"Successfully cancelled the flight!\n{totalPointsRefund} points have been credited to your account.";
                    MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
