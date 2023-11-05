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
        public Settings()
        {
            InitializeComponent();
            _dbInstance.ConnectToDatabase();
            dividerStripTextBox1.ReadOnly = true;
            dividerStripTextBox2.ReadOnly = true;
            pnlChangePassword.Visible = false;
            tbxCurrentPassword.UseSystemPasswordChar = true;
            tbxNewPassword.UseSystemPasswordChar = true;
            tbxConfirmNewPassword.UseSystemPasswordChar = true;
            pnlChangeColours.Visible = false;
            pnlChangeFonts.Visible = false;
            _selectedMain = pbxMain1.BackColor;
            _selectedAccent = pbxAccent1.BackColor;
            SetFonts();
        }
        public void GetUsername(string username)
        {
            _username = username;
        }
        private void SetFonts()
        {
            // menu bar
            mstMenuBar.Font = FontManagement.menuBar;
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
            // change fonts panel
            //labels
            lblChangeFonts.Font = FontManagement.labels;
            // text input
            cbxSelectLabelFont.Font = FontManagement.textInput;
            tbxLabelFontSize.Font = FontManagement.textInput;
            // buttons
            btnLabelFontOK.Font = FontManagement.buttons;
            // change colours panel
            lblChangeColours.Font = FontManagement.labels;
            lblPreview.Font = FontManagement.labels;
            lblMainColour.Font = FontManagement.labels;
            lblAccentColour.Font = FontManagement.labels;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = true;
            pnlChangeColours.Visible = false;
            pnlChangeFonts.Visible = false;
        }
        private void changeColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = false;
            pnlChangeColours.Visible = true;
            pnlChangeFonts.Visible = false;
        }
        private void changeFontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = false;
            pnlChangeColours.Visible = false;
            pnlChangeFonts.Visible = true;
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
    }
}
