using air_3550.Database;
using air_3550.Models;
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
                txtPassword.Clear();
            } else
            {
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
        //TODO: validate user input.
        private bool IsValidFormat(string fName, string lName, string pass, string age, string phone, string add, string card)
        {
            if (fName == "")
            {
                MessageBox.Show("Please enter a first name.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (lName == "")
            {
                MessageBox.Show("Please enter a last name.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pass.Length < 4)
            {
                MessageBox.Show("Password must be four characters or more. Please re-enter.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (age != "")
            {
                if (Int32.Parse(age) < 18)
                {
                    MessageBox.Show("Must be 18 or older to register.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else
            {
                MessageBox.Show("Please enter an age.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (phone.Length != 10)
            {
                MessageBox.Show("Phone number should be 10 digits long. Please re-enter.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (add == "")
            {
                MessageBox.Show("Please ewnter an address.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (card.Length != 16) {
                MessageBox.Show("Card number should be 16 digits. Please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
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
