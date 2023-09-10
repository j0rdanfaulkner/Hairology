using System.Data.SqlClient;

namespace Hairology
{
    public partial class Login : Form
    {
        public string username = default!;
        private string _password = default!;
        private bool _togglePassword = default!;
        private MainWindow _mainWindow;
        private Encryption _encrypt;
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
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
                _dbInstance.ConnectToDatabase();
                _dbInstance.conn.Open();
                _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_ACCOUNT, username), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    if (username == _reader["username"].ToString())
                    {
                        if (_password == _reader["password"].ToString())
                        {
                            _dbInstance.conn.Close();
                            _mainWindow = new MainWindow(username);
                            _mainWindow.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username and password do not match", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbxUsername.Clear();
                            tbxPassword.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username and password do not match", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("An account with those credentials could not be found", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxUsername.Clear();
                    tbxPassword.Clear();
                }
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close Hairology?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}