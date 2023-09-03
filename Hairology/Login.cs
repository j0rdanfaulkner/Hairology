namespace Hairology
{
    public partial class Login : Form
    {
        private string _username = default!;
        private string _password = default!;
        private bool _togglePassword = default!;
        private Encryption _encrypt = new Encryption();
        public Login()
        {
            InitializeComponent();
            tbxPassword.UseSystemPasswordChar = true;
            pbxTogglePassword.BackgroundImage = Properties.Resources.showpassword;
            _togglePassword = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text != "" && tbxUsername.Text != "")
            {
                _username = tbxUsername.Text;
                _password = _encrypt.CreateMD5Hash(tbxPassword.Text);
            }
        }
        /// <summary>
        /// toggles whether to show or hide the password in the password textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxTogglePassword_Click(object sender, EventArgs e)
        {
            if (_togglePassword == false)
            {
                pbxTogglePassword.BackgroundImage = Properties.Resources.hidepassword;
                tbxPassword.UseSystemPasswordChar = false;
                _togglePassword = true;
            }
            else if (_togglePassword == true)
            {
                pbxTogglePassword.BackgroundImage = Properties.Resources.showpassword;
                tbxPassword.UseSystemPasswordChar = true;
                _togglePassword = false;
            }
        }
    }
}