using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hairology
{
    public partial class Settings : UserControl
    {
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        private Encryption _encrypt = default!;
        private string _username = default!;
        private string _currentPassword = default!;
        private string _newPassword = default!;
        private string _confirmNewPassword = default!;
        private Color _selectedMain = default!;
        private Color _selectedAccent = default!;
        private const string _SUPPORTLINK = "https://www.jordan-faulkner.com/support";
        private string _versionNumber = default!;
        public Settings()
        {
            InitializeComponent();
            _versionNumber = GetVersionNumber();
            lblVersionNumber.Text = "Version " + _versionNumber;
            SetFonts();
            _dbInstance.ConnectToDatabase();
            lblSupportLink.LinkVisited = false;
            lblSupportLink.Links.Add(0, 22, _SUPPORTLINK);
            dividerStripTextBox1.ReadOnly = true;
            dividerStripTextBox2.ReadOnly = true;
            pnlAbout.Visible = false;
            pnlChangePassword.Visible = false;
            tbxCurrentPassword.UseSystemPasswordChar = true;
            tbxNewPassword.UseSystemPasswordChar = true;
            tbxConfirmNewPassword.UseSystemPasswordChar = true;
            pnlChangeColours.Visible = false;
            _selectedMain = pbxMain1.BackColor;
            _selectedAccent = pbxAccent1.BackColor;
        }
        /// <summary>
        /// retrieves the current version number of Hairology and returns it as a string value
        /// </summary>
        /// <returns></returns>
        private string GetVersionNumber()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            string number = String.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
            return number;
        }
        public void GetUsername(string username)
        {
            _username = username;
        }
        private void SetFonts()
        {
            // menu bar
            mstMenuBar.Font = FontManagement.menuBar;
            // about panel
            // labels
            lblAbout.Font = FontManagement.labels;
            lblNumberOfEmployees.Font = FontManagement.labels;
            lblNumberOfAdminAccounts.Font = FontManagement.labels;
            lblNumberOfCustomers.Font = FontManagement.labels;
            lblNumberOfProducts.Font = FontManagement.labels;
            lblNumberOfTransactions.Font = FontManagement.labels;
            lblVersionNumber.Font = FontManagement.subtitles;
            lblCopyright.Font = FontManagement.subtitles;
            // support link
            lblSupportLink.Font = FontManagement.subtitles;
            // change password panel
            // labels
            lblChangePassword.Font = FontManagement.labels;
            lblCurrentPassword.Font = FontManagement.labels;
            lblNewPassword.Font = FontManagement.labels;
            lblConfirmNewPassword.Font = FontManagement.labels;
            // text input
            tbxCurrentPassword.Font = FontManagement.textInput;
            tbxNewPassword.Font = FontManagement.textInput;
            tbxConfirmNewPassword.Font = FontManagement.textInput;
            // buttons
            btnChangePassword.Font = FontManagement.buttons;
            // change colours panel
            lblChangeColours.Font = FontManagement.labels;
            lblPreview.Font = FontManagement.labels;
            lblMainColour.Font = FontManagement.labels;
            lblAccentColour.Font = FontManagement.labels;
        }
        private void GetInformation()
        {
            int employeesCount = 0;
            int adminAccountsCount = 0;
            int customersCount = 0;
            int productsCount = 0;
            int transactionsCount = 0;
            _dbInstance.conn.Open();
            _command = new SqlCommand(DatabaseQueries.COUNT_EMPLOYEES, _dbInstance.conn);
            employeesCount = Convert.ToInt32(_command.ExecuteScalar());
            _command = new SqlCommand(DatabaseQueries.COUNT_ADMINS, _dbInstance.conn);
            adminAccountsCount = Convert.ToInt32(_command.ExecuteScalar());
            _command = new SqlCommand(DatabaseQueries.COUNT_CUSTOMERS, _dbInstance.conn);
            customersCount = Convert.ToInt32(_command.ExecuteScalar());
            _command = new SqlCommand(DatabaseQueries.COUNT_PRODUCTS, _dbInstance.conn);
            productsCount = Convert.ToInt32(_command.ExecuteScalar());
            _command = new SqlCommand(DatabaseQueries.COUNT_TRANSACTIONS, _dbInstance.conn);
            transactionsCount = Convert.ToInt32(_command.ExecuteScalar());
            _dbInstance.conn.Close();
            lblNumberOfEmployees.Text = string.Format("Number of Employees: {0}", employeesCount);
            lblNumberOfAdminAccounts.Text = string.Format("Number of Admin Accounts: {0}", adminAccountsCount);
            lblNumberOfCustomers.Text = string.Format("Number of Customers: {0}", customersCount);
            lblNumberOfProducts.Text = string.Format("Number of Products: {0}", productsCount);
            lblNumberOfTransactions.Text = string.Format("Number of Transactions: {0}", transactionsCount);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = true;
            pnlChangePassword.Visible = false;
            pnlChangeColours.Visible = false;
            GetInformation();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            pnlChangePassword.Visible = true;
            pnlChangeColours.Visible = false;
        }
        private void changeColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            pnlChangePassword.Visible = false;
            pnlChangeColours.Visible = true;
        }
        private bool CheckPassword()
        {
            // hash current password in text box
            _encrypt = new Encryption(tbxCurrentPassword.Text);
            _currentPassword = _encrypt.CreateMD5Hash();
            // encrypt new password in text box
            _encrypt = new Encryption(tbxNewPassword.Text);
            _newPassword = _encrypt.CreateMD5Hash();
            // encrypt new password in confirmation text box
            _encrypt = new Encryption(tbxConfirmNewPassword.Text);
            _confirmNewPassword = _encrypt.CreateMD5Hash();
            _dbInstance.conn.Open();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_PASSWORD, _username), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                string current = _reader[0].ToString();
                if (current == _currentPassword)
                {
                    if (_newPassword == _confirmNewPassword)
                    {
                        _reader.Close();
                        _dbInstance.conn.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("New password was not confirmed correctly", "Unconfirmed New Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _reader.Close();
                        _dbInstance.conn.Close();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Current password was not entered correctly", "Incorrect Current Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _reader.Close();
                    _dbInstance.conn.Close();
                    return false;
                }
            }
            _reader.Close();
            _dbInstance.conn.Close();
            return false;
        }
        private void UpdateAccountDetails()
        {
            try
            {
                _dbInstance.conn.Open();
                _command = new SqlCommand(string.Format(DatabaseQueries.UPDATE_PASSWORD, _newPassword, _username), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                MessageBox.Show("Password was changed successfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _reader.Close();
                _dbInstance.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK);
            }
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (CheckPassword() == true)
            {
                UpdateAccountDetails();
                tbxCurrentPassword.Clear();
                tbxNewPassword.Clear();
                tbxConfirmNewPassword.Clear();
                pnlChangePassword.Visible = false;
            }
            else
            {
                MessageBox.Show("Password was not changed", "Password Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveColours_Click(object sender, EventArgs e)
        {
            MainWindow.SetColours(_selectedMain, _selectedAccent);
            MessageBox.Show("New colour theme has been applied", "Colours Changed Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlChangeColours.Visible = false;
        }

        private void pbxMain1_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain1.BackColor;
            UpdatePreview();
        }

        private void pbxMain2_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain2.BackColor;
            UpdatePreview();
        }

        private void pbxMain3_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain3.BackColor;
            UpdatePreview();
        }

        private void pbxMain4_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain4.BackColor;
            UpdatePreview();
        }

        private void pbxMain5_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain5.BackColor;
            UpdatePreview();
        }

        private void pbxMain6_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain6.BackColor;
            UpdatePreview();
        }

        private void pbxMain7_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain7.BackColor;
            UpdatePreview();
        }

        private void pbxMain8_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain8.BackColor;
            UpdatePreview();
        }

        private void pbxMain9_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain9.BackColor;
            UpdatePreview();
        }

        private void pbxMain10_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain10.BackColor;
            UpdatePreview();
        }

        private void pbxMain11_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain11.BackColor;
            UpdatePreview();
        }

        private void pbxMain12_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain12.BackColor;
            UpdatePreview();
        }

        private void pbxMain13_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain13.BackColor;
            UpdatePreview();
        }

        private void pbxMain14_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain14.BackColor;
            UpdatePreview();
        }

        private void pbxMain15_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain15.BackColor;
            UpdatePreview();
        }

        private void pbxMain16_Click(object sender, EventArgs e)
        {
            _selectedMain = pbxMain16.BackColor;
            UpdatePreview();
        }

        private void pbxAccent1_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent1.BackColor;
            UpdatePreview();
        }

        private void pbxAccent2_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent2.BackColor;
            UpdatePreview();
        }

        private void pbxAccent3_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent3.BackColor;
            UpdatePreview();
        }

        private void pbxAccent4_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent4.BackColor;
            UpdatePreview();
        }

        private void pbxAccent5_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent5.BackColor;
            UpdatePreview();
        }

        private void pbxAccent6_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent6.BackColor;
            UpdatePreview();
        }

        private void pbxAccent7_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent7.BackColor;
            UpdatePreview();
        }

        private void pbxAccent8_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent8.BackColor;
            UpdatePreview();
        }

        private void pbxAccent9_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent9.BackColor;
            UpdatePreview();
        }

        private void pbxAccent10_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent10.BackColor;
            UpdatePreview();
        }

        private void pbxAccent11_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent11.BackColor;
            UpdatePreview();
        }

        private void pbxAccent12_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent12.BackColor;
            UpdatePreview();
        }

        private void pbxAccent13_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent13.BackColor;
            UpdatePreview();
        }

        private void pbxAccent14_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent14.BackColor;
            UpdatePreview();
        }

        private void pbxAccent15_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent15.BackColor;
            UpdatePreview();
        }

        private void pbxAccent16_Click(object sender, EventArgs e)
        {
            _selectedAccent = pbxAccent16.BackColor;
            UpdatePreview();
        }
        private void UpdatePreview()
        {
            pnlTop.BackColor = _selectedMain;
            pnlMenuBar.BackColor = _selectedAccent;
            pnlBottom.BackColor = _selectedMain;
        }
        /// <summary>
        /// opens support page using default web browser when link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSupportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblSupportLink.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start(_SUPPORTLINK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
