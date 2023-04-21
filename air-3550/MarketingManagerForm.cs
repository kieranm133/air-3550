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

        //Get the dataGridView source -- all of the scheduled flights
        private void LoadScheduleData()
        {
            List<ScheduledFlight>? scheduledFlights = db.ScheduledFlights.GetAll();
            dataGridView_Scheduled_Flights.DataSource = scheduledFlights;
            dataGridView_Scheduled_Flights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); // Replace 'MainForm' with the name of your main application form
            loginForm.Show();
            this.Hide();
        }

        private void btn_ViewFlights_Click(object sender, EventArgs e)
        {
            LoadScheduleData();
        }
    }
}
