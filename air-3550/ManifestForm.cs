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
    public partial class ManifestForm : Form
    {
        private DatabaseManager db;
        private List<Customer> customerList;
        private int flightId;
        public ManifestForm(List<Customer> customerList, int flightId)
        {
            InitializeComponent();
            db = DatabaseManager.Instance;
            this.flightId = flightId;
            this.customerList = customerList;
        }

        //Shows flight manifest
        private void ManifestForm_Load(object sender, EventArgs e)
        {
            List<Customer>? customers = db.Customers.GetCustomersByFlightID(flightId);
            var customersView = customers.Select(customer => new { customer.UserID, customer.FirstName, customer.LastName }).ToList();
            dataGridViewManifest.DataSource = customersView;
            dataGridViewManifest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
