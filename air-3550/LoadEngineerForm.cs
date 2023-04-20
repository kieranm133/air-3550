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
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
