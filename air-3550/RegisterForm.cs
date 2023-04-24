using air_3550.Database;
using air_3550.Models;
using air_3550.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;
using System.Text;
using User = air_3550.Models.User;

namespace air_3550
{
    public partial class RegisterForm : Form
    {
        private DatabaseManager db;
        public RegisterForm()
        {
            InitializeComponent();
            db = DatabaseManager.Instance;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

           
            // Now build the User object to send to the DB.
            int UserID = db.UserIdSequences.GetNextUserID();
            string Password = txtPassword.Text;
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Age = txtAge.Text;
            string Phone = txtPhone.Text;
            string Address = txtAddress.Text;
            string CreditCard = txtCreditCard.Text;

            if (!IsValidFormat(FirstName, LastName, Password, Age, Phone, Address, CreditCard))
            {
                // Do nothing if format is invalid--handled by IsValidFormat
            } else
            {
                User user = new User();
                user.UserID = UserID;
                user.UserType = "customer";
                user.PasswordHash = AuthService.HashPassword(Password);

                Customer customer = new Customer();
                customer.UserID = UserID;
                customer.Address = Address;
                customer.CreditCard = CreditCard;
                customer.FirstName = FirstName;
                customer.LastName = LastName;
                customer.Age = Int32.Parse(Age);
                customer.Phone = Phone;
                customer.Address = Address;
                customer.CreditCard = CreditCard;


                db.Users.Add(user);
                db.Customers.Add(customer);
                MessageBox.Show($"Registration successful! Please save your User ID and use it for all future login attempts: {user.UserID}", "Registration successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }

           
        }
        // Validate and handle user input.
        private bool IsValidFormat(string fName, string lName, string pass, string age, string phone, string add, string card)
        {
            // If first name is blank, reject.
            if (fName == "")
            {
                MessageBox.Show("Please enter a first name.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Clear();
                return false;
            }
            // If last name is blank, reject.
            if (lName == "")
            {
                MessageBox.Show("Please enter a last name.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Clear();
                return false;
            }
            // If password is less than 8 characters, reject.
            if (pass.Length < 8)
            {
                MessageBox.Show("Password must be four characters or more. Please re-enter.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                return false;
            }
            // If age can't be numerically parsed or it's empty, reject.
            if (!Int32.TryParse(age, out int ageNum) || age == "")
            {
                MessageBox.Show("Please enter an age.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Clear();
                return false;
            }
            // If age is less than 18, reject.
            else if (ageNum < 18)
            {
                MessageBox.Show("Must be 18 or older to register.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Clear();
                return false;
            }

            // If phone can't be numerically parse or it's less than 10 characters, reject.
            if (!Int32.TryParse(phone, out int phoneNum) || phone.Length != 10)
            {
                MessageBox.Show("Phone number should be 10 digits long. Please re-enter.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Clear();
                return false;
            }
            // If address is blank, reject.
            if (add == "")
            {
                MessageBox.Show("Please ewnter an address.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Clear();
                return false;
            }
            // If card can't be numerically parse or it's less than 16 digits, reject.
            if (!Int32.TryParse(card, out int cardNum) || card.Length != 16) {
                MessageBox.Show("Card number should be 16 digits. Please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCreditCard.Clear();
                return false;
            }
            
            return true;
        }
    }
}
