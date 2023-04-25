using air_3550.Database;
using air_3550.Models;
using air_3550.Services;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace air_3550
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseManager db = DatabaseManager.Instance;

            int userID = Int32.Parse(txtUserID.Text);
            string passwordHash = AuthService.HashPassword(txtPassword.Text);
            User userResult = db.Users.GetUserById(userID);
            // If the result is not null and the password hash worked, this is a valid user. Redirect based on user_type.
            if (userResult != null && userResult.PasswordHash == passwordHash)
            {
                switch (userResult.UserType)
                {
                    case "customer":
                        CustomerForm customerForm = new CustomerForm(userResult);
                        customerForm.Show();
                        break;
                    case "marketing_manager":
                        MarketingManagerForm marketingManagerForm = new MarketingManagerForm();
                        marketingManagerForm.Show();
                        break;
                    case "flight_manager":
                        FlightManagerForm flightManagerForm = new FlightManagerForm();
                        flightManagerForm.Show();
                        break;
                    case "load_engineer":
                        LoadEngineerForm loadEngineerForm = new LoadEngineerForm();
                        loadEngineerForm.Show();
                        break;
                    case "accounting_manager":
                        AccountingManagerForm accountingManagerForm = new AccountingManagerForm();
                        accountingManagerForm.Show();
                        break;
                }
                this.Hide();
            }
            else
            {
                // Login failed, show an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Clear();
                txtPassword.Clear();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}