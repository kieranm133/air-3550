using air_3550.Database;
using air_3550.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoCoordinatePortable;
using Microsoft.VisualBasic.ApplicationServices;

namespace air_3550
{
    public partial class LoadEngineerForm : Form
    {
        private DatabaseManager db;
        private List<Airport> airports;
        public LoadEngineerForm()
        {
            InitializeComponent();
            db = DatabaseManager.Instance;
            this.airports = db.Airports.GetAll();

        }

        // On load, get the possible locations for a Load Engineer to send flights to and from.
        private void LoadEngineerForm_Load(object sender, EventArgs e)
        {
            // Get the origin combo box source
            comboBoxOrigin.DataSource = new List<Airport>(airports);
            comboBoxOrigin.DisplayMember = "Name";
            comboBoxOrigin.ValueMember = "AirportID";
            comboBoxOrigin.SelectedIndex = -1;

            // Get the destination combo box source
            comboBoxDestination.DataSource = new List<Airport>(airports);
            comboBoxDestination.DisplayMember = "Name";
            comboBoxDestination.ValueMember = "AirportID";
            comboBoxDestination.SelectedIndex = -1;

            LoadScheduleData();

        }

        private void LoadScheduleData()
        {
            // Get the dataGridView source--all of the scheduled flights
            // TODO: Join create a method in ScheduledFlightsRepository to join all relevant info.
            List<ScheduledFlight>? scheduledFlights = db.ScheduledFlights.GetAll();
            dataGridViewSchedule.DataSource = scheduledFlights;
            dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox changed = sender as ComboBox;
            ComboBox other = (changed == comboBoxOrigin ? comboBoxDestination : comboBoxOrigin);

            if (changed.SelectedIndex != -1 && other.SelectedIndex != -1)
            {
                if (changed.SelectedIndex == other.SelectedIndex)
                {
                    // Set the other ComboBox to have no selection
                    other.SelectedIndex = -1;
                    btnAddToSchedule.Enabled = false;
                }
                else
                {
                    btnAddToSchedule.Enabled = true;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }


        // Add the currently selected trips to the schedule. 
        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {
            // Get the Airport models
            ScheduledFlight scheduledFlightToAdd = new ScheduledFlight();
            Airport originAirport = airports.Where(a => a.AirportID == (string)comboBoxOrigin.SelectedValue).First();
            Airport destinationAirport = airports.Where(a => a.AirportID == (string)comboBoxDestination.SelectedValue).First();

            // Now we calculate the total point-to-point distance of the flight.
            GeoCoordinate originLoc = new GeoCoordinate(originAirport.Latitude, originAirport.Longitude);
            GeoCoordinate destinationLoc = new GeoCoordinate(destinationAirport.Latitude, destinationAirport.Longitude);

            // Get the total distance in miles
            double totalDistance = originLoc.GetDistanceTo(destinationLoc) * 0.000621371192;

            // Assume 500 miles per hour in flight + 30 flat 
            TimeSpan addedTime = TimeSpan.FromMinutes((int)((totalDistance / 500) * 60) + 30);

            // Set the departure and arrival times.
            TimeSpan departureTime = dateTimePickerDepartureTime.Value - dateTimePickerDepartureTime.Value.Date;
            TimeSpan arrivalTime = departureTime.Add(addedTime);

            // Add all the values to the model and send to the DB!
            scheduledFlightToAdd.OriginAirportID = originAirport.AirportID;
            scheduledFlightToAdd.DestinationAirportID = destinationAirport.AirportID;
            scheduledFlightToAdd.AircraftID = null;
            scheduledFlightToAdd.DepartureTime = departureTime.ToString("hh\\:mm");
            scheduledFlightToAdd.ArrivalTime = arrivalTime.ToString("hh\\:mm");
            scheduledFlightToAdd.Distance = totalDistance;
            db.ScheduledFlights.Add(scheduledFlightToAdd);
            LoadScheduleData();
            MessageBox.Show($"A Flight from {originAirport.AirportID} to {destinationAirport.AirportID} has been successfully added to the schedule.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
