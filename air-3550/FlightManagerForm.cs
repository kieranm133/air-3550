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

namespace air_3550
{
    public partial class FlightManagerForm : Form
    {
        private DatabaseManager db;
        private List<Flight> flights;
        private List<Booking> bookings;
        private List<Customer> customers;
        public FlightManagerForm()
        {
            InitializeComponent();
            db = DatabaseManager.Instance;
        }

        // logout -- return to login-form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show();
            this.Hide();
        }

        // 
        private void FlightManagerForm_Load(object sender, EventArgs e)
        {
            LoadScheduleData();
        }

        // Get the dataGridView source -- all of the scheduled flights
        private void LoadScheduleData()
        {
            List<Flight>? scheduledFlights = db.Flights.GetAll();
            dataGridView_Scheduled_Flights.DataSource = scheduledFlights;
            dataGridView_Scheduled_Flights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Display Manifest for given flight, obtain FlightID
        private void btnViewManifest_Click(object sender, EventArgs e)
        {

            if (dataGridView_Scheduled_Flights != null && dataGridView_Scheduled_Flights.Rows.Count > 0)
            {
                var flightSelect = dataGridView_Scheduled_Flights.SelectedRows[0];
                int flightId = (int)flightSelect.Cells["FlightID"].Value;
                var flightManifest = new ManifestForm(customers, flightId);
                flightManifest.ShowDialog();
            }
        }
    }
}
