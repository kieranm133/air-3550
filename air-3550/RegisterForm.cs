using air_3550.Database;
using air_3550.Models;
using System.Security.Cryptography;
using System.Text;

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
            DatabaseManager db = DatabaseManager.Instance;
            if (!IsValidFormat())
            {
                MessageBox.Show("Invalid registration data: One or more fields was not in the proper format. Please try again.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
            }
            // Now build the User object to send to the DB.
            int UserID = db.UserIdSequences.GetNextUserID();
            string Password = txtPassword.Text;
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            int Age = Int32.Parse(txtAge.Text);
            string Phone = txtPhone.Text;
            string Address = txtAddress.Text;
            string CreditCard = txtCreditCard.Text;



            User user = new User();
            user.UserID = UserID;
            user.UserType = "customer";
            user.PasswordHash = HashPassword(Password);

            Customer customer = new Customer();
            customer.UserID = UserID;
            customer.Address = Address;
            customer.CreditCard = CreditCard;
            customer.FirstName = FirstName;
            customer.LastName = LastName;
            customer.Age = Age;
            customer.Phone = Phone;
            customer.Address = Address;
            customer.CreditCard = CreditCard;


            db.Users.AddUser(user);
            db.Customers.AddCustomer(customer);
            MessageBox.Show($"Registration successful! Please save your User ID and use it for all future login attempts: {user.UserID}", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();


        }
        private bool IsValidFormat()
        {
            return true;
        }

        private string HashPassword(string password)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytePass = Encoding.UTF8.GetBytes(password);
                byte[] byteHash = sha512.ComputeHash(bytePass);
                return Encoding.UTF8.GetString(byteHash);
            }
        }
    }
}
