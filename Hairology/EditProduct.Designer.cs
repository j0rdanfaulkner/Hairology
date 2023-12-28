namespace Hairology
{
    partial class EditProduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbllEditProduct = new Label();
            pnlContainer = new Panel();
            btnDiscardChanges = new Button();
            btnDelete = new Button();
            btnRemoveImage = new Button();
            lblDescription = new Label();
            btnSaveChanges = new Button();
            tbxDescription = new TextBox();
            rbtnNo = new RadioButton();
            rbtnYes = new RadioButton();
            lblReorderRegularly = new Label();
            tbxCurrentQuantity = new TextBox();
            lblCurrentQuantity = new Label();
            lblCaseSize = new Label();
            tbxCaseSize = new TextBox();
            tbxEANNumber = new TextBox();
            cbxCategory = new ComboBox();
            tbxProductName = new TextBox();
            lblProductName = new Label();
            pbxProductImage = new PictureBox();
            ofdOpenProductImage = new OpenFileDialog();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxProductImage).BeginInit();
            SuspendLayout();
            // 
            // lbllEditProduct
            // 
            lbllEditProduct.AutoSize = true;
            lbllEditProduct.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbllEditProduct.Location = new Point(15, 15);
            lbllEditProduct.Name = "lbllEditProduct";
            lbllEditProduct.Size = new Size(141, 25);
            lbllEditProduct.TabIndex = 14;
            lbllEditProduct.Text = "Edit Product";
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(btnDiscardChanges);
            pnlContainer.Controls.Add(btnDelete);
            pnlContainer.Controls.Add(btnRemoveImage);
            pnlContainer.Controls.Add(lblDescription);
            pnlContainer.Controls.Add(btnSaveChanges);
            pnlContainer.Controls.Add(tbxDescription);
            pnlContainer.Controls.Add(rbtnNo);
            pnlContainer.Controls.Add(rbtnYes);
            pnlContainer.Controls.Add(lblReorderRegularly);
            pnlContainer.Controls.Add(tbxCurrentQuantity);
            pnlContainer.Controls.Add(lblCurrentQuantity);
            pnlContainer.Controls.Add(lblCaseSize);
            pnlContainer.Controls.Add(tbxCaseSize);
            pnlContainer.Controls.Add(tbxEANNumber);
            pnlContainer.Controls.Add(cbxCategory);
            pnlContainer.Controls.Add(tbxProductName);
            pnlContainer.Controls.Add(lblProductName);
            pnlContainer.Controls.Add(pbxProductImage);
            pnlContainer.Controls.Add(lbllEditProduct);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 449);
            pnlContainer.TabIndex = 15;
            // 
            // btnDiscardChanges
            // 
            btnDiscardChanges.Anchor = AnchorStyles.None;
            btnDiscardChanges.BackgroundImage = Properties.Resources.notok;
            btnDiscardChanges.BackgroundImageLayout = ImageLayout.Zoom;
            btnDiscardChanges.Cursor = Cursors.Hand;
            btnDiscardChanges.Location = new Point(1004, 347);
            btnDiscardChanges.Name = "btnDiscardChanges";
            btnDiscardChanges.Size = new Size(70, 70);
            btnDiscardChanges.TabIndex = 32;
            btnDiscardChanges.UseVisualStyleBackColor = true;
            btnDiscardChanges.Click += btnDiscardChanges_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackgroundImage = Properties.Resources.bin;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(1096, 347);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 70);
            btnDelete.TabIndex = 31;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Anchor = AnchorStyles.None;
            btnRemoveImage.BackColor = SystemColors.ControlLightLight;
            btnRemoveImage.BackgroundImage = Properties.Resources.removeimage;
            btnRemoveImage.BackgroundImageLayout = ImageLayout.Zoom;
            btnRemoveImage.Cursor = Cursors.Hand;
            btnRemoveImage.Location = new Point(1181, 69);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(48, 48);
            btnRemoveImage.TabIndex = 30;
            btnRemoveImage.UseVisualStyleBackColor = false;
            btnRemoveImage.Click += btnRemoveImage_Click;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.Location = new Point(158, 119);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(192, 28);
            lblDescription.TabIndex = 29;
            lblDescription.Text = "Description:";
            lblDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.None;
            btnSaveChanges.BackgroundImage = Properties.Resources.save;
            btnSaveChanges.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.Location = new Point(912, 347);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(70, 70);
            btnSaveChanges.TabIndex = 28;
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // tbxDescription
            // 
            tbxDescription.Anchor = AnchorStyles.None;
            tbxDescription.Location = new Point(366, 121);
            tbxDescription.MaxLength = 512;
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.PlaceholderText = "  DESCRIBE THE PRODUCT...";
            tbxDescription.Size = new Size(483, 152);
            tbxDescription.TabIndex = 27;
            // 
            // rbtnNo
            // 
            rbtnNo.Anchor = AnchorStyles.None;
            rbtnNo.AutoSize = true;
            rbtnNo.Cursor = Cursors.Hand;
            rbtnNo.Location = new Point(624, 389);
            rbtnNo.Name = "rbtnNo";
            rbtnNo.Size = new Size(63, 29);
            rbtnNo.TabIndex = 26;
            rbtnNo.TabStop = true;
            rbtnNo.Text = "NO";
            rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            rbtnYes.Anchor = AnchorStyles.None;
            rbtnYes.AutoSize = true;
            rbtnYes.Cursor = Cursors.Hand;
            rbtnYes.Location = new Point(505, 389);
            rbtnYes.Name = "rbtnYes";
            rbtnYes.Size = new Size(76, 29);
            rbtnYes.TabIndex = 25;
            rbtnYes.TabStop = true;
            rbtnYes.Text = "YES";
            rbtnYes.UseVisualStyleBackColor = true;
            // 
            // lblReorderRegularly
            // 
            lblReorderRegularly.Anchor = AnchorStyles.None;
            lblReorderRegularly.Location = new Point(44, 387);
            lblReorderRegularly.Name = "lblReorderRegularly";
            lblReorderRegularly.Size = new Size(306, 28);
            lblReorderRegularly.TabIndex = 24;
            lblReorderRegularly.Text = "Re-order Regularly?";
            lblReorderRegularly.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxCurrentQuantity
            // 
            tbxCurrentQuantity.Anchor = AnchorStyles.None;
            tbxCurrentQuantity.Location = new Point(366, 340);
            tbxCurrentQuantity.MaxLength = 99;
            tbxCurrentQuantity.Name = "tbxCurrentQuantity";
            tbxCurrentQuantity.PlaceholderText = "00";
            tbxCurrentQuantity.Size = new Size(73, 31);
            tbxCurrentQuantity.TabIndex = 23;
            tbxCurrentQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCurrentQuantity
            // 
            lblCurrentQuantity.Anchor = AnchorStyles.None;
            lblCurrentQuantity.Location = new Point(75, 341);
            lblCurrentQuantity.Name = "lblCurrentQuantity";
            lblCurrentQuantity.Size = new Size(275, 28);
            lblCurrentQuantity.TabIndex = 22;
            lblCurrentQuantity.Text = "Current Quantity:";
            lblCurrentQuantity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCaseSize
            // 
            lblCaseSize.Anchor = AnchorStyles.None;
            lblCaseSize.Location = new Point(182, 290);
            lblCaseSize.Name = "lblCaseSize";
            lblCaseSize.Size = new Size(168, 28);
            lblCaseSize.TabIndex = 21;
            lblCaseSize.Text = "Case Size:";
            lblCaseSize.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxCaseSize
            // 
            tbxCaseSize.Anchor = AnchorStyles.None;
            tbxCaseSize.Location = new Point(366, 289);
            tbxCaseSize.MaxLength = 99;
            tbxCaseSize.Name = "tbxCaseSize";
            tbxCaseSize.PlaceholderText = "00";
            tbxCaseSize.Size = new Size(73, 31);
            tbxCaseSize.TabIndex = 20;
            tbxCaseSize.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxEANNumber
            // 
            tbxEANNumber.Anchor = AnchorStyles.None;
            tbxEANNumber.Location = new Point(455, 289);
            tbxEANNumber.MaxLength = 13;
            tbxEANNumber.Name = "tbxEANNumber";
            tbxEANNumber.PlaceholderText = "  ENTER EAN NUMBER...";
            tbxEANNumber.Size = new Size(391, 31);
            tbxEANNumber.TabIndex = 19;
            tbxEANNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxCategory
            // 
            cbxCategory.Anchor = AnchorStyles.None;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Items.AddRange(new object[] { "Barber Supplies", "Hair Accessories", "Hair Care", "Hair Coloring", "Hair Cutting Tools", "Hair Extensions", "Hair Perming and Relaxing", "Hair Styling Chairs and Stations", "Hair Styling Tools", "Hair Texturizing", "Hair Thinning and Loss", "Hairdressing Capes and Apparel", "Hairdressing Kits and Sets", "Hair and Scalp Treatments" });
            cbxCategory.Location = new Point(455, 339);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(391, 33);
            cbxCategory.TabIndex = 18;
            cbxCategory.Text = "  CHOOSE CATEGORY";
            // 
            // tbxProductName
            // 
            tbxProductName.Anchor = AnchorStyles.None;
            tbxProductName.Location = new Point(366, 67);
            tbxProductName.MaxLength = 256;
            tbxProductName.Name = "tbxProductName";
            tbxProductName.PlaceholderText = "  ENTER NAME...";
            tbxProductName.Size = new Size(483, 31);
            tbxProductName.TabIndex = 17;
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.None;
            lblProductName.Location = new Point(72, 68);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(278, 28);
            lblProductName.TabIndex = 16;
            lblProductName.Text = "Name of Product:";
            lblProductName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbxProductImage
            // 
            pbxProductImage.Anchor = AnchorStyles.None;
            pbxProductImage.BackColor = SystemColors.ControlLightLight;
            pbxProductImage.BackgroundImage = Properties.Resources.addimage;
            pbxProductImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbxProductImage.BorderStyle = BorderStyle.Fixed3D;
            pbxProductImage.Cursor = Cursors.Hand;
            pbxProductImage.Location = new Point(912, 69);
            pbxProductImage.Name = "pbxProductImage";
            pbxProductImage.Size = new Size(255, 255);
            pbxProductImage.TabIndex = 15;
            pbxProductImage.TabStop = false;
            pbxProductImage.Click += pbxProductImage_Click;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pnlContainer);
            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(8, 6, 8, 6);
            Name = "EditProduct";
            Size = new Size(1264, 449);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbllEditProduct;
        private Panel pnlContainer;
        private ComboBox cbxCategory;
        private TextBox tbxProductName;
        private Label lblProductName;
        private PictureBox pbxProductImage;
        private TextBox tbxEANNumber;
        private RadioButton rbtnYes;
        private Label lblReorderRegularly;
        private TextBox tbxCurrentQuantity;
        private Label lblCurrentQuantity;
        private Label lblCaseSize;
        private TextBox tbxCaseSize;
        private Label lblDescription;
        private Button btnSaveChanges;
        private TextBox tbxDescription;
        private RadioButton rbtnNo;
        private OpenFileDialog ofdOpenProductImage;
        private Button btnRemoveImage;
        private Button btnDelete;
        private Button btnDiscardChanges;
    }
}
