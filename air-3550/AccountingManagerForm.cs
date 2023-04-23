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
        public AccountingManagerForm()
        {
            InitializeComponent();
            db = DatabaseManager.Instance;
            this.flights = db.Flights.GetAll();
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
            get_FlightCount();
            get_IncomePerFlight(); 
        }

        private void get_FlightCount()
        {
            Label totalNumberOfFlights = new Label();
            totalNumberOfFlights.Text = "Total Number of Flights: " + dataGridViewFlights.RowCount.ToString();
            statusStripFlights.Items.Add(totalNumberOfFlights.Text);
        }

        private void get_IncomePerFlight()
        {
            DataGridViewTextBoxColumn perFlightIncome = new DataGridViewTextBoxColumn();
            perFlightIncome.HeaderText = "Flight Income";
            perFlightIncome.Name = "Total";
            dataGridViewFlights.Columns.Add(perFlightIncome);
        }

    }
}
