using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hairology
{
    public partial class MainWindow : Form
    {
        private string _username = default!;
        private Login _login = default!;
        private string _currentDate = default!;
        private string _currentTime = default!;
        private bool _closing = false;
        public MainWindow(string username)
        {
            InitializeComponent();
            _username = username;
            lblWelcome.Text = "Welcome, " + _username;
            lblDate.Text = GetCurrentDate();
            lblTime.Text = GetCurrentTime();
        }
        ~MainWindow()
        {
            _username = null!;
        }
        /// <summary>
        /// ask to confirm log out when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string GetCurrentDate()
        {
            _currentDate = DateTime.Now.ToString("ddd, dd MMM yyyy");
            return _currentDate;
        }
        string GetCurrentTime()
        {
            _currentTime = DateTime.Now.ToString("hh: mm tt");
            return _currentTime;
        }
        private void LogOut(DialogResult result, bool logOutButtonClicked)
        {
            if (result == DialogResult.Yes)
            {
                _login = new Login();
                _login.Show();
                if (logOutButtonClicked == true)
                {
                    _closing = true;
                    this.Close();
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult closing = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            LogOut(closing, true);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_closing == true)
            {
                LogOut(DialogResult.Yes, false);
            }
            else
            {
                DialogResult closing = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                LogOut(closing, false);
            }
        }
    }
}
