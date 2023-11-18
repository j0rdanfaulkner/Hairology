using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hairology
{
    public partial class Setup : Form
    {
        // database management variables
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        private Encryption _encrypt = default!;
        // variables to hold personal data
        private string _firstName = default!;
        private string _lastName = default!;
        private string _dateOfBirth = default!;
        private char _sex = default!;
        private string _addressLine1 = default!;
        private string _addressLine2 = default!;
        private string _county = default!;
        private string _postCode = default!;
        // variables for employee information
        private int _employeeNumber = default!;
        private string _department = default!;
        private bool _completedTraining = default!;
        private bool _adminRights = default!;
        // variables for employee user account credentials
        private string _username = default!;
        private string _password = default!;
        private bool _goToLogin = default!;
        public Setup()
        {
            InitializeComponent();
            SetFonts();
            tbxPassword.UseSystemPasswordChar = true;
            tbxConfirmPassword.UseSystemPasswordChar = true;
            _goToLogin = false;
            _dbInstance.ConnectToDatabase();
        }
        private void SetFonts()
        {
            // labels
            lblWelcome.Font = FontManagement.titles;
            lblSubtitle.Font = FontManagement.departmentSubtitle;
            lblCompletedTraining.Font = FontManagement.labels;
            lblDOB.Font = FontManagement.labels;
            lblSex.Font = FontManagement.labels;
            rbtnFemale.Font = FontManagement.labels;
            rbtnMale.Font = FontManagement.labels;
            rbtnTrainingCompletedNo.Font = FontManagement.labels;
            rbtnTrainingCompletedYes.Font = FontManagement.labels;
            // text input
            tbxAddressLine1.Font = FontManagement.textInput;
            tbxAddressLine2.Font = FontManagement.textInput;
            tbxConfirmPassword.Font = FontManagement.textInput;
            tbxEmployeeNumber.Font = FontManagement.textInput;
            tbxFirstName.Font = FontManagement.textInput;
            tbxLastName.Font = FontManagement.textInput;
            tbxPassword.Font = FontManagement.textInput;
            tbxPostCode.Font = FontManagement.textInput;
            tbxUsername.Font = FontManagement.textInput;
            cbxCounty.Font = FontManagement.textInput;
            cbxDepartment.Font = FontManagement.textInput;
            dtpDateOfBirth.Font = FontManagement.textInput;
            // buttons
            btnGenerateEmployeeNumber.Font = FontManagement.buttons;
            btnSubmit.Font = FontManagement.buttons;
        }
        private void GetDataFromFields()
        {
            _firstName = tbxFirstName.Text;
            _lastName = tbxLastName.Text;
            _dateOfBirth = dtpDateOfBirth.Text;
            _addressLine1 = tbxAddressLine1.Text;
            _addressLine2 = tbxAddressLine2.Text;
            _county = cbxCounty.Text;
            _postCode = tbxPostCode.Text;
            _employeeNumber = Convert.ToInt32(tbxEmployeeNumber.Text);
            _department = cbxDepartment.Text;
            _adminRights = true;
            _username = tbxUsername.Text;
            _password = tbxPassword.Text;
        }
        private bool CheckFields()
        {
            if (tbxFirstName.Text == "")
            {
                MessageBox.Show("A first name was not entered", "Missing First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (tbxLastName.Text == "")
                {
                    MessageBox.Show("A last name was not entered", "Missing Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    if (dtpDateOfBirth.Text == DateTime.Now.ToString("dd MMMM yyyy"))
                    {
                        MessageBox.Show("A date of birth was not selected", "Date of Birth Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        if (rbtnMale.Checked == false && rbtnFemale.Checked == false)
                        {
                            MessageBox.Show("A sex was not selected", "Sex Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            if (tbxAddressLine1.Text == "" && tbxAddressLine2.Text == "")
                            {
                                MessageBox.Show("The address is missing", "Missing Entire Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                            else
                            {
                                if (tbxAddressLine1.Text == "")
                                {
                                    MessageBox.Show("The address is partially missing", "Missing First Line of Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }
                                else
                                {
                                    if (tbxAddressLine2.Text == "")
                                    {
                                        MessageBox.Show("The address is partially missing", "Missing Second Line of Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return false;
                                    }
                                    else
                                    {
                                        if (cbxCounty.Text == "County")
                                        {
                                            MessageBox.Show("A county was not selected", "County Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return false;
                                        }
                                        else
                                        {
                                            if (tbxPostCode.Text == "")
                                            {
                                                MessageBox.Show("A post code was not entered", "Missing Post Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return false;
                                            }
                                            else
                                            {
                                                if (rbtnMale.Checked == true && rbtnFemale.Checked == false)
                                                {
                                                    _sex = 'M';
                                                }
                                                else if (rbtnMale.Checked == false && rbtnFemale.Checked == true)
                                                {
                                                    _sex = 'F';
                                                }
                                                if (cbxDepartment.Text == "  DEPARTMENT")
                                                {
                                                    MessageBox.Show("A department was not selected", "Department Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return false;
                                                }
                                                else
                                                {
                                                    if (rbtnTrainingCompletedYes.Checked == false && rbtnTrainingCompletedNo.Checked == false)
                                                    {
                                                        MessageBox.Show("The training status was not selected", "Training Status Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        return false;
                                                    }
                                                    else
                                                    {
                                                        if (tbxEmployeeNumber.Text == "")
                                                        {
                                                            MessageBox.Show("You need to generate a new employee number", "Employee Number Not Generated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            return false;
                                                        }
                                                        else
                                                        {
                                                            if (rbtnTrainingCompletedYes.Checked == true && rbtnTrainingCompletedNo.Checked == false)
                                                            {
                                                                _completedTraining = true;
                                                            }
                                                            else if (rbtnTrainingCompletedYes.Checked == false && rbtnTrainingCompletedNo.Checked == true)
                                                            {
                                                                _completedTraining = false;
                                                            }
                                                            if (tbxUsername.Text == "")
                                                            {
                                                                MessageBox.Show("You need to enter a username in order to create a user account", "Username Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                return false;
                                                            }
                                                            else
                                                            {
                                                                if (tbxPassword.Text == "")
                                                                {
                                                                    MessageBox.Show("You need to enter a password in order to create a user account", "Username Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    return false;
                                                                }
                                                                else
                                                                {
                                                                    if (tbxConfirmPassword.Text == "" || tbxConfirmPassword.Text != tbxPassword.Text)
                                                                    {
                                                                        MessageBox.Show("You need to confirm your password successfully in order to create a user account", "Password not Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                        return false;
                                                                    }
                                                                    else
                                                                    {
                                                                        GetDataFromFields();
                                                                        return true;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void InsertIntoDatabase()
        {
            // generate random 8-digit ID
            int randomID = GenerateRandomNumber();
            _encrypt = new Encryption(_password);
            string encryptedPassword = _encrypt.CreateMD5Hash();
            _command = new SqlCommand(string.Format(DatabaseQueries.INSERT_INTO_ACCOUNTS, randomID, _username, encryptedPassword), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            _reader.Close();
            _command = new SqlCommand(string.Format(DatabaseQueries.INSERT_INTO_EMPLOYEES, randomID, randomID, _employeeNumber, _department, _completedTraining, _adminRights), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            _reader.Close();
            _command = new SqlCommand(string.Format(DatabaseQueries.INSERT_INTO_EMPLOYEE_DETAILS, randomID, _employeeNumber, _firstName, _lastName, _dateOfBirth, _sex, _addressLine1, _addressLine2, _county, _postCode), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            _reader.Close();
            // search for newly-inserted employee to verify that they have been added to database successfully
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_EMPLOYEE_ID, randomID), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                MessageBox.Show("'" + _firstName + " " + _lastName + "' was inserted into the Employees table", "Administator Account Created Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _reader.Close();
                _goToLogin = true;
                SplashScreen.GoToLogin();
                this.Hide();
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _dbInstance.conn.Open();
            // check for missing fields
            if (CheckFields() == true)
            {
                InsertIntoDatabase();
            }
            _dbInstance.conn.Close();
        }
        private void btnGenerateEmployeeNumber_Click(object sender, EventArgs e)
        {
            tbxEmployeeNumber.Text = GenerateRandomNumber().ToString();
        }
        private int GenerateRandomNumber()
        {
            int number = default!;
            Random r = new Random();
            number = r.Next(10000000, 99999999);
            return number;
        }

        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_goToLogin == false)
            {
                SplashScreen.ExitApplication(true);
            }
            else
            {
                _goToLogin = false;
            }
        }
    }
}
