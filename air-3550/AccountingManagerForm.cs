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
        public AccountingManagerForm()
        {
            InitializeComponent();
            db = DatabaseManager.Instance;
            this.flights = db.Flights.GetAll();
            this.bookings = db.Bookings.GetAll();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); // Replace 'MainForm' with the name of your main application form
            loginForm.Show();
            this.Hide();
        }

        private void LoadFlights()
        {
            List<Flight>? scheduledFlights = db.Flights.GetAll();
            dataGridViewFlights.DataSource = scheduledFlights;
            dataGridViewFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void AccountingManagerForm_Load(object sender, EventArgs e)
        {
            LoadFlights();
            get_IncomePerFlight();
            LoadSummary();
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

            // Get income for each flight
            dataGridViewFlights.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
                row.Cells["FlightIncome"].Value = db.Flights.GetFlightTotalIncome((int)row.Cells["FlightID"].Value));
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
