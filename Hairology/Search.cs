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
    public partial class Search : UserControl
    {
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataAdapter _adapter = default!;
        private DataTable _dt = default!;
        private string _type = default!;
        private int _index = default!;
        public Search()
        {
            InitializeComponent();
            _dbInstance.ConnectToDatabase();
            GetData();
            this.Refresh();
        }
        private void GetData()
        {
            if (_type == "Customer")
            {
                try
                {
                    _dbInstance.conn.Open();
                    _command = new SqlCommand(DatabaseQueries.SELECT_ALL_CUSTOMERS, _dbInstance.conn);
                    _adapter = new SqlDataAdapter(_command);
                    _dt = new DataTable();
                    _adapter.Fill(_dt);
                    dgvSearch.DataSource = _dt.DefaultView;
                    dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                    dgvSearch.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvSearch.EnableHeadersVisualStyles = false;
                    for (int i = 0; i < _dt.Columns.Count; i++)
                    {
                        var column = dgvSearch.Columns[i];
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        column.DefaultCellStyle.BackColor = Color.Silver;
                        switch (i)
                        {
                            case 0:
                                column.HeaderText = "FIRST NAME";
                                break;
                            case 1:
                                column.HeaderText = "LAST NAME";
                                break;
                            case 2:
                                column.HeaderText = "AGE";
                                break;
                            case 3:
                                column.HeaderText = "SEX";
                                break;
                            case 4:
                                column.HeaderText = "ADDRESS LINE 1";
                                break;
                            case 5:
                                column.HeaderText = "ADDRESS LINE 2";
                                break;
                            case 6:
                                column.HeaderText = "COUNTY";
                                break;
                            case 7:
                                column.HeaderText = "POST CODE";
                                break;
                            case 8:
                                column.HeaderText = "REGULAR CUSTOMER?";
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
                        GetData();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.Hide();
                    }
                }
                this.Refresh();
            }
            else if (_type == "Employee")
            {
                try
                {
                    _dbInstance.conn.Open();
                    _command = new SqlCommand(DatabaseQueries.SELECT_ALL_EMPLOYEES, _dbInstance.conn);
                    _adapter = new SqlDataAdapter(_command);
                    _dt = new DataTable();
                    _adapter.Fill(_dt);
                    dgvSearch.DataSource = _dt.DefaultView;
                    dgvSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                    dgvSearch.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvSearch.EnableHeadersVisualStyles = false;
                    for (int i = 0; i < _dt.Columns.Count; i++)
                    {
                        var column = dgvSearch.Columns[i];
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        column.DefaultCellStyle.BackColor = Color.Silver;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        switch (i)
                        {
                            case 0:
                                column.HeaderText = "FIRST NAME";
                                break;
                            case 1:
                                column.HeaderText = "LAST NAME";
                                break;
                            case 2:
                                column.HeaderText = "AGE";
                                break;
                            case 3:
                                column.HeaderText = "SEX";
                                break;
                            case 4:
                                column.HeaderText = "ADDRESS LINE 1";
                                break;
                            case 5:
                                column.HeaderText = "ADDRESS LINE 2";
                                break;
                            case 6:
                                column.HeaderText = "COUNTY";
                                break;
                            case 7:
                                column.HeaderText = "POST CODE";
                                break;
                            case 8:
                                column.HeaderText = "DEPARTMENT";
                                break;
                            case 9:
                                column.HeaderText = "COMPLETED TRAINING?";
                                break;
                            case 10:
                                column.HeaderText = "ADMIN PRIVILEGES?";
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
                        GetData();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.Hide();
                    }
                }
                this.Refresh();
            }
            else if (_type == "Product")
            {

            }
            if (cbxSearchColumn.Items.Count != 0)
            {
                cbxSearchColumn.Items.Clear();
                cbxSearchColumn.Text = "  SELECT COLUMN";
            }
            for (int i = 0; i < dgvSearch.Columns.Count; i++)
            {
                cbxSearchColumn.Items.Add(dgvSearch.Columns[i].HeaderText);
            }
        }
        public void SetSearchType(string type)
        {
            _type = type;
            lblSearch.Text = "Search " + _type + "s";
            GetData();
        }
        private void tbxSearchTerm_TextChanged(object sender, EventArgs e)
        {
            _dt.DefaultView.RowFilter = string.Format(dgvSearch.Columns[0].DataPropertyName + " LIKE '%{0}%'", tbxSearchTerm.Text.Trim().Replace("'", "''"));
            dgvSearch.DataSource = _dt.DefaultView;
            dgvSearch.Refresh();
        }
        private void btnSortByColumn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvSearch.Columns)
            {
                if (column.HeaderText.Equals(cbxSearchColumn.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    _index = column.Index;
                }
            }
            dgvSearch.Sort(dgvSearch.Columns[_index], ListSortDirection.Ascending);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSearch.Refresh();
        }
    }
}
