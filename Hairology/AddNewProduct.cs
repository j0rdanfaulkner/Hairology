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
    public partial class AddNewProduct : UserControl
    {
        private string _imageFilePath = default!;
        public AddNewProduct()
        {
            InitializeComponent();
            btnRemoveImage.Enabled = false;
        }
        private void pbxProductImage_Click(object sender, EventArgs e)
        {
            ofdOpenProductImage.Filter = "Select Image (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (ofdOpenProductImage.ShowDialog() == DialogResult.OK)
            {
                pbxProductImage.BackgroundImage = new Bitmap(ofdOpenProductImage.FileName);
                // store path of product image
                _imageFilePath = ofdOpenProductImage.FileName;
                btnRemoveImage.Enabled = true;
            }
        }
        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbxProductImage.BackgroundImage = new Bitmap(Properties.Resources.addimage);
            btnRemoveImage.Enabled = false;
        }
    }
}
