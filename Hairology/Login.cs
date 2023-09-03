namespace Hairology
{
    public partial class Login : Form
    {
        public string username = default!;
        private string _password = default!;
        private bool _togglePassword = default!;
        private MainWindow _mainWindow;
        private Encryption _encrypt;
        public Login()
        {
            InitializeComponent();
            tbxPassword.UseSystemPasswordChar = true;
            pbxTogglePassword.BackgroundImage = Properties.Resources.showpassword;
            _togglePassword = false;
        }
        /// <summary>
        /// hashes password and submits credentials when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text != "" && tbxUsername.Text != "")
            {
                username = tbxUsername.Text;
                _encrypt = new Encryption(tbxPassword.Text);
                _password = _encrypt.CreateMD5Hash();
                _mainWindow = new MainWindow(username);
                _mainWindow.Show();
                this.Hide();
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