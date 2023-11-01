using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hairology
{
    public partial class AddNewTransaction : UserControl
    {
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        private int _totalCustomers = default!;
        private string _customerName = default!;
        private List<string> _customerList = new List<string>();
        private string _amount = default!;
        // variables for database insertion
        private int _transactionID = default!;
        private int _customerID = default!;
        private int _employeeNumber = default!;
        private string _cardNumber = default!;
        private string _cvv = default!;
        private string _expirationDate = default!;
        private string _amountCharged = default!;
        private bool _transactionCompleted = default!;

        public AddNewTransaction()
        {
            InitializeComponent();
            GetCustomers();
            SetFonts();
            Refresh();
        }
        public void SetEmployeeNumber(int employeeNumber)
        {
            _employeeNumber = employeeNumber;
        }
        private void SetFonts()
        {
            // labels
            lblAddNewTransaction.Font = FontManagement.labels;
            lblCardNumber.Font = FontManagement.labels;
            lblCVV.Font = FontManagement.labels;
            lblExpiryDate.Font = FontManagement.labels;
            lblSelectCustomer.Font = FontManagement.labels;
            lblTotalAmount.Font = FontManagement.labels;
            lblTransactionCompleted.Font = FontManagement.labels;
            rbtnNo.Font = FontManagement.labels;
            rbtnYes.Font = FontManagement.labels;
            // text input
            cbxSelectCustomer.Font = FontManagement.textInput;
            dtpExpiryDate.Font = FontManagement.textInput;
            tbxAmountCharged.Font = FontManagement.textInput;
            tbxCardNumber.Font = FontManagement.textInput;
            tbxCVV.Font = FontManagement.textInput;
            // buttons
            btnSubmit.Font = FontManagement.buttons;
        }
        /// <summary>
        /// populate combo box with existing customers so that the correct customer for the transaction can be selected directly
        /// </summary>
        private void GetCustomers()
        {
            _dbInstance.ConnectToDatabase();
            _dbInstance.conn.Open();
            _command = new SqlCommand(DatabaseQueries.COUNT_CUSTOMERS, _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                _totalCustomers = Convert.ToInt32(_reader[0]);
                _reader.Close();
            }
            _command = new SqlCommand(DatabaseQueries.SELECT_CUSTOMER_NAMES, _dbInstance.conn);
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                _customerName = string.Format("{0}, {1}, {2}", _reader[1], _reader[0], _reader[2]);
                // add each customer to the list
                _customerList.Add(_customerName);
            }
            _reader.Close();
            // sort the list by last names in alphabetical order, then add them to the combo box
            var sorted = _customerList.OrderBy(c => c).ToArray();
            cbxSelectCustomer.Items.AddRange(sorted);
            sorted = null;
            _dbInstance.conn.Close();
        }
        /// <summary>
        /// automatically formats the card number when the length reaches 16
        /// (autonomously adds the hyphens for each set of 4 digits)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxCardNumber_TextChanged(object sender, EventArgs e)
        {
            string number = tbxCardNumber.Text;
            string separator = "-";
            int position = default;
            if (tbxCardNumber.Text.Length == 16)
            {
                position = 4;
                number = number.Insert(position, separator);
                position = 9;
                number = number.Insert(position, separator);
                position = 14;
                number = number.Insert(position, separator);
                tbxCardNumber.Text = number;
            }
        }
        private void tbxAmountCharged_TextChanged(object sender, EventArgs e)
        {
            if (tbxAmountCharged.Text != "")
            {
                _amount = tbxAmountCharged.Text;
            }
        }
        private void tbxAmountCharged_Enter(object sender, EventArgs e)
        {
            if (tbxAmountCharged.Text != "")
            {
                tbxAmountCharged.Clear();
            }
        }
        private void tbxAmountCharged_Leave(object sender, EventArgs e)
        {
            if (tbxAmountCharged.Text != "")
            {
                tbxAmountCharged.Text = string.Format("{0:C}", Double.Parse(_amount));
            }
        }
        private void cbxSelectCustomer_Click(object sender, EventArgs e)
        {
            _customerList.Clear();
            cbxSelectCustomer.Items.Clear();
            GetCustomers();
            this.Refresh();
        }
        /// <summary>
        /// checks to make sure that all fields have been entered before starting to insert the transaction record into the database
        /// </summary>
        private void CheckMissingFields()
        {
            if (cbxSelectCustomer.Text == "  SELECT CUSTOMER")
            {
                MessageBox.Show("You need to select a customer for this transaction", "Customer Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tbxCardNumber.Text == "" || tbxCardNumber.Text.Length != 19)
                {
                    MessageBox.Show("The customer's card number is either missing or incomplete", "Missing Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tbxCVV.Text == "" || tbxCVV.Text.Length != 3)
                    {
                        MessageBox.Show("The customer's CVV is either missing or too short", "Missing CVV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (dtpExpiryDate.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                        {
                            MessageBox.Show("The expiry date of the customer's card was not selected", "Missing Expiration Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (tbxAmountCharged.Text == "")
                            {
                                MessageBox.Show("The amount that the customer was charged for this transaction was not entered", "Missing Amount Charged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (rbtnYes.Checked == false && rbtnNo.Checked == false)
                                {
                                    MessageBox.Show("The option to determine if the transaction has already gone through was not selected", "Transaction Status Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    // call insertion method to begin storing the transaction
                                    InsertIntoDatabase();
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// generates a random 8-digit number to be used as the transaction ID
        /// </summary>
        /// <returns></returns>
        private int GenerateTransactionID()
        {
            int id = default!;
            Random r = new Random();
            id = r.Next(10000000, 99999999);
            return id;
        }
        /// <summary>
        /// checks to make sure that an existing transaction does not already use this randomly generated number for its ID
        /// </summary>
        private void CheckTransactionID()
        {
            int number = default!;
            number = GenerateTransactionID();
            _dbInstance.ConnectToDatabase();
            _dbInstance.conn.Open();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_RANDOM_TRANSACTION_ID, number), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                CheckTransactionID();
            }
            else
            {
                _transactionID = number;
            }
            _reader.Close();
            _dbInstance.conn.Close();
        }
        /// <summary>
        /// gets the customer ID using the post code of the selected customer, then inserts the transaction into the database using the supplied information
        /// </summary>
        private void InsertIntoDatabase()
        {
            string[] selectedCustomer = cbxSelectCustomer.SelectedItem.ToString().Split(", ");
            CheckTransactionID();
            _dbInstance.ConnectToDatabase();
            _dbInstance.conn.Open();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_CUSTOMER_ID_USING_POSTCODE, selectedCustomer[2]), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                _customerID = Convert.ToInt32(_reader[0]);
            }
            _reader.Close();
            _cardNumber = tbxCardNumber.Text;
            _cvv = tbxCVV.Text;
            _expirationDate = dtpExpiryDate.Text;
            _amountCharged = tbxAmountCharged.Text;
            if (rbtnYes.Checked == true && rbtnNo.Checked == false)
            {
                _transactionCompleted = true;
            }
            else if (rbtnYes.Checked == false && rbtnNo.Checked == true)
            {
                _transactionCompleted = false;
            }
            _command = new SqlCommand(string.Format(DatabaseQueries.INSERT_INTO_TRANSACTIONS, _transactionID, _employeeNumber, _customerID, _cardNumber, _cvv, _expirationDate, _amountCharged, _transactionCompleted), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            _reader.Close();
            MessageBox.Show("The transaction for customer '" + selectedCustomer[1] + " " + selectedCustomer[0] + "' was saved successfully", "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _dbInstance.conn.Close();
        }
        /// <summary>
        /// calls the CheckMissingFields method before starting to submit the information for database insertion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckMissingFields();
        }
    }
}
