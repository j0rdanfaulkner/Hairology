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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hairology
{
    public partial class SplashScreen : Form
    {
        private Random _r = new Random();
        private int _waiting = default!;
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        private bool _usersFound = default!;
        private static Login _login = new Login();
        private static Setup _setup = new Setup();
        public SplashScreen()
        {
            InitializeComponent();
            _waiting = 0;
            lblCurrentProgress.Text = "";
            tmrTimer.Start();
            SelectRandomBackgroundImage();
            SetFonts();
        }
        private void SetFonts()
        {
            // labels
            lblTitle.Font = FontManagement.titles;
            lblSubtitle.Font = FontManagement.subtitles;
            lblCurrentProgress.Font = FontManagement.subtitles;
        }
        private void SelectRandomBackgroundImage()
        {
            int index = _r.Next(1, 7);
            switch (index)
            {
                case 1:
                    pnlBackgroundImage.BackgroundImage = Properties.Resources.splashscreen01;
                    lblTitle.Location = new Point(446, 468);
                    lblSubtitle.Location = new Point(450, 504);
                    break;
                case 2:
                    pnlBackgroundImage.BackgroundImage = Properties.Resources.splashscreen02;
                    lblTitle.Location = new Point(24, 368);
                    lblSubtitle.Location = new Point(28, 404);
                    break;
                case 3:
                    pnlBackgroundImage.BackgroundImage = Properties.Resources.splashscreen03;
                    lblTitle.Location = new Point(451, 656);
                    lblSubtitle.Location = new Point(455, 692);
                    break;
                case 4:
                    pnlBackgroundImage.BackgroundImage = Properties.Resources.splashscreen04;
                    lblTitle.Location = new Point(26, 199);
                    lblSubtitle.Location = new Point(30, 235);
                    break;
                case 5:
                    pnlBackgroundImage.BackgroundImage = Properties.Resources.splashscreen05;
                    lblTitle.Location = new Point(452, 23);
                    lblSubtitle.Location = new Point(456, 59);
                    break;
                case 6:
                    pnlBackgroundImage.BackgroundImage = Properties.Resources.splashscreen06;
                    lblTitle.Location = new Point(35, 136);
                    lblSubtitle.Location = new Point(39, 172);
                    break;
                case 7:
                    pnlBackgroundImage.BackgroundImage = Properties.Resources.splashscreen07;
                    lblTitle.Location = new Point(451, 103);
                    lblSubtitle.Location = new Point(455, 139);
                    break;
            }
        }
        private void CheckForUsers()
        {
            _dbInstance.conn.Open();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_FROM_USER_ACCOUNTS), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                _usersFound = true;
            }
            else
            {
                _usersFound = false;
            }
            _reader.Close();
            _dbInstance.conn.Close();
        }
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            switch (_waiting)
            {
                case 0:
                    lblCurrentProgress.Text = "Starting Application...";
                    pgbProgressBar.Value = 25;
                    _waiting++;
                    break;
                case 1:
                    _waiting++;
                    break;
                case 2:
                    _waiting++;
                    break;
                case 3:
                    _waiting++;
                    break;
                case 4:
                    _waiting++;
                    break;
                case 5:
                    lblCurrentProgress.Text = "Checking for Database...";
                    tmrTimer.Stop();
                    _dbInstance.ConnectToDatabase();
                    tmrTimer.Start();
                    pgbProgressBar.Value = 55;
                    _waiting++;
                    break;
                case 6:
                    _waiting++;
                    break;
                case 7:
                    lblCurrentProgress.Text = "Checking for Users...";
                    tmrTimer.Stop();
                    CheckForUsers();
                    tmrTimer.Start();
                    pgbProgressBar.Value = 65;
                    _waiting++;
                    break;
                case 8:
                    if (_usersFound == true)
                    {
                        lblCurrentProgress.Text = "Loading Login Screen...";
                    }
                    else
                    {
                        lblCurrentProgress.Text = "Loading First-Time Screen...";
                    }
                    pgbProgressBar.Value = 85;
                    _waiting++;
                    break;
                case 9:
                    _waiting++;
                    break;
                case 10:
                    pgbProgressBar.Value = 100;
                    _waiting++;
                    break;
                case 11:
                    tmrTimer.Stop();
                    this.Hide();
                    if (_usersFound == true)
                    {
                        _login.ShowDialog();
                    }
                    else
                    {
                        _setup.ShowDialog();
                    }
                    _waiting++;
                    break;
            }
        }
        public static void GoToLogin()
        {
            _setup.Hide();
            _login.ShowDialog();
        }
        public static void ExitApplication(bool shouldExit)
        {
            if (shouldExit == true)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close Hairology?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
