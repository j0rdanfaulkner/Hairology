using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hairology
{
    public partial class AddNewPerson : UserControl
    {
        private string _type = default!;
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        private Encryption _encrypt = default!;
        private bool _usernameTaken = default!;
        // variables to hold personal data
        private string _firstName = default!;
        private string _lastName = default!;
        private string _dateOfBirth = default!;
        private char _sex = default!;
        private string _addressLine1 = default!;
        private string _addressLine2 = default!;
        private string _county = default!;
        private string _postCode = default!;
        private bool _regularCustomer = default!;
        // variables for employee information
        private int _employeeNumber = default!;
        private string _department = default!;
        private bool _completedTraining = default!;
        private bool _adminRights = default!;
        // variables for employee user account credentials
        private string _username = default!;
        private string _password = default!;
        public AddNewPerson()
        {
            InitializeComponent();
            tbxPassword.UseSystemPasswordChar = true;
            tbxConfirmPassword.UseSystemPasswordChar = true;
        }
        private void ConfigureForm()
        {
            if (_type == "Customer")
            {
                lblAddNewPerson.Text = "Add New " + _type;
                cbxRegularCustomer.Visible = true;
                cbxRegularCustomer.Enabled = true;
                pnlEmployee.Visible = false;
            }
            else if (_type == "Employee")
            {
                lblAddNewPerson.Text = "Add New " + _type;
                cbxRegularCustomer.Visible = false;
                cbxRegularCustomer.Enabled = false;
                pnlEmployee.Visible = true;
            }

        }
        public void SetPersonType(string person)
        {
            _type = person;
            ConfigureForm();
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
            if (_type == "Employee")
            {
                _employeeNumber = Convert.ToInt32(tbxEmployeeNumber.Text);
                _department = cbxDepartment.Text;
                _username = tbxUsername.Text;
                _password = tbxPassword.Text;
            }
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
                                                if (_type == "Customer")
                                                {
                                                    if (cbxRegularCustomer.Checked == true)
                                                    {
                                                        _regularCustomer = true;
                                                    }
                                                    else if (cbxRegularCustomer.Checked == false)
                                                    {
                                                        _regularCustomer = false;
                                                    }
                                                    GetDataFromFields();
                                                    return true;
                                                }
                                                else if (_type == "Employee")
                                                {
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
                                                            if (rbtnAdminRightsYes.Checked == false && rbtnAdminRightsNo.Checked == false)
                                                            {
                                                                MessageBox.Show("The administrative permissions level was not selected", "Admin Rights Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                                                    if (rbtnAdminRightsYes.Checked == true && rbtnAdminRightsNo.Checked == false)
                                                                    {
                                                                        _adminRights = true;
                                                                    }
                                                                    else if (rbtnAdminRightsYes.Checked == false && rbtnAdminRightsNo.Checked == true)
                                                                    {
                                                                        _adminRights = false;
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
                                                return false;
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool checksPassed = CheckFields();
            // check for missing fields
            if (checksPassed == true)
            {
                if (_type == "Employee")
                {
                    _usernameTaken = IsUsernameTaken();
                    if (_usernameTaken == true)
                    {
                        MessageBox.Show("An account with this username already exists", "Username Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                        tbxConfirmPassword.Clear();
                    }
                    else
                    {
                        // once all validation checks for the employee have passed, call InsertIntoDatabase method
                        InsertIntoDatabase();
                    }
                }
                else
                {
                    // once all validation checks for the customer have passed, call InsertIntoDatabase method
                    InsertIntoDatabase();
                }
            }
            _dbInstance.conn.Close();
        }
        /// <summary>
        /// inserts person into database using their personal attributes as parameters
        /// </summary>
        private void InsertIntoDatabase()
        {
            // generate random 8-digit ID
            int randomID = GenerateRandomID();
            if (_type == "Customer")
            {
                // check that the generated ID is unique and has not already been assigned to a customer
                _dbInstance.ConnectToDatabase();
                _dbInstance.conn.Open();
                _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_CUSTOMER_ID, randomID), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                // if matching ID was found, call the method again to regenerate a new random ID number
                if (_reader.Read())
                {
                    InsertIntoDatabase();
                    _reader.Close();
                }
                // otherwise, insert customer details into [Customers] table of database
                else
                {
                    _reader.Close();
                    _command = new SqlCommand(string.Format(DatabaseQueries.INSERT_INTO_CUSTOMERS, randomID, _firstName, _lastName, _dateOfBirth, _sex, _addressLine1, _addressLine2, _county, _postCode, _regularCustomer), _dbInstance.conn);
                    _reader = _command.ExecuteReader();
                    _reader.Close();
                    // search for newly-inserted customer to verify that they have been added to database successfully
                    _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_CUSTOMER_ID, randomID), _dbInstance.conn);
                    _reader = _command.ExecuteReader();
                    if (_reader.Read())
                    {
                        MessageBox.Show("'" + _firstName + " " + _lastName + "' was inserted into the Customers table successfully", _type + " Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reader.Close();
                    }
                }
                _dbInstance.conn.Close();
            }
            else if (_type == "Employee")
            {
                // check that the generated ID is unique and has not already been assigned to an existing user account
                _dbInstance.ConnectToDatabase();
                _dbInstance.conn.Open();
                _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_USER_ACCOUNT_ID, randomID), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                // if matching ID was found, call the method again to regenerate a new random ID number
                if (_reader.Read())
                {
                    InsertIntoDatabase();
                    _reader.Close();
                }
                // otherwise, insert account details into [User Accounts], employee details into [Employees] and personal information into [Employee Details]
                else
                {
                    _reader.Close();
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
                        MessageBox.Show("'" + _firstName + " " + _lastName + "' was inserted into the Employees table successfully", _type + " Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reader.Close();
                    }
                }
            }
            _dbInstance.conn.Close();
        }
        /// <summary>
        /// generates a randomised 8-digit number and returns its value
        /// </summary>
        /// <returns></returns>
        private int GenerateRandomID()
        {
            int id = default!;
            Random r = new Random();
            id = r.Next(10000000, 99999999);
            return id;
        }
        private void CheckEmployeeNumber()
        {
            int number = default!;
            number = GenerateRandomID();
            _dbInstance.ConnectToDatabase();
            _dbInstance.conn.Open();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_RANDOM_EMPLOYEE_NUMBER, number), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                CheckEmployeeNumber();
            }
            else
            {
                _employeeNumber = number;
                tbxEmployeeNumber.Text = _employeeNumber.ToString();
            }
            _dbInstance.conn.Close();
        }
        private void btnGenerateEmployeeNumber_Click(object sender, EventArgs e)
        {
            // check that the generated employee number is unique and has not already been assigned to an existing employee
            CheckEmployeeNumber();
        }
        private bool IsUsernameTaken()
        {
            if (tbxUsername.Text == "")
            {
                pbxUsernameOK.Visible = false;
                ttpUsernameOK.Hide(tbxUsername);
            }
            else
            {
                pbxUsernameOK.Visible = true;
                string currentUsername = tbxUsername.Text;
                _dbInstance.ConnectToDatabase();
                _dbInstance.conn.Open();
                _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_USERNAME, currentUsername), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    if (_reader[0].ToString() == currentUsername)
                    {
                        pbxUsernameOK.BackgroundImage = Properties.Resources.notok;
                        ttpUsernameOK.ToolTipTitle = "Username Unavailable";
                        ttpUsernameOK.Show("This username is already taken", tbxUsername);
                        _reader.Close();
                        return true;
                    }
                    else
                    {
                        pbxUsernameOK.BackgroundImage = Properties.Resources.ok;
                        ttpUsernameOK.ToolTipTitle = "Username Available";
                        ttpUsernameOK.Show("This username is OK", tbxUsername);
                        _reader.Close();
                        return false;
                    }
                }
                else
                {
                    pbxUsernameOK.BackgroundImage = Properties.Resources.ok;
                    ttpUsernameOK.ToolTipTitle = "Username Available";
                    ttpUsernameOK.Show("This username is OK", tbxUsername);
                    _reader.Close();
                    return false;
                }
            }
            _dbInstance.conn.Close();
            return false;
        }
        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            IsUsernameTaken();
        }
    }
}
