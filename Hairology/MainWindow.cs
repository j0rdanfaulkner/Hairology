﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hairology
{
    public partial class MainWindow : Form
    {
        public Employee _employee;
        private string _username = default!;
        private Login _login = default!;
        private string _currentDate = default!;
        private string _currentTime = default!;
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        private bool _allowedToEdit = default!;
        public static bool editing = false;
        public static string type = default!;
        private static Color _mainColour = SystemColors.ActiveCaption;
        private static Color _accentColour = Color.SteelBlue;
        public MainWindow(Employee employee, Login log)
        {
            InitializeComponent();
            SetColours(_mainColour, _accentColour);
            SetFonts();
            _employee = employee;
            _login = log;
            tmrTimer.Start();
            GetUsername(Convert.ToInt32(_employee.GetAttribute(8)));
            GetAdminRights(bool.Parse(_employee.GetAttribute(11).ToString()));
            lblFullName.Text = "(" + _employee.GetFullName() + ")";
            lblWelcome.Text = string.Format("Welcome, {0}", _username);
            lblWelcome.Text = "Welcome, " + _username;
            lblDepartment.Text = employee.GetAttribute(9).ToString();
            lblDate.Text = GetCurrentDate();
            lblTime.Text = GetCurrentTime();
            uscAddNewPerson.Hide();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.Hide();
            uscSearch.Hide();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.Hide();
            uscEditPerson.Hide();
            uscEditProduct.Hide();
        }
        // destructor
        ~MainWindow()
        {
            _username = null!;
        }
        public static void SetColours(Color main, Color accent)
        {
            _mainColour = main;
            _accentColour = accent;
        }
        public void SetFonts()
        {
            // titles and subtitles
            lblWelcome.Font = FontManagement.titles;
            lblFullName.Font = FontManagement.subtitles;
            lblDepartment.Font = FontManagement.departmentSubtitle;
            lblDate.Font = FontManagement.dateTimeSubtitles;
            lblTime.Font = FontManagement.dateTimeSubtitles;
            // menu bar
            mstNavigationBar.Font = FontManagement.menuBar;
        }
        /// <summary>
        /// gets username using account ID of current employee's user account
        /// </summary>
        /// <param name="number"></param>
        public void GetUsername(int number)
        {
            int accountID = default!;
            _dbInstance.ConnectToDatabase();
            _dbInstance.conn.Open();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_ACCOUNT_ID, number), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                accountID = Convert.ToInt32(_reader[0]);
            }
            _reader.Close();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_ACCOUNT_USING_ID, accountID), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                _username = _reader[1].ToString();
            }
            _reader.Close();
            _dbInstance.conn.Close();
        }
        /// <summary>
        /// limits the abilities of the application so that only admin users can have full access
        /// </summary>
        /// <param name="privileges"></param>
        public void GetAdminRights(bool privileges)
        {
            if (privileges == true)
            {
                pbxAdminRights.BackgroundImage = Properties.Resources.admin;
                ttpInfo.SetToolTip(pbxAdminRights, "This account has administrative privileges");
                uscTransactions.Enabled = true;
                uscTransactions.Visible = true;
                newPersonToolStripMenuItem.Visible = true;
                newProductToolStripMenuItem.Visible = true;
                toolStripSeparator3.Visible = true;
                toolStripSeparator4.Visible = true;
                _allowedToEdit = true;
            }
            else
            {
                pbxAdminRights.BackgroundImage = Properties.Resources.notadmin;
                ttpInfo.SetToolTip(pbxAdminRights, "This account does not have administrative privileges");
                uscTransactions.Enabled = false;
                uscTransactions.Visible = false;
                newPersonToolStripMenuItem.Visible = false;
                newProductToolStripMenuItem.Visible = false;
                toolStripSeparator3.Visible = false;
                toolStripSeparator4.Visible = false;
                _allowedToEdit = false;
            }
        }
        /// <summary>
        /// gets the current date and formats it in a long form
        /// </summary>
        /// <returns></returns>
        string GetCurrentDate()
        {
            _currentDate = DateTime.Now.ToString("ddd, dd MMM. yyyy");
            return _currentDate;
        }
        /// <summary>
        /// gets the current time in HOURS:MINUTES:SECONDS format
        /// </summary>
        /// <returns></returns>
        string GetCurrentTime()
        {
            _currentTime = DateTime.Now.ToString("HH:mm:ss");
            return _currentTime;
        }
        /// <summary>
        /// calls event that occurs when form is to be closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// event raised when form is to be closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closing = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (closing == DialogResult.Yes)
            {
                _login.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// updates the label showing the current time every second
        /// checks to see if the user is currently editing a customer's or employee's details
        /// also checks to ensure that accounts with admin rights can only edit such details, and displays warning message if non-admin users are trying to edit such records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = GetCurrentTime();
            if (editing == true)
            {
                if (_allowedToEdit == true)
                {
                    switch (type)
                    {
                        case "Customer":
                            if (uscEditPerson.Visible == false)
                            {
                                uscEditPerson.SetPersonType(type, uscSearch.customerForEditing, null);
                                uscEditPerson.Show();
                            }
                            break;
                        case "Employee":
                            if (uscEditPerson.Visible == false)
                            {
                                uscEditPerson.SetPersonType(type, null, uscSearch.employeeForEditing);
                                uscEditPerson.Show();
                            }
                            break;
                        case "Product":
                            if (uscEditProduct.Visible == false)
                            {
                                uscEditProduct.SetProductForEditing(uscSearch.productForEditing);
                                uscEditProduct.Show();
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    editing = false;
                    MessageBox.Show("You need to be an administrator to edit database records", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (type == "Customer")
                    {
                        uscSearch.SetSearchType("Customer");
                    }
                    else if (type == "Employee")
                    {
                        uscSearch.SetSearchType("Employee");
                    }
                    else if (type == "Product")
                    {
                        uscSearch.SetSearchType("Product");
                    }
                    uscSearch.Show();
                }
            }
            else
            {
                uscEditPerson.Hide();
                uscEditProduct.Hide();
                pnlTop.BackColor = _mainColour;
                pnlBottom.BackColor = _mainColour;
                mstNavigationBar.BackColor = _accentColour;
            }
            SetFonts();
        }
        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.SetPersonType("Employee");
            uscAddNewPerson.Show();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.Hide();
            uscSearch.Hide();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.Hide();
            this.Refresh();
        }
        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.SetPersonType("Customer");
            uscAddNewPerson.Show();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.Hide();
            uscSearch.Hide();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.Hide();
            this.Refresh();
        }
        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.Hide();
            uscAddNewProduct.Show();
            uscAddNewTransaction.Hide();
            uscSearch.Hide();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.Hide();
            this.Refresh();
        }
        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.Hide();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.SetEmployeeNumber(Convert.ToInt32(_employee.GetAttribute(8)));
            uscAddNewTransaction.Show();
            uscSearch.Hide();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.Hide();
            this.Refresh();
        }
        private void searchEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.Hide();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.Hide();
            uscSearch.SetSearchType("Employee");
            uscSearch.Show();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.Hide();
            this.Refresh();
        }

        private void searchCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.Hide();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.Hide();
            uscSearch.SetSearchType("Customer");
            uscSearch.Show();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.Hide();
            this.Refresh();
        }
        private void searchTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.Hide();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.Hide();
            uscSearch.SetSearchType("Transaction");
            uscSearch.Show();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.Hide();
            this.Refresh();
        }
        private void searchProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.Hide();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.Hide();
            uscSearch.SetSearchType("Product");
            uscSearch.Show();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.Hide();
            this.Refresh();
        }
        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.Hide();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.Hide();
            uscSearch.Hide();
            uscInventory.Show();
            uscTransactions.Hide();
            uscSettings.Hide();
            this.Refresh();
            uscInventory.dgvInventory.Refresh();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uscTransactions.Enabled == false)
            {
                MessageBox.Show("You need to be an administrator to view this information", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                editing = false;
                uscAddNewPerson.Hide();
                uscAddNewProduct.Hide();
                uscAddNewTransaction.Hide();
                uscSearch.Hide();
                uscInventory.Hide();
                uscTransactions.Show();
                uscSettings.Hide();
                this.Refresh();
                uscTransactions.dgvTransactions.Refresh();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editing = false;
            uscAddNewPerson.Hide();
            uscAddNewProduct.Hide();
            uscAddNewTransaction.Hide();
            uscSearch.Hide();
            uscInventory.Hide();
            uscTransactions.Hide();
            uscSettings.GetUsername(_username);
            uscSettings.Show();
            this.Refresh();
        }

        private void pbxAdminRights_MouseEnter(object sender, EventArgs e)
        {
            if (ttpInfo.Active == false)
            {
                ttpInfo.Active = true;
            }
        }

        private void pbxAdminRights_MouseLeave(object sender, EventArgs e)
        {
            if (ttpInfo.Active == true)
            {
                ttpInfo.Hide(pbxAdminRights);
                ttpInfo.Active = false;
            }
        }
    }
}
