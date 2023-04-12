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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!isValidFormat())
            {
                MessageBox.Show("Invalid registration data: One or more fields was not in the proper format. Please try again.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
            }


        }
        private bool isValidFormat() {

            return true;
        }
    }
}
