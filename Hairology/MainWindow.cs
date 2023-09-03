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
        public MainWindow(string username)
        {
            InitializeComponent();
            _username = username;
        }
        ~MainWindow()
        {
            _username = null!;
        }
    }
}
