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
    public partial class Inventory : UserControl
    {
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataAdapter _adapter = default!;
        private DataTable _dt = default!;
        public Inventory()
        {
            InitializeComponent();
            _dbInstance.ConnectToDatabase();
            GetInventoryData();
            this.Refresh();
        }
        private void GetInventoryData()
        {
            try
            {
                _dbInstance.conn.Open();
                _command = new SqlCommand(DatabaseQueries.SELECT_ALL_INVENTORY_RECORDS, _dbInstance.conn);
                _adapter = new SqlDataAdapter(_command);
                _dt = new DataTable();
                _adapter.Fill(_dt);
                dgvInventory.DataSource = _dt.DefaultView;
                dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                dgvInventory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvInventory.EnableHeadersVisualStyles = false;
                for (int i = 0; i < _dt.Columns.Count; i++)
                {
                    var column = dgvInventory.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.DefaultCellStyle.BackColor = Color.Silver;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    switch (i)
                    {
                        case 0:
                            column.HeaderText = "PRODUCT NAME";
                            break;
                        case 1:
                            column.HeaderText = "CATEGORY";
                            break;
                        case 2:
                            column.HeaderText = "EAN NUMBER";
                            break;
                        case 3:
                            column.HeaderText = "CASE SIZE";
                            break;
                        case 4:
                            column.HeaderText = "CURRENT QUANTITY";
                            break;
                        case 5:
                            column.HeaderText = "REORDER REGULARLY?";
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
                    GetInventoryData();
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Hide();
                }
            }
        }
    }
}
