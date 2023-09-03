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
        private Login _login;
        public MainWindow(string username)
        {
            InitializeComponent();
            _username = username;
            lblWelcome.Text = "Welcome, " + _username;
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
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult closing = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (closing == DialogResult.Yes)
            {
                _login = new Login();
                _login.Show();
            }
        }
    }
}
