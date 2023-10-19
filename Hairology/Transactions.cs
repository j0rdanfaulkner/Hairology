using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hairology
{
    public partial class Transactions : UserControl
    {
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataAdapter _adapter = default!;
        private DataTable _dt = default!;
        public Transactions()
        {
            InitializeComponent();
            _dbInstance.ConnectToDatabase();
            tmrTimer.Start();
            GetTransactionData();
        }
        /// <summary>
        /// fills DataGridView control with contents of 'Transactions' table within database
        /// </summary>
        private void GetTransactionData()
        {
            try
            {
                _dbInstance.conn.Open();
                _command = new SqlCommand(DatabaseQueries.SELECT_ALL_TRANSACTIONS, _dbInstance.conn);
                _adapter = new SqlDataAdapter(_command);
                _dt = new DataTable();
                _adapter.Fill(_dt);
                dgvTransactions.DataSource = _dt.DefaultView;
                dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                dgvTransactions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTransactions.EnableHeadersVisualStyles = false;
                for (int i = 0; i < _dt.Columns.Count; i++)
                {
                    var column = dgvTransactions.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.DefaultCellStyle.BackColor = Color.Silver;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    switch (i)
                    {
                        case 0:
                            column.HeaderText = "TRANSACTION ID";
                            break;
                        case 1:
                            column.HeaderText = "CARD NUMBER";
                            break;
                        case 2:
                            column.HeaderText = "SECURITY CODE";
                            break;
                        case 3:
                            column.HeaderText = "EXPIRATION DATE";
                            break;
                        case 4:
                            column.HeaderText = "AMOUNT CHARGED";
                            break;
                        case 5:
                            column.HeaderText = "TRANSACTION COMPLETED?";
                            break;
                        default:
                            break;
                    }
                }
                _dbInstance.conn.Close();
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    GetTransactionData();
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Hide();
                }
            }
        }
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            GetTransactionData();
        }
    }
}
