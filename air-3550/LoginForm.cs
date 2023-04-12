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
            string userID = txtUserID.Text;
            string password = txtPassword.Text;

            // TODO: Replace hardcoded values with values from database.
            const string customerID = "customer";
            const string marketingManagerID = "marketingManager";
            const string accountingManagerID = "accountingManager";
            const string loadEngineerID = "loadEngineer";
            const string flightManagerID = "flightManager";
            const string adminPassword = "12345";
            if (password == adminPassword)
            {
                switch (userID)
                {
                    case customerID:
                        CustomerForm customerForm = new CustomerForm();
                        customerForm.Show();
                        break;
                    case marketingManagerID:
                        MarketingManagerForm marketingManagerForm = new MarketingManagerForm();
                        marketingManagerForm.Show();
                        break;
                    case accountingManagerID:
                        AccountingManagerForm accountingManagerForm = new AccountingManagerForm();
                        accountingManagerForm.Show();
                        break;
                    case loadEngineerID:
                        LoadEngineerForm loadEngineerForm = new LoadEngineerForm();
                        loadEngineerForm.Show();
                        break;
                    case flightManagerID:
                        FlightManagerForm flightManagerForm = new FlightManagerForm();
                        flightManagerForm.Show();
                        break;
                }
                this.Hide();
            }
            else
            {
                // Login failed, show an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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