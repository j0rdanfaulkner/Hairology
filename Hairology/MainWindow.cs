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
        public MainWindow(string username, Login log)
        {
            InitializeComponent();
            tmrTimer.Start();
            _username = username;
            _login = log;
            lblWelcome.Text = "Welcome, " + _username;
            lblDate.Text = GetCurrentDate();
            lblTime.Text = GetCurrentTime();
        }
        ~MainWindow()
        {
            _username = null!;
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
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = GetCurrentTime();
        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uscTransactions.Hide();
            uscSettings.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uscTransactions.Hide();
            uscSettings.Hide();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uscTransactions.Hide();
            uscSettings.Hide();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uscTransactions.Show();
            uscSettings.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uscTransactions.Hide();
            uscSettings.Show();
        }
    }
}
