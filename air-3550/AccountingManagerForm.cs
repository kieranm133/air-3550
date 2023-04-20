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
        private List<Airport> airports;
        public AccountingManagerForm()
        {
            InitializeComponent();
            db = DatabaseManager.Instance;
            this.airports = db.Airports.GetAll();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); // Replace 'MainForm' with the name of your main application form
            loginForm.Show();
            this.Hide();
        }
    }
}
