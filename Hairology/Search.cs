using Accessibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
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
        private SqlDataReader _reader = default!;
        private string _type = default!;
        private int _index = default!;
        public Customer customerForEditing = default!;
        public Employee employeeForEditing = default!;
        public Product productForEditing = default!;
        public Search()
        {
            InitializeComponent();
            _dbInstance.ConnectToDatabase();
            GetData();
            SetFonts();
            this.Refresh();
        }
        private void SetFonts()
        {
            lblSearch.Font = FontManagement.labels;
            tbxSearchTerm.Font = FontManagement.textInput;
            cbxSearchColumn.Font = FontManagement.textInput;
            dgvSearch.ColumnHeadersDefaultCellStyle.Font = FontManagement.columnHeaders;
            dgvSearch.DefaultCellStyle.Font = FontManagement.textInput;
        }
        private void GetData()
        {
            if (_type == "Customer")
            {
                tbxSearchTerm.Show();
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
                                column.HeaderText = "DATE OF BIRTH";
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
                tbxSearchTerm.Show();
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
                                column.HeaderText = "DATE OF BIRTH";
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
                                column.HeaderText = "EMPLOYEE NUMBER";
                                break;
                            case 9:
                                column.HeaderText = "DEPARTMENT";
                                break;
                            case 10:
                                column.HeaderText = "COMPLETED TRAINING?";
                                break;
                            case 11:
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
                tbxSearchTerm.Show();
                try
                {
                    _dbInstance.conn.Open();
                    _command = new SqlCommand(DatabaseQueries.SELECT_ALL_PRODUCTS, _dbInstance.conn);
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
                                column.HeaderText = "PRODUCT NAME";
                                break;
                            case 1:
                                column.HeaderText = "DESCRIPTION";
                                break;
                            case 2:
                                column.HeaderText = "CATEGORY";
                                break;
                            case 3:
                                column.HeaderText = "EAN NUMBER";
                                break;
                            case 4:
                                column.HeaderText = "CASE SIZE";
                                break;
                            case 5:
                                column.HeaderText = "CURRENT QUANTITY";
                                break;
                            case 6:
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
                        GetData();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.Hide();
                    }
                }
                this.Refresh();
            }
            else if (_type == "Transaction")
            {
                tbxSearchTerm.Hide();
                try
                {
                    _dbInstance.conn.Open();
                    _command = new SqlCommand(DatabaseQueries.SELECT_ALL_TRANSACTIONS, _dbInstance.conn);
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
                        GetData();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.Hide();
                    }
                }
                this.Refresh();
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
        public void SetSearchType(string searchType)
        {
            _type = searchType;
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

        private void dgvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_type == "Customer")
            {
                try
                {
                    string[] personalDetails = new string[9];
                    if (e.RowIndex > -1)
                    {
                        personalDetails[0] = dgvSearch.Rows[e.RowIndex].Cells[0].Value.ToString();
                        personalDetails[1] = dgvSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
                        personalDetails[2] = dgvSearch.Rows[e.RowIndex].Cells[2].Value.ToString();
                        personalDetails[3] = dgvSearch.Rows[e.RowIndex].Cells[3].Value.ToString();
                        personalDetails[4] = dgvSearch.Rows[e.RowIndex].Cells[4].Value.ToString();
                        personalDetails[5] = dgvSearch.Rows[e.RowIndex].Cells[5].Value.ToString();
                        personalDetails[6] = dgvSearch.Rows[e.RowIndex].Cells[6].Value.ToString();
                        personalDetails[7] = dgvSearch.Rows[e.RowIndex].Cells[7].Value.ToString();
                        personalDetails[8] = dgvSearch.Rows[e.RowIndex].Cells[8].Value.ToString();
                        customerForEditing = new Customer(personalDetails);
                    }
                    _dbInstance.conn.Open();
                    _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_CUSTOMER_ID_USING_POSTCODE, customerForEditing.GetAttribute(7)), _dbInstance.conn);
                    _reader = _command.ExecuteReader();
                    if (_reader.Read())
                    {
                        MainWindow.editing = true;
                        MainWindow.type = "Customer";
                        this.Hide();
                    }
                    _dbInstance.conn.Close();
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_type == "Employee")
            {
                try
                {
                    string[] personalDetails = new string[8];
                    string[] workDetails = new string[4];
                    if (e.RowIndex > -1)
                    {
                        personalDetails[0] = dgvSearch.Rows[e.RowIndex].Cells[0].Value.ToString();
                        personalDetails[1] = dgvSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
                        personalDetails[2] = dgvSearch.Rows[e.RowIndex].Cells[2].Value.ToString();
                        personalDetails[3] = dgvSearch.Rows[e.RowIndex].Cells[3].Value.ToString();
                        personalDetails[4] = dgvSearch.Rows[e.RowIndex].Cells[4].Value.ToString();
                        personalDetails[5] = dgvSearch.Rows[e.RowIndex].Cells[5].Value.ToString();
                        personalDetails[6] = dgvSearch.Rows[e.RowIndex].Cells[6].Value.ToString();
                        personalDetails[7] = dgvSearch.Rows[e.RowIndex].Cells[7].Value.ToString();
                        workDetails[0] = dgvSearch.Rows[e.RowIndex].Cells[8].Value.ToString();
                        workDetails[1] = dgvSearch.Rows[e.RowIndex].Cells[9].Value.ToString();
                        workDetails[2] = dgvSearch.Rows[e.RowIndex].Cells[10].Value.ToString();
                        workDetails[3] = dgvSearch.Rows[e.RowIndex].Cells[11].Value.ToString();
                        employeeForEditing = new Employee(personalDetails, workDetails);
                    }
                    _dbInstance.conn.Open();
                    _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_EMPLOYEE_ID_USING_EMPLOYEE_NUMBER, employeeForEditing.GetAttribute(8)), _dbInstance.conn);
                    _reader = _command.ExecuteReader();
                    if (_reader.Read())
                    {
                        MainWindow.editing = true;
                        MainWindow.type = "Employee";
                        this.Hide();
                    }
                    _dbInstance.conn.Close();
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_type == "Product")
            {
                try
                {
                    string[] productDetails = new string[7];
                    if (e.RowIndex > -1)
                    {
                        productDetails[0] = dgvSearch.Rows[e.RowIndex].Cells[0].Value.ToString();
                        productDetails[1] = dgvSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
                        productDetails[2] = dgvSearch.Rows[e.RowIndex].Cells[2].Value.ToString();
                        productDetails[3] = dgvSearch.Rows[e.RowIndex].Cells[3].Value.ToString();
                        productDetails[4] = dgvSearch.Rows[e.RowIndex].Cells[4].Value.ToString();
                        productDetails[5] = dgvSearch.Rows[e.RowIndex].Cells[5].Value.ToString();
                        productDetails[6] = dgvSearch.Rows[e.RowIndex].Cells[6].Value.ToString();
                        productForEditing = new Product(productDetails);
                    }
                    _dbInstance.conn.Open();
                    _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_PRODUCT_ID_USING_EAN_NUMBER, productForEditing.GetAttribute(3)), _dbInstance.conn);
                    _reader = _command.ExecuteReader();
                    if (_reader.Read())
                    {
                        MainWindow.editing = true;
                        MainWindow.type = "Product";
                        this.Hide();
                    }
                    _dbInstance.conn.Close();
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show(ex.Message, "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
