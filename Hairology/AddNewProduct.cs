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

namespace Hairology
{
    public partial class AddNewProduct : UserControl
    {
        // database management attributes
        private DatabaseManagement _dbInstance = new DatabaseManagement();
        private SqlCommand _command = default!;
        private SqlDataReader _reader = default!;
        // product attributes
        private int _productID = default!;
        private string _productName = default!;
        private string _productDescription = default!;
        private int _caseSize = default!;
        private string _eanNumber = default!;
        private int _currentQuantity = default!;
        private string _category = default!;
        private bool _reorderRegularly = default!;
        private bool _productHasImage = default!;
        private Bitmap _productImage = default!;
        private string _fileName = default!;
        private const string _imageFilesDirectory = "C:\\Hairology\\Data\\images\\products\\";
        public AddNewProduct()
        {
            InitializeComponent();
            SetFonts();
            btnRemoveImage.Enabled = false;
        }
        private void SetFonts()
        {
            // labels
            lblAddNewProduct.Font = FontManagement.labels;
            lblCaseSize.Font = FontManagement.labels;
            lblCurrentQuantity.Font = FontManagement.labels;
            lblDescription.Font = FontManagement.labels;
            lblProductName.Font = FontManagement.labels;
            lblReorderRegularly.Font = FontManagement.labels;
            rbtnNo.Font = FontManagement.labels;
            rbtnYes.Font = FontManagement.labels;
            // text input
            tbxCaseSize.Font = FontManagement.textInput;
            cbxCategory.Font = FontManagement.textInput;
            tbxCurrentQuantity.Font = FontManagement.textInput;
            tbxDescription.Font = FontManagement.textInput;
            tbxEANNumber.Font = FontManagement.textInput;
            tbxProductName.Font = FontManagement.textInput;
            // buttons
            btnSubmit.Font = FontManagement.buttons;
        }
        /// <summary>
        /// opens the dialog used to load the image of the product when picture box is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxProductImage_Click(object sender, EventArgs e)
        {
            ofdOpenProductImage.Filter = "Select Image (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (ofdOpenProductImage.ShowDialog() == DialogResult.OK)
            {
                pbxProductImage.BackgroundImage = new Bitmap(ofdOpenProductImage.FileName);
                _productImage = new Bitmap(pbxProductImage.BackgroundImage);
                // store path of product image
                _fileName = ofdOpenProductImage.FileName;
                btnRemoveImage.Enabled = true;
                _productHasImage = true;
            }
        }
        /// <summary>
        /// clears the product image when the remove button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbxProductImage.BackgroundImage = new Bitmap(Properties.Resources.addimage);
            btnRemoveImage.Enabled = false;
            _productHasImage = false;
        }
        /// <summary>
        /// saves product image locally by assigning a unique filename using the product's EAN number
        /// </summary>
        private void SaveProductImage()
        {
            // if directory used to store product images does not exist, create it
            if (!Directory.Exists(_imageFilesDirectory))
            {
                string current = Directory.GetCurrentDirectory();
                Directory.CreateDirectory(_imageFilesDirectory);
                Directory.SetCurrentDirectory(current);
            }
            // give each product image a unique filename by using the product's EAN number
            string newFileName = _eanNumber + ".bmp";
            // if product has been given an image
            if (_productHasImage == true)
            {
                // if image of product already exists in images folder, delete it first (to prevent copying exceptions)
                if (File.Exists(_imageFilesDirectory + newFileName))
                {
                    File.Delete(_imageFilesDirectory + newFileName);
                }
                // copy product image using unique filename
                File.Copy(_fileName, _imageFilesDirectory + newFileName);
                _fileName = newFileName;
            }
            // if product has not been given an image, assign product with a placeholder image
            else if (_productHasImage == false)
            {
                Properties.Resources.imageNotFound.Save(_imageFilesDirectory + newFileName);
            }
        }
        /// <summary>
        /// sets private variables to values entered in the controls
        /// </summary>
        private void GetDataFromFields()
        {
            _productName = tbxProductName.Text;
            _productDescription = tbxDescription.Text;
            _caseSize = Int32.Parse(tbxCaseSize.Text);
            _eanNumber = tbxEANNumber.Text;
            _currentQuantity = Int32.Parse(tbxCurrentQuantity.Text);
            _category = cbxCategory.Text;
        }
        /// <summary>
        /// checks for missing fields, returns 'false' if checks fail and 'true' if checks pass
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// generates a random 8-digit number to be used as the product's ID number
        /// </summary>
        /// <returns></returns>
        private int GenerateRandomID()
        {
            int id = default!;
            Random r = new Random();
            id = r.Next(10000000, 99999999);
            _dbInstance.ConnectToDatabase();
            _dbInstance.conn.Open();
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_RANDOM_PRODUCT_ID, id), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            // if random ID was already previously generated and assigned to a product
            if (_reader.Read())
            {
                // generate a new random number by calling the method again
                GenerateRandomID();
            }
            else
            {
                // if not, return the random ID
                return id;
            }
            _reader.Close();
            _dbInstance.conn.Close();
            return id;
        }
        /// <summary>
        /// saves product image to local directory and inserts product into database
        /// </summary>
        private void InsertIntoDatabase()
        {
            // generate random 8-digit product ID
            _productID = GenerateRandomID();
            _dbInstance.ConnectToDatabase();
            _dbInstance.conn.Open();
            // check that product with entered EAN number doesn't already exist in database
            _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_PRODUCT_USING_EAN_NUMBER, _eanNumber), _dbInstance.conn);
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                // show prompt if product does already exist
                MessageBox.Show("A product with this EAN number already exists in the database", "EAN Number Already Assigned to Another Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _reader.Close();
            }
            else
            {
                _reader.Close();
                // call method used to save product image to local directory
                SaveProductImage();
                // run SQL command that will insert product into database (using values of private attributes)
                _command = new SqlCommand(string.Format(DatabaseQueries.INSERT_INTO_INVENTORY, _productID, _productName, _productDescription, _fileName, _category, _eanNumber, _caseSize, _currentQuantity, _reorderRegularly), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                _reader.Close();
                // search for newly-inserted product to verify that it has been added to database successfully
                _command = new SqlCommand(string.Format(DatabaseQueries.SELECT_PRODUCT_USING_ID, _productID), _dbInstance.conn);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    // show prompt to show that insertion was successful
                    MessageBox.Show("The product '" + _productName + "' was inserted into the Inventory table successfully", "Product Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _reader.Close();
                }
            }
            _dbInstance.conn.Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // check for missing fields
            if (CheckFields() == true)
            {
                // once all validation checks have passed, insert product into database
                InsertIntoDatabase();
                // clear product image from memory now it is no longer in use
                if (_productHasImage == true)
                {
                    _productImage.Dispose();
                    pbxProductImage.BackgroundImage = Properties.Resources.addimage;
                }
            }
        }
    }
}
