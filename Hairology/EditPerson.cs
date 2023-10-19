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
    public partial class EditPerson : UserControl
    {
        private string _type = default!;
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        private Customer _editingCustomer = default!;
        private Employee _editingEmployee = default!;
        private bool _changesMade = default!;
        // variables for changed personal details
        private int _customerID = default!;
        private string _firstName = default!;
        private string _lastName = default!;
        private string _dateOfBirth = default!;
        private char _sex = default!;
        private string _addressLine1 = default!;
        private string _addressLine2 = default!;
        private string _county = default!;
        private string _postCode = default!;
        private bool _regularCustomer = default!;
        // variables for changed work details
        private int _employeeID = default!;
        private string _employeeNumber = default!;
        private string _department = default!;
        private bool _completedTraining = default!;
        private bool _adminRights = default!;
        public EditPerson()
        {
            InitializeComponent();
            _dbInstance.ConnectToDatabase();
            tbxPassword.UseSystemPasswordChar = true;
            tbxConfirmPassword.UseSystemPasswordChar = true;
        }
        private void ConfigureForm()
        {
            if (_type == "Customer")
            {
                lbllEditPerson.Text = "Edit " + _type;
                cbxRegularCustomer.Visible = true;
                cbxRegularCustomer.Enabled = true;
                pnlEmployee.Visible = false;
            }
            else if (_type == "Employee")
            {
                lbllEditPerson.Text = "Edit " + _type;
                cbxRegularCustomer.Visible = false;
                cbxRegularCustomer.Enabled = false;
                pnlEmployee.Visible = true;
            }
        }
        /// <summary>
        /// ensures the editing form is configured to either editing a customer or an employee
        /// </summary>
        /// <param name="person"></param>
        /// <param name="customer"></param>
        /// <param name="employee"></param>
        public void SetPersonType(string person, Customer customer, Employee employee)
        {
            _type = person;
            ConfigureForm();
            _editingCustomer = customer;
            _editingEmployee = employee;
            SetDetails();
        }
        /// <summary>
        /// get attributes of customer/employee to be added, then set these values as the values for each field
        /// </summary>
        public void SetDetails()
        {
            if (_type == "Customer")
            {
                tbxFirstName.Text = _editingCustomer.GetAttribute(0).ToString();
                tbxLastName.Text = _editingCustomer.GetAttribute(1).ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(_editingCustomer.GetAttribute(2));
                if (Char.Parse(_editingCustomer.GetAttribute(3).ToString()) == 'M')
                {
                    rbtnMale.Checked = true;
                    rbtnFemale.Checked = false;
                }
                else if (Char.Parse(_editingCustomer.GetAttribute(3).ToString()) == 'F')
                {
                    rbtnMale.Checked = false;
                    rbtnFemale.Checked = true;
                }
                tbxAddressLine1.Text = _editingCustomer.GetAttribute(4).ToString();
                tbxAddressLine2.Text = _editingCustomer.GetAttribute(5).ToString();
                cbxCounty.Text = _editingCustomer.GetAttribute(6).ToString();
                tbxPostCode.Text = _editingCustomer.GetAttribute(7).ToString();
                if (Convert.ToBoolean(_editingCustomer.GetAttribute(8).ToString()) == true)
                {
                    cbxRegularCustomer.Checked = true;
                }
                else if (Convert.ToBoolean(_editingCustomer.GetAttribute(8).ToString()) == false)
                {
                    cbxRegularCustomer.Checked = false;
                }
            }
            else if (_type == "Employee")
            {
                tbxFirstName.Text = _editingEmployee.GetAttribute(0).ToString();
                tbxLastName.Text = _editingEmployee.GetAttribute(1).ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(_editingEmployee.GetAttribute(2));
                if (Char.Parse(_editingEmployee.GetAttribute(3).ToString()) == 'M')
                {
                    rbtnMale.Checked = true;
                    rbtnFemale.Checked = false;
                }
                else if (Char.Parse(_editingEmployee.GetAttribute(3).ToString()) == 'F')
                {
                    rbtnMale.Checked = false;
                    rbtnFemale.Checked = true;
                }
                tbxAddressLine1.Text = _editingEmployee.GetAttribute(4).ToString();
                tbxAddressLine2.Text = _editingEmployee.GetAttribute(5).ToString();
                cbxCounty.Text = _editingEmployee.GetAttribute(6).ToString();
                tbxPostCode.Text = _editingEmployee.GetAttribute(7).ToString();
                tbxEmployeeNumber.Text = _editingEmployee.GetAttribute(8).ToString();
                btnGenerateEmployeeNumber.Enabled = false;
                cbxDepartment.Text = _editingEmployee.GetAttribute(9).ToString();
                if (bool.Parse(_editingEmployee.GetAttribute(10).ToString()) == true)
                {
                    rbtnTrainingCompletedYes.Checked = true;
                    rbtnTrainingCompletedNo.Checked = false;
                }
                else if (bool.Parse(_editingEmployee.GetAttribute(10).ToString()) == false)
                {
                    rbtnTrainingCompletedYes.Checked = false;
                    rbtnTrainingCompletedNo.Checked = true;
                }
                if (bool.Parse(_editingEmployee.GetAttribute(11).ToString()) == true)
                {
                    rbtnAdminRightsYes.Checked = true;
                    rbtnAdminRightsNo.Checked = false;
                }
                else if (bool.Parse(_editingEmployee.GetAttribute(11).ToString()) == false)
                {
                    rbtnAdminRightsYes.Checked = false;
                    rbtnAdminRightsNo.Checked = true;
                }
            }
        }
        /// <summary>
        /// checks to see if any changes have been made to the customer's/employee's details
        /// </summary>
        private void CheckForChanges()
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
                if (tbxFirstName.Text != _editingCustomer.GetAttribute(0).ToString())
                {
                    _changesMade = true;
                }
                else if (tbxLastName.Text != _editingCustomer.GetAttribute(1).ToString())
                {
                    _changesMade = true;
                }
                else if (dtpDateOfBirth.Value != Convert.ToDateTime(_editingCustomer.GetAttribute(2)))
                {
                    _changesMade = true;
                }
                else if (_sex != Char.Parse(_editingCustomer.GetAttribute(3).ToString()))
                {
                    _changesMade = true;
                }
                else if (tbxAddressLine1.Text != _editingCustomer.GetAttribute(4).ToString())
                {
                    _changesMade = true;
                }
                else if (tbxAddressLine2.Text != _editingCustomer.GetAttribute(5).ToString())
                {
                    _changesMade = true;
                }
                else if (cbxCounty.Text != _editingCustomer.GetAttribute(6).ToString())
                {
                    _changesMade = true;
                }
                else if (tbxPostCode.Text != _editingCustomer.GetAttribute(7).ToString())
                {
                    _changesMade = true;
                }
                else if (cbxRegularCustomer.Checked != Convert.ToBoolean(_editingCustomer.GetAttribute(8).ToString()))
                {
                    _changesMade = true;
                }
                else
                {
                    _changesMade = false;
                }
            }
            else if (_type == "Employee")
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
                else if (rbtnAdminRightsYes.Checked == false && !rbtnAdminRightsNo.Checked == true)
                {
                    _adminRights = false;
                }
                if (tbxFirstName.Text != _editingEmployee.GetAttribute(0).ToString())
                {
                    _changesMade = true;
                }
                else if (tbxLastName.Text != _editingEmployee.GetAttribute(1).ToString())
                {
                    _changesMade = true;
                }
                else if (dtpDateOfBirth.Value != Convert.ToDateTime(_editingEmployee.GetAttribute(2)))
                {
                    _changesMade = true;
                }
                else if (_sex != Char.Parse(_editingEmployee.GetAttribute(3).ToString()))
                {
                    _changesMade = true;
                }
                else if (tbxAddressLine1.Text != _editingEmployee.GetAttribute(4).ToString())
                {
                    _changesMade = true;
                }
                else if (tbxAddressLine2.Text != _editingEmployee.GetAttribute(5).ToString())
                {
                    _changesMade = true;
                }
                else if (cbxCounty.Text != _editingEmployee.GetAttribute(6).ToString())
                {
                    _changesMade = true;
                }
                else if (tbxPostCode.Text != _editingEmployee.GetAttribute(7).ToString())
                {
                    _changesMade = true;
                }
                else if (cbxDepartment.Text != _editingEmployee.GetAttribute(9).ToString())
                {
                    _changesMade = true;
                }
                else if (_completedTraining != bool.Parse(_editingEmployee.GetAttribute(10).ToString()))
                {
                    _changesMade = true;
                }
                else if (_adminRights != bool.Parse(_editingEmployee.GetAttribute(11).ToString()))
                {
                    _changesMade = true;
                }
                else
                {
                    _changesMade = false;
                }
            }
        }
        /// <summary>
        /// either updates the database record or deletes it entirely based on the provided action
        /// </summary>
        /// <param name="action"></param>
        private void PerformDatabaseAction(string action)
        {
            if (_type == "Customer")
            {
                // retrieve ID so that a specific (matching) record is ammended as opposed to every record within the table
                _dbInstance.conn.Open();
                _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_CUSTOMER_ID_USING_POSTCODE, _editingCustomer.GetAttribute(7)), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    _customerID = Convert.ToInt32(_reader[0]);
                    _reader.Close();
                    if (action == "Update")
                    {
                        // collect each attribute using the values of each field of the form
                        _firstName = tbxFirstName.Text;
                        _lastName = tbxLastName.Text;
                        _dateOfBirth = dtpDateOfBirth.Value.ToString();
                        _addressLine1 = tbxAddressLine1.Text;
                        _addressLine2 = tbxAddressLine2.Text;
                        _county = cbxCounty.Text;
                        _postCode = tbxPostCode.Text;
                        _regularCustomer = cbxRegularCustomer.Checked;
                        // update record that matches the ID
                        _command = new SqlCommand(string.Format(DatabaseQueries.UPDATE_CUSTOMER_DETAILS, _firstName, _lastName, _dateOfBirth, _sex, _addressLine1, _addressLine2, _county, _postCode, _regularCustomer, _customerID), _dbInstance.conn);
                        _reader = _command.ExecuteReader();
                        // show confirmation of amended details to user
                        MessageBox.Show("The changes to customer '" + _editingCustomer.GetFullName() + "' were updated successfully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reader.Close();
                    }
                    else if (action == "Delete")
                    {
                        // delete record that matches the ID
                        _command = new SqlCommand(string.Format(DatabaseQueries.DELETE_CUSTOMER, _customerID), _dbInstance.conn);
                        _reader = _command.ExecuteReader();
                        _reader.Close();
                        // show confirmation of deletion to user
                        MessageBox.Show("The customer '" + _editingCustomer.GetFullName() + "' was deleted from the database", "Customer Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult result = MessageBox.Show("Should this customer's transaction history also be deleted?", "Delete Transaction History?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            _command = new SqlCommand(string.Format(DatabaseQueries.DELETE_TRANSACTION_HISTORY, _customerID), _dbInstance.conn);
                            _reader = _command.ExecuteReader();
                            // show confirmation of deletion to user
                            MessageBox.Show("The customer's transaction history was also deleted from the database", "Transaction History Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Each transaction this customer made can be manually deleted at any time", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                _dbInstance.conn.Close();
            }
            else if (_type == "Employee")
            {
                // retrieve unique employee number so that a specific (matching) record is ammended as opposed to every record within the table
                _dbInstance.conn.Open();
                _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_EMPLOYEE_ID_USING_EMPLOYEE_NUMBER, _editingEmployee.GetAttribute(8)), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    _employeeID = Convert.ToInt32(_reader[0]);
                    _reader.Close();
                    if (action == "Update")
                    {
                        // collect each attribute using the values of each field of the form
                        _firstName = tbxFirstName.Text;
                        _lastName = tbxLastName.Text;
                        _dateOfBirth = dtpDateOfBirth.Value.ToString();
                        _addressLine1 = tbxAddressLine1.Text;
                        _addressLine2 = tbxAddressLine2.Text;
                        _county = cbxCounty.Text;
                        _postCode = tbxPostCode.Text;
                        _employeeNumber = tbxEmployeeNumber.Text;
                        _department = cbxDepartment.Text;
                        // update record that matches the employee number
                        _command = new SqlCommand(string.Format(DatabaseQueries.UPDATE_EMPLOYEE_DETAILS, _firstName, _lastName, _dateOfBirth, _sex, _addressLine1, _addressLine2, _county, _postCode, _employeeNumber), _dbInstance.conn);
                        _reader = _command.ExecuteReader();
                        _reader.Close();
                        _command = new SqlCommand(string.Format(DatabaseQueries.UPDATE_EMPLOYEE_WORK_DETAILS, _department, _completedTraining, _adminRights, _employeeNumber), _dbInstance.conn);
                        _reader = _command.ExecuteReader();
                        // show confirmation of amended details to user
                        MessageBox.Show("The changes to employee '" + _editingEmployee.GetFullName() + "' were updated successfully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reader.Close();
                    }
                    else if (action == "Delete")
                    {
                        // delete records from multiple tables that match the employee number
                        _command = new SqlCommand(string.Format(DatabaseQueries.DELETE_EMPLOYEE_DETAILS, _editingEmployee.GetAttribute(8)), _dbInstance.conn);
                        _reader = _command.ExecuteReader();
                        _reader.Close();
                        _command = new SqlCommand(string.Format(DatabaseQueries.DELETE_EMPLOYEE, _employeeID), _dbInstance.conn);
                        _reader = _command.ExecuteReader();
                        _reader.Close();
                        _command = new SqlCommand(string.Format(DatabaseQueries.DELETE_ACCOUNT, _employeeID), _dbInstance.conn);
                        _reader = _command.ExecuteReader();
                        // show confirmation of deletion to user
                        MessageBox.Show("The employee '" + _editingEmployee.GetFullName() + "' was deleted from the database, as well as their user account", "Employee Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reader.Close();
                    }
                }
                _dbInstance.conn.Close();
            }
        }
        /// <summary>
        /// checks if any changes have been made, then proceeds with updating the database record if so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckForChanges();
            if (_changesMade == false && _type == "Customer")
            {
                DialogResult result = MessageBox.Show("No changes to '" + _editingCustomer.GetFullName() + "' were made, are you sure you wish to continue?", "No Changes Made", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    PerformDatabaseAction("Update");
                }
                else
                {
                    MainWindow.editing = true;
                    MainWindow.personType = _type;
                }
            }
            else if (_changesMade == false && _type == "Employee")
            {
                DialogResult result = MessageBox.Show("No changes to '" + _editingEmployee.GetFullName() + "' were made, are you sure you wish to continue?", "No Changes Made", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    PerformDatabaseAction("Update");
                }
                else
                {
                    MainWindow.editing = true;
                    MainWindow.personType = _type;
                }
            }
            else
            {
                PerformDatabaseAction("Update");
            }
        }
        /// <summary>
        /// checks if any changes have been made; if so, the user is prompted they have unsaved changes before they need to confirm their intention to discard them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            CheckForChanges();
            if (_type == "Customer")
            {
                if (_changesMade == true)
                {
                    DialogResult result = MessageBox.Show("Unsaved changes have been made to '" + _editingCustomer.GetFullName() + "', are you sure you wish to continue?", "Unsaved Changes Made", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainWindow.editing = false;
                        this.Hide();
                    }
                    else
                    {
                        MainWindow.editing = true;
                    }
                }
                else
                {
                    MainWindow.editing = false;
                    this.Hide();
                }
            }
            else if (_type == "Employee")
            {
                if (_changesMade == true)
                {
                    DialogResult result = MessageBox.Show("Unsaved changes have been made to '" + _editingEmployee.GetFullName() + "', are you sure you wish to continue?", "Unsaved Changes Made", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainWindow.editing = false;
                        this.Hide();
                    }
                    else
                    {
                        MainWindow.editing = true;
                    }
                }
                else
                {
                    MainWindow.editing = false;
                    this.Hide();
                }
            }
        }
        /// <summary>
        /// asks the user if they still wish to delete the customer/employee from the database, then proceeds based on their confirmation choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_type == "Customer")
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to delete '" + _editingCustomer.GetFullName() + "'?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    PerformDatabaseAction("Delete");
                }
                else
                {
                    MainWindow.editing = true;
                }
            }
            else if (_type == "Employee")
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to delete '" + _editingEmployee.GetFullName() + "'?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    PerformDatabaseAction("Delete");
                }
                else
                {
                    MainWindow.editing = true;
                }
            }
        }
    }
}
