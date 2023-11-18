using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace Hairology
{
    public partial class EditProduct : UserControl
    {
        // database management attributes
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        private Product _editingProduct = default!;
        private const string _imageFilesDirectory = "C:\\Hairology\\Data\\images\\products\\";
        // product attributes
        private int _productID = default;
        private string _productName = default!;
        private string _productDescription = default!;
        private string _productImageFilename = default!;
        private string _category = default!;
        private string _eanNumber = default!;
        private int _caseSize = default!;
        private int _currentQuantity = default!;
        private bool _reorderRegularly = default!;
        private bool _changesMade = default!;
        public EditProduct()
        {
            InitializeComponent();
            _dbInstance.ConnectToDatabase();
            btnRemoveImage.Enabled = true;
        }
        public void SetProductForEditing(Product product)
        {
            _editingProduct = product;
            SetDetails();
        }
        public void SetDetails()
        {
            tbxProductName.Text = _editingProduct.GetAttribute(0).ToString();
            tbxDescription.Text = _editingProduct.GetAttribute(1).ToString();
            cbxCategory.SelectedItem = _editingProduct.GetAttribute(2).ToString();
            tbxEANNumber.Text = _editingProduct.GetAttribute(3).ToString();
            tbxCaseSize.Text = _editingProduct.GetAttribute(4).ToString();
            tbxCurrentQuantity.Text = _editingProduct.GetAttribute(5).ToString();
            if (Convert.ToBoolean(_editingProduct.GetAttribute(6).ToString()) == true)
            {
                rbtnYes.Checked = true;
                rbtnNo.Checked = false;
            }
            else if (Convert.ToBoolean(_editingProduct.GetAttribute(6).ToString()) == false)
            {
                rbtnYes.Checked = false;
                rbtnNo.Checked = true;
            }
            pbxProductImage.BackgroundImage = Image.FromFile(_imageFilesDirectory + _editingProduct.GetAttribute(3).ToString() + ".bmp");
        }
        private void GetDataFromFields()
        {
            // collect each attribute using the values of each field of the form
            _productName = tbxProductName.Text;
            _productDescription = tbxDescription.Text;
            _productImageFilename = tbxEANNumber.Text + ".bmp";
            _category = cbxCategory.Text;
            _eanNumber = tbxEANNumber.Text;
            _caseSize = Int32.Parse(tbxCaseSize.Text);
            _currentQuantity = Int32.Parse(tbxCurrentQuantity.Text);
        }
        private bool CheckFields()
        {
            if (tbxProductName.Text == "")
            {
                MessageBox.Show("The product name was not entered", "Missing Product Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (tbxDescription.Text == "")
                {
                    MessageBox.Show("The description of the product was not entered", "Missing Product Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    if (tbxCaseSize.Text == "" || tbxCaseSize.Text == "0")
                    {
                        MessageBox.Show("The case size of the product was not entered", "Missing Case Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    // check that only numbers have been entered
                    else if (!Regex.IsMatch(tbxCaseSize.Text, @"^[0-9]*$"))
                    {
                        MessageBox.Show("The case size of the product was not entered correctly", "Incorrect Case Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        if (tbxEANNumber.Text == "")
                        {
                            MessageBox.Show("The EAN number of the product was not entered", "Missing EAN Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else if (tbxEANNumber.Text.Length != 13)
                        {
                            MessageBox.Show("The EAN number of the product was not entered correctly", "Unreadable EAN Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        // check that only numbers have been entered
                        else if (!Regex.IsMatch(tbxEANNumber.Text, @"^[0-9]*$"))
                        {
                            MessageBox.Show("The EAN number of the product was not entered correctly", "Unreadable EAN Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            if (tbxCurrentQuantity.Text == "")
                            {
                                MessageBox.Show("The current quantity of the product was not entered", "Missing Current Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                            // check that only numbers have been entered
                            else if (!Regex.IsMatch(tbxCurrentQuantity.Text, @"^[0-9]*$"))
                            {
                                MessageBox.Show("The current quantity of the product was not entered correctly", "Incorrect Current Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                            else
                            {
                                if (cbxCategory.Text == "  CHOOSE CATEGORY" || cbxCategory.Text == "")
                                {
                                    MessageBox.Show("The product category was not selected", "Missing Product Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }
                                else
                                {
                                    if (rbtnYes.Checked == false && rbtnNo.Checked == false)
                                    {
                                        MessageBox.Show("The option to reorder the product regularly was not selected", "Missing Reorder Option", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return false;
                                    }
                                    else
                                    {
                                        if (rbtnYes.Checked == true && rbtnNo.Checked == false)
                                        {
                                            _reorderRegularly = true;
                                        }
                                        else if (rbtnYes.Checked == false && rbtnNo.Checked == true)
                                        {
                                            _reorderRegularly = false;
                                        }
                                        GetDataFromFields();
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void CheckForChanges()
        {
            if (rbtnYes.Checked == true && rbtnNo.Checked == false)
            {
                _reorderRegularly = true;
            }
            else if (rbtnYes.Checked == false && rbtnNo.Checked == true)
            {
                _reorderRegularly = false;
            }
            if (tbxProductName.Text != _editingProduct.GetAttribute(0).ToString())
            {
                _changesMade = true;
            }
            else if (tbxDescription.Text != _editingProduct.GetAttribute(1).ToString())
            {
                _changesMade = true;
            }
            else if (cbxCategory.Text != _editingProduct.GetAttribute(2).ToString())
            {
                _changesMade = true;
            }
            else if (tbxEANNumber.Text != _editingProduct.GetAttribute(3).ToString())
            {
                _changesMade = true;
            }
            else if (tbxCaseSize.Text != _editingProduct.GetAttribute(4).ToString())
            {
                _changesMade = true;
            }
            else if (tbxCurrentQuantity.Text != _editingProduct.GetAttribute(5).ToString())
            {
                _changesMade = true;
            }
            else if (_reorderRegularly != Convert.ToBoolean(_editingProduct.GetAttribute(6).ToString()))
            {
                _changesMade = true;
            }
            else
            {
                _changesMade = false;
            }
        }
        private void PerformDatabaseAction(string action)
        {
            if (CheckFields() == true)
            {
                // retrieve ID so that a specific (matching) record is ammended as opposed to every record within the table
                _dbInstance.conn.Open();
                _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_PRODUCT_ID_USING_EAN_NUMBER, _editingProduct.GetAttribute(3)), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    _productID = Convert.ToInt32(_reader[0]);
                    _reader.Close();
                    if (action == "Update")
                    {
                        if (rbtnYes.Checked == true && rbtnNo.Checked == false)
                        {
                            _reorderRegularly = true;
                        }
                        else if (rbtnYes.Checked == false && rbtnNo.Checked == true)
                        {
                            _reorderRegularly = false;
                        }
                        // update record that matches the ID
                        _command = new SqlCommand(string.Format(DatabaseQueries.UPDATE_PRODUCT_DETAILS, _productName, _productDescription, _productImageFilename, _category, _eanNumber, _caseSize, _currentQuantity, _reorderRegularly, _productID), _dbInstance.conn);
                        _reader = _command.ExecuteReader();
                        // show confirmation of amended details to user
                        MessageBox.Show("The changes to product '" + _editingProduct.GetAttribute(0) + "' were updated successfully", "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // rename product image file if EAN number changed
                        if (_eanNumber != _editingProduct.GetAttribute(3).ToString())
                        {
                            pbxProductImage.BackgroundImage.Dispose();
                            File.Copy(_imageFilesDirectory + _editingProduct.GetAttribute(3) + ".bmp", _imageFilesDirectory + _eanNumber + ".bmp");
                            // delete file with old EAN number as it is no longer needed
                            File.Delete(_imageFilesDirectory + _editingProduct.GetAttribute(3) + ".bmp");
                        }
                        _reader.Close();
                    }
                    else if (action == "Delete")
                    {
                        // delete record that matches the ID
                        _command = new SqlCommand(string.Format(DatabaseQueries.DELETE_PRODUCT, _productID), _dbInstance.conn);
                        _reader = _command.ExecuteReader();
                        _reader.Close();
                        // show confirmation of deletion to user
                        MessageBox.Show("The product '" + _editingProduct.GetAttribute(0) + "' was deleted from the database", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // also delete image file of product as it is no longer needed
                        File.Delete(_imageFilesDirectory + _editingProduct.GetAttribute(3) + ".bmp");
                    }
                }
                _dbInstance.conn.Close();
            }
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            CheckForChanges();
            if (_changesMade == false)
            {
                DialogResult result = MessageBox.Show("No changes to the product '" + _editingProduct.GetAttribute(0) + "' were made, are you sure you wish to continue?", "No Changes Made", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    PerformDatabaseAction("Update");
                }
                else
                {
                    MainWindow.editing = true;
                    MainWindow.type = "product";
                }
            }
            else
            {
                PerformDatabaseAction("Update");
            }
        }
        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            CheckForChanges();
            if (_changesMade == true)
            {
                DialogResult result = MessageBox.Show("Unsaved changes have been made to the product '" + _editingProduct.GetAttribute(0) + "', are you sure you wish to continue?", "Unsaved Changes Made", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MainWindow.editing = false;
                    this.Hide();
                }
                else
                {
                    MainWindow.editing = true;
                }
            }
            else
            {
                MainWindow.editing = false;
                this.Hide();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to delete the product '" + _editingProduct.GetAttribute(0) + "'?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                PerformDatabaseAction("Delete");
            }
            else
            {
                MainWindow.editing = true;
            }
        }
    }
}
