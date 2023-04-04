namespace air_3550
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); // Replace 'MainForm' with the name of your main application form
            loginForm.Show();
            this.Hide();
        }
    }
}
