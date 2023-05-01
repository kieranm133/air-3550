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
    public partial class AccountingManagerForm : Form
    {
        private DatabaseManager db;
        private List<Flight> flights;
        private List<Booking> bookings;
        private List<FlightWithInfo> flightsWithInfo;
        private List<int> flightIDs;
        public AccountingManagerForm()
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

        // Load scheduled flights
        private void LoadFlights()
        {
            List<Flight>? scheduledFlights = db.Flights.GetAll();
            dataGridViewFlights.DataSource = scheduledFlights;
            dataGridViewFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Populate forms
        private void AccountingManagerForm_Load(object sender, EventArgs e)
        {
            LoadFlights();
            get_IncomePerFlight();
            LoadSummary();
            get_percentCapacity();
        }

        // Calculate and display individual flight revenue
        private void get_IncomePerFlight()
        {
            DataGridViewTextBoxColumn perFlightIncome = new DataGridViewTextBoxColumn();
            perFlightIncome.HeaderText = "Flight Income";
            perFlightIncome.Name = "FlightIncome";
            perFlightIncome.ValueType = typeof(double);
            perFlightIncome.DefaultCellStyle.Format = "C2";
            dataGridViewFlights.Columns.Add(perFlightIncome);

            // Get income for each flight, display in FlightID column
            dataGridViewFlights.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
                row.Cells["FlightIncome"].Value = db.Flights.GetFlightTotalIncome((int)row.Cells["FlightID"].Value));
        }

        // Calculate and display percentage of flight capacity
        private void get_percentCapacity()
        {
            DataGridViewTextBoxColumn percentCapacity = new DataGridViewTextBoxColumn();
            percentCapacity.HeaderText = "Percent Capacity";
            percentCapacity.Name = "PercentCapacity";
            percentCapacity.ValueType = typeof(double);
            percentCapacity.DefaultCellStyle.Format = "P2";
            dataGridViewFlights.Columns.Add(percentCapacity);

            // Get flight info for capacity calculation
            List<int> flightIDs = dataGridViewFlights.Rows.Cast<DataGridViewRow>().Select(row =>
                Convert.ToInt32(row.Cells["FlightID"].Value)).ToList();
            List<FlightWithInfo> flightInfo = db.Flights.GetAllFlightInfoByID(flightIDs);

            // Compute and display percent capacity in "PercentCapacity" column
            flightInfo.Select((flight, index) =>
            {
                double percentageFilled = 1 - (Convert.ToDouble(dataGridViewFlights.Rows[index].Cells["EmptySeats"].Value) /
                Convert.ToDouble(flight.Aircraft.Capacity));
                dataGridViewFlights.Rows[index].Cells["PercentCapacity"].Value = percentageFilled;
                return percentageFilled;
            }).ToList();
        }

        // Load summary information -- total flights and revenue
        private void LoadSummary()
        {
            DataGridViewTextBoxColumn numFlights = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn totRevenue = new DataGridViewTextBoxColumn();

            numFlights.HeaderText = "Total Number of Flights";
            numFlights.DataPropertyName = "TotalFlights";
            numFlights.Name = "TotalFlights";
            totRevenue.HeaderText = "Total Revenue";
            totRevenue.DataPropertyName = "TotalRevenue";
            totRevenue.Name = "TotalRevenue";
            totRevenue.DefaultCellStyle.Format = "C2";

            dataGridViewSummary.Columns.Add(numFlights);
            dataGridViewSummary.Columns.Add(totRevenue);
            dataGridViewSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // sum total revenue
            double totalRevenue = dataGridViewFlights.Rows.Cast<DataGridViewRow>().Sum(row =>
                            (double)row.Cells["FlightIncome"].Value);

            dataGridViewSummary.Rows[0].Cells["TotalFlights"].Value = dataGridViewFlights.RowCount.ToString();
            dataGridViewSummary.Rows[0].Cells["TotalRevenue"].Value = totalRevenue;
        }
    }
}
