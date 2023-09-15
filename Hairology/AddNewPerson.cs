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
    public partial class AddNewPerson : UserControl
    {
        private string _type = default!;
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        public AddNewPerson()
        {
            InitializeComponent();
            ConfigureForm();
        }
        private void ConfigureForm()
        {
            if (_type == "Customer")
            {
                lblAddNewPerson.Text = "Add New " + _type;
                cbxRegularCustomer.Visible = true;
                cbxRegularCustomer.Enabled = true;
            }
            else if (_type == "Employee")
            {
                lblAddNewPerson.Text = "Add New " + _type;
                cbxRegularCustomer.Visible = false;
                cbxRegularCustomer.Enabled = false;
            }
            for (int i = 99; i > 17; i--)
            {
                cbxAge.Items.Add(i.ToString());
            }
        }
        public void SetPersonType(string person)
        {
            _type = person;
            ConfigureForm();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            char sex = default!;
            bool regularCustomer = default!;
            // check for missing fields
            if (tbxFirstName.Text == "")
            {
                MessageBox.Show("A first name was not entered", "Missing First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tbxLastName.Text == "")
                {
                    MessageBox.Show("A last name was not entered", "Missing Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cbxAge.Text == "Age")
                    {
                        MessageBox.Show("An age was not selected", "Age Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (rbtnMale.Checked == false && rbtnFemale.Checked == false)
                        {
                            MessageBox.Show("A sex was not selected", "Sex Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (tbxAddressLine1.Text == "" && tbxAddressLine2.Text == "")
                            {
                                MessageBox.Show("The address is missing", "Missing Entire Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (tbxAddressLine1.Text == "")
                                {
                                    MessageBox.Show("The address is partially missing", "Missing First Line of Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (tbxAddressLine2.Text == "")
                                    {
                                        MessageBox.Show("The address is partially missing", "Missing Second Line of Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        if (cbxCounty.Text == "County")
                                        {
                                            MessageBox.Show("A county was not selected", "County Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {
                                            if (tbxPostCode.Text == "")
                                            {
                                                MessageBox.Show("A post code was not entered", "Missing Post Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                            else
                                            {
                                                if (cbxRegularCustomer.Checked == true)
                                                {
                                                    regularCustomer = true;
                                                }
                                                else if (cbxRegularCustomer.Checked == false)
                                                {
                                                    regularCustomer = false;
                                                }
                                                if (rbtnMale.Checked == true && rbtnFemale.Checked == false)
                                                {
                                                    sex = 'M';
                                                }
                                                else if (rbtnMale.Checked == false && rbtnFemale.Checked == true)
                                                {
                                                    sex = 'F';
                                                }
                                                // once all validation checks have passed, call InsertIntoDatabase method using submitted data as parameters
                                                InsertIntoDatabase(tbxFirstName.Text, tbxLastName.Text, Convert.ToInt32(cbxAge.Text), sex, tbxAddressLine1.Text, tbxAddressLine2.Text, cbxCounty.Text, tbxPostCode.Text, regularCustomer);
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
        /// <summary>
        /// inserts person into database using their personal attributes as parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="sex"></param>
        /// <param name="addressLine1"></param>
        /// <param name="addressLine2"></param>
        /// <param name="county"></param>
        /// <param name="postCode"></param>
        /// <param name="regularCustomer"></param>
        private void InsertIntoDatabase(string firstName, string lastName, int age, char sex, string addressLine1, string addressLine2, string county, string postCode, bool regularCustomer)
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
                    InsertIntoDatabase(firstName, lastName, age, sex, addressLine1, addressLine2, county, postCode, regularCustomer);
                    _reader.Close();
                }
                // otherwise, insert customer details into [Customers] table of database
                else
                {
                    _reader.Close();
                    _command = new SqlCommand(string.Format(DatabaseQueries.INSERT_INTO_CUSTOMERS, randomID, firstName, lastName, age, sex, addressLine1, addressLine2, county, postCode, regularCustomer), _dbInstance.conn);
                    _reader = _command.ExecuteReader();
                    _reader.Close();
                    // search for newly-inserted customer to verify that they have been added to database successfully
                    _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_CUSTOMER_ID, randomID), _dbInstance.conn);
                    _reader = _command.ExecuteReader();
                    if (_reader.Read())
                    {
                        MessageBox.Show("'" + firstName + " " + lastName + "' was inserted into the Customers table successfully", _type + " Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reader.Close();
                    }
                }
            }
            else if (_type == "Employee")
            {
                MessageBox.Show("'" + firstName + " " + lastName + "' was inserted into the Employees table successfully", _type + " Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
