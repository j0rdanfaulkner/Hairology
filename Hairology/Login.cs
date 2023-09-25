using System.Data.SqlClient;

namespace Hairology
{
    public partial class Login : Form
    {
        public string username = default!;
        private string _password = default!;
        private bool _togglePassword = default!;
        private MainWindow _mainWindow = default!;
        private Encryption _encrypt = default!;
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        private Employee _employee = default!;
        public Login()
        {
            InitializeComponent();
            _dbInstance.ConnectToDatabase();
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
                _dbInstance.conn.Open();
                _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_ACCOUNT_USING_USERNAME, username), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    if (username == _reader["username"].ToString())
                    {
                        if (_password == _reader["password"].ToString())
                        {
                            int accountID = Convert.ToInt32(_reader[0]);
                            _reader.Close();
                            GetEmployee(accountID);
                            _dbInstance.conn.Close();
                            _mainWindow = new MainWindow(_employee, this);
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
                    _reader.Close();
                }
                else
                {
                    MessageBox.Show("An account with those credentials could not be found", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxUsername.Clear();
                    tbxPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("You have not entered your username and/or password", "Missing Login Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            _dbInstance.conn.Close();
        }
        /// <summary>
        /// constructs employee object if details can be found using account id of supplied credentials to find matching employee number
        /// </summary>
        /// <param name="id"></param>
        private void GetEmployee(int id)
        {
            string employeeNumber = default!;
            object[] personalDetails = new object[8];
            object[] workDetails = new object[4];
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_EMPLOYEE_NUMBER, id), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                employeeNumber = _reader[0].ToString();
            }
            _reader.Close();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_EMPLOYEE_PERSONAL_DETAILS, employeeNumber), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                _reader.GetValues(personalDetails);
            }
            _reader.Close();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_EMPLOYEE_WORK_DETAILS, employeeNumber), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                _reader.GetValues(workDetails);
                _reader.Close();
                _employee = new Employee(personalDetails, workDetails);
            }
            else
            {
                MessageBox.Show("Employee could not be found", "Could Not Find Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close Hairology?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}