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

        public LoadEngineerForm()
        {
            InitializeComponent();
            db = DatabaseManager.Instance;

        }

        // On load, get the possible locations for a Load Engineer to send flights to and from.
        private void LoadEngineerForm_Load(object sender, EventArgs e)
        {
            List<Airport>? airports = db.Airports.GetAllAirports();
            foreach (var airport in airports)
            {
                ListViewItem item = new ListViewItem(airport.AirportID);
                item.SubItems.Add(airport.Name);
                item.SubItems.Add(airport.City);
                item.SubItems.Add(airport.State);
                listViewLocations.Items.Add(item);
            }


        }
    }
}
