using Microsoft.VisualBasic;
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
        private bool _maxLengthReached = default!;
        private List<string> _customerList = new List<string>();
        public AddNewTransaction()
        {
            InitializeComponent();
            GetCustomers();
            Refresh();
        }
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
                _customerName = string.Format("{0}, {1}", _reader[1], _reader[0]);
                _customerList.Add(_customerName);
            }
            _reader.Close();
            var sorted = _customerList.OrderBy(c => c).ToArray();
            cbxSelectCustomer.Items.AddRange(sorted);
            sorted = null;
            _dbInstance.conn.Close();
        }
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
            string amount = tbxAmountCharged.Text;
            int position = default!;
            if (amount.Length <= 8)
            {
                if (amount.Length == 6)
                {
                    position = 0;
                    amount = amount.Insert(position, "£");
                    position = 5;
                    amount = amount.Insert(position, ".");
                    tbxAmountCharged.Text = amount;
                    _maxLengthReached = true;
                }
                else if (_maxLengthReached == true && amount.Length > 6)
                {
                    tbxAmountCharged.Clear();
                    _maxLengthReached = false;
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }

        private void cbxSelectCustomer_Click(object sender, EventArgs e)
        {
            _customerList.Clear();
            cbxSelectCustomer.Items.Clear();
            GetCustomers();
            this.Refresh();
        }
    }
}
