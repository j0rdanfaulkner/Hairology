namespace Hairology
{
    partial class AddNewProduct
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
            lblAddNewProduct = new Label();
            pnlContainer = new Panel();
            btnRemoveImage = new Button();
            lblDescription = new Label();
            btnSubmit = new Button();
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
            // lblAddNewProduct
            // 
            lblAddNewProduct.AutoSize = true;
            lblAddNewProduct.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddNewProduct.Location = new Point(15, 15);
            lblAddNewProduct.Name = "lblAddNewProduct";
            lblAddNewProduct.Size = new Size(275, 28);
            lblAddNewProduct.TabIndex = 14;
            lblAddNewProduct.Text = "Add New Product";
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(btnRemoveImage);
            pnlContainer.Controls.Add(lblDescription);
            pnlContainer.Controls.Add(btnSubmit);
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
            pnlContainer.Controls.Add(lblAddNewProduct);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 449);
            pnlContainer.TabIndex = 15;
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
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(158, 121);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(192, 28);
            lblDescription.TabIndex = 29;
            lblDescription.Text = "Description:";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Location = new Point(912, 342);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(317, 75);
            btnSubmit.TabIndex = 28;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
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
            rbtnNo.Size = new Size(78, 32);
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
            rbtnYes.Size = new Size(92, 32);
            rbtnYes.TabIndex = 25;
            rbtnYes.TabStop = true;
            rbtnYes.Text = "YES";
            rbtnYes.UseVisualStyleBackColor = true;
            // 
            // lblReorderRegularly
            // 
            lblReorderRegularly.Anchor = AnchorStyles.None;
            lblReorderRegularly.AutoSize = true;
            lblReorderRegularly.Location = new Point(44, 389);
            lblReorderRegularly.Name = "lblReorderRegularly";
            lblReorderRegularly.Size = new Size(306, 28);
            lblReorderRegularly.TabIndex = 24;
            lblReorderRegularly.Text = "Re-order Regularly?";
            // 
            // tbxCurrentQuantity
            // 
            tbxCurrentQuantity.Anchor = AnchorStyles.None;
            tbxCurrentQuantity.Location = new Point(366, 340);
            tbxCurrentQuantity.MaxLength = 99;
            tbxCurrentQuantity.Name = "tbxCurrentQuantity";
            tbxCurrentQuantity.PlaceholderText = "00";
            tbxCurrentQuantity.Size = new Size(73, 35);
            tbxCurrentQuantity.TabIndex = 23;
            tbxCurrentQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCurrentQuantity
            // 
            lblCurrentQuantity.Anchor = AnchorStyles.None;
            lblCurrentQuantity.AutoSize = true;
            lblCurrentQuantity.Location = new Point(75, 343);
            lblCurrentQuantity.Name = "lblCurrentQuantity";
            lblCurrentQuantity.Size = new Size(275, 28);
            lblCurrentQuantity.TabIndex = 22;
            lblCurrentQuantity.Text = "Current Quantity:";
            // 
            // lblCaseSize
            // 
            lblCaseSize.Anchor = AnchorStyles.None;
            lblCaseSize.AutoSize = true;
            lblCaseSize.Location = new Point(182, 292);
            lblCaseSize.Name = "lblCaseSize";
            lblCaseSize.Size = new Size(168, 28);
            lblCaseSize.TabIndex = 21;
            lblCaseSize.Text = "Case Size:";
            // 
            // tbxCaseSize
            // 
            tbxCaseSize.Anchor = AnchorStyles.None;
            tbxCaseSize.Location = new Point(366, 289);
            tbxCaseSize.MaxLength = 99;
            tbxCaseSize.Name = "tbxCaseSize";
            tbxCaseSize.PlaceholderText = "00";
            tbxCaseSize.Size = new Size(73, 35);
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
            tbxEANNumber.Size = new Size(391, 35);
            tbxEANNumber.TabIndex = 19;
            tbxEANNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxCategory
            // 
            cbxCategory.Anchor = AnchorStyles.None;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(455, 339);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(391, 36);
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
            tbxProductName.Size = new Size(483, 35);
            tbxProductName.TabIndex = 17;
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.None;
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(72, 70);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(278, 28);
            lblProductName.TabIndex = 16;
            lblProductName.Text = "Name of Product:";
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
            // AddNewProduct
            // 
            AutoScaleDimensions = new SizeF(19F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pnlContainer);
            Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(8, 6, 8, 6);
            Name = "AddNewProduct";
            Size = new Size(1264, 449);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAddNewProduct;
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
        private Button btnSubmit;
        private TextBox tbxDescription;
        private RadioButton rbtnNo;
        private OpenFileDialog ofdOpenProductImage;
        private Button btnRemoveImage;
    }
}
