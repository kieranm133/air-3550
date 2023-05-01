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
    public partial class MarketingManagerForm : Form
    {
        private DatabaseManager db;
        private List<Aircraft> aircraft;
        private List<ScheduledFlight> flights;

        public MarketingManagerForm()
        {
            InitializeComponent();
            db = DatabaseManager.Instance;
            this.aircraft = db.Aircraft.GetAll();
            this.flights = db.ScheduledFlights.GetAll();
        }
        private void MarketingManagerForm_Load(object sender, EventArgs e)
        {
            LoadScheduleData();
            LoadPlanesAvailable();
        }
        // Get the dataGridView source -- all of the scheduled flights
        private void LoadScheduleData()
        {
            List<ScheduledFlight>? scheduledFlights = db.ScheduledFlights.GetAll();
            dataGridView_Scheduled_Flights.DataSource = scheduledFlights;
            dataGridView_Scheduled_Flights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Populate comboBoxPlanesAvailable with available aircraft
        private void LoadPlanesAvailable()
        {
            if (comboBoxPlanesAvailable.Items.Count == 0)
            {
                List<Aircraft>? availableAircraft = db.Aircraft.GetAll();
                comboBoxPlanesAvailable.DataSource = availableAircraft;
                comboBoxPlanesAvailable.DisplayMember = "ModelAndCapacity";
            }
        }

        // logout -- return to login-form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        // Populate dataGridView_Scheduled_Flights with current flight schedule
        private void btn_ViewFlights_Click(object sender, EventArgs e)
        {
            LoadScheduleData();
        }

        // Populate comboBoxPlanesAvailable with available aircraft
        private void btn_ViewPlanes_Click(object sender, EventArgs e)
        {
            LoadPlanesAvailable();
        }

        // Set aircraft type
        private void button1_Click(object sender, EventArgs e)
        {
            Aircraft selectedAircraft = comboBoxPlanesAvailable.SelectedItem as Aircraft;
            List<int> scheduledFlightIDs = dataGridView_Scheduled_Flights.SelectedRows.Cast<DataGridViewRow>().Select(r => (int)r.Cells["ScheduledFlightID"].Value).ToList();

            db.ScheduledFlights.SetAircraftByID(selectedAircraft, scheduledFlightIDs);
            LoadScheduleData();
        }
    }
}
