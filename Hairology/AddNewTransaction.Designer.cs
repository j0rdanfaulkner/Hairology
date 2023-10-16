namespace Hairology
{
    partial class AddNewTransaction
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
            pnlContainer = new Panel();
            btnSubmit = new Button();
            label1 = new Label();
            rbtnNo = new RadioButton();
            rbtnYes = new RadioButton();
            tbxAmountCharged = new TextBox();
            lblTotalAmount = new Label();
            dtpExpiryDate = new DateTimePicker();
            lblExpiryDate = new Label();
            tbxCVV = new TextBox();
            lblCVV = new Label();
            tbxCardNumber = new TextBox();
            lblCardNumber = new Label();
            lblSelectCustomer = new Label();
            cbxSelectCustomer = new ComboBox();
            lblAddNewTransaction = new Label();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(btnSubmit);
            pnlContainer.Controls.Add(label1);
            pnlContainer.Controls.Add(rbtnNo);
            pnlContainer.Controls.Add(rbtnYes);
            pnlContainer.Controls.Add(tbxAmountCharged);
            pnlContainer.Controls.Add(lblTotalAmount);
            pnlContainer.Controls.Add(dtpExpiryDate);
            pnlContainer.Controls.Add(lblExpiryDate);
            pnlContainer.Controls.Add(tbxCVV);
            pnlContainer.Controls.Add(lblCVV);
            pnlContainer.Controls.Add(tbxCardNumber);
            pnlContainer.Controls.Add(lblCardNumber);
            pnlContainer.Controls.Add(lblSelectCustomer);
            pnlContainer.Controls.Add(cbxSelectCustomer);
            pnlContainer.Controls.Add(lblAddNewTransaction);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 449);
            pnlContainer.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatStyle = FlatStyle.System;
            btnSubmit.Location = new Point(592, 321);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(547, 66);
            btnSubmit.TabIndex = 26;
            btnSubmit.Text = "SUBMIT DETAILS";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(114, 275);
            label1.Name = "label1";
            label1.Size = new Size(472, 28);
            label1.TabIndex = 25;
            label1.Text = "TRANSACTION COMPLETED?:";
            // 
            // rbtnNo
            // 
            rbtnNo.Anchor = AnchorStyles.None;
            rbtnNo.AutoSize = true;
            rbtnNo.Cursor = Cursors.Hand;
            rbtnNo.FlatStyle = FlatStyle.System;
            rbtnNo.Location = new Point(931, 274);
            rbtnNo.Name = "rbtnNo";
            rbtnNo.Size = new Size(84, 33);
            rbtnNo.TabIndex = 24;
            rbtnNo.TabStop = true;
            rbtnNo.Text = "NO";
            rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            rbtnYes.Anchor = AnchorStyles.None;
            rbtnYes.AutoSize = true;
            rbtnYes.Cursor = Cursors.Hand;
            rbtnYes.FlatStyle = FlatStyle.System;
            rbtnYes.Location = new Point(741, 274);
            rbtnYes.Name = "rbtnYes";
            rbtnYes.Size = new Size(98, 33);
            rbtnYes.TabIndex = 23;
            rbtnYes.TabStop = true;
            rbtnYes.Text = "YES";
            rbtnYes.UseVisualStyleBackColor = true;
            // 
            // tbxAmountCharged
            // 
            tbxAmountCharged.Anchor = AnchorStyles.None;
            tbxAmountCharged.Location = new Point(592, 225);
            tbxAmountCharged.MaxLength = 8;
            tbxAmountCharged.Name = "tbxAmountCharged";
            tbxAmountCharged.PlaceholderText = "  AMOUNT CHARGED";
            tbxAmountCharged.Size = new Size(547, 35);
            tbxAmountCharged.TabIndex = 22;
            tbxAmountCharged.TextChanged += tbxAmountCharged_TextChanged;
            tbxAmountCharged.Enter += tbxAmountCharged_Enter;
            tbxAmountCharged.Leave += tbxAmountCharged_Leave;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.None;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(314, 228);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(272, 28);
            lblTotalAmount.TabIndex = 21;
            lblTotalAmount.Text = "TOTAL AMOUNT:";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Anchor = AnchorStyles.None;
            dtpExpiryDate.CustomFormat = "MM/yy";
            dtpExpiryDate.Format = DateTimePickerFormat.Custom;
            dtpExpiryDate.Location = new Point(972, 179);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(167, 35);
            dtpExpiryDate.TabIndex = 20;
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.Anchor = AnchorStyles.None;
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Location = new Point(739, 182);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(227, 28);
            lblExpiryDate.TabIndex = 19;
            lblExpiryDate.Text = "EXPIRY DATE:";
            // 
            // tbxCVV
            // 
            tbxCVV.Anchor = AnchorStyles.None;
            tbxCVV.Location = new Point(592, 179);
            tbxCVV.MaxLength = 3;
            tbxCVV.Name = "tbxCVV";
            tbxCVV.PlaceholderText = "CVV";
            tbxCVV.Size = new Size(132, 35);
            tbxCVV.TabIndex = 14;
            tbxCVV.TextAlign = HorizontalAlignment.Center;
            tbxCVV.UseSystemPasswordChar = true;
            // 
            // lblCVV
            // 
            lblCVV.Anchor = AnchorStyles.None;
            lblCVV.AutoSize = true;
            lblCVV.Location = new Point(500, 184);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(86, 28);
            lblCVV.TabIndex = 18;
            lblCVV.Text = "CVV:";
            // 
            // tbxCardNumber
            // 
            tbxCardNumber.Anchor = AnchorStyles.None;
            tbxCardNumber.Location = new Point(592, 134);
            tbxCardNumber.MaxLength = 19;
            tbxCardNumber.Name = "tbxCardNumber";
            tbxCardNumber.PlaceholderText = "  CARD NUMBER";
            tbxCardNumber.Size = new Size(547, 35);
            tbxCardNumber.TabIndex = 14;
            tbxCardNumber.TextChanged += tbxCardNumber_TextChanged;
            // 
            // lblCardNumber
            // 
            lblCardNumber.Anchor = AnchorStyles.None;
            lblCardNumber.AutoSize = true;
            lblCardNumber.Location = new Point(324, 137);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(262, 28);
            lblCardNumber.TabIndex = 16;
            lblCardNumber.Text = "CARD NUMBER:";
            // 
            // lblSelectCustomer
            // 
            lblSelectCustomer.Anchor = AnchorStyles.None;
            lblSelectCustomer.AutoSize = true;
            lblSelectCustomer.Location = new Point(254, 92);
            lblSelectCustomer.Name = "lblSelectCustomer";
            lblSelectCustomer.Size = new Size(332, 28);
            lblSelectCustomer.TabIndex = 15;
            lblSelectCustomer.Text = "SELECT CUSTOMER:";
            // 
            // cbxSelectCustomer
            // 
            cbxSelectCustomer.Anchor = AnchorStyles.None;
            cbxSelectCustomer.FormattingEnabled = true;
            cbxSelectCustomer.Location = new Point(592, 89);
            cbxSelectCustomer.Name = "cbxSelectCustomer";
            cbxSelectCustomer.Size = new Size(547, 36);
            cbxSelectCustomer.TabIndex = 14;
            cbxSelectCustomer.Text = "  SELECT CUSTOMER";
            cbxSelectCustomer.Click += cbxSelectCustomer_Click;
            // 
            // lblAddNewTransaction
            // 
            lblAddNewTransaction.AutoSize = true;
            lblAddNewTransaction.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddNewTransaction.Location = new Point(15, 15);
            lblAddNewTransaction.Name = "lblAddNewTransaction";
            lblAddNewTransaction.Size = new Size(401, 28);
            lblAddNewTransaction.TabIndex = 13;
            lblAddNewTransaction.Text = "ADD NEW TRANSACTION";
            // 
            // AddNewTransaction
            // 
            AutoScaleDimensions = new SizeF(19F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pnlContainer);
            Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(8, 6, 8, 6);
            Name = "AddNewTransaction";
            Size = new Size(1264, 449);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Label lblAddNewTransaction;
        private ComboBox cbxSelectCustomer;
        private Label lblSelectCustomer;
        private Label lblCardNumber;
        private TextBox tbxCardNumber;
        private TextBox tbxCVV;
        private Label lblCVV;
        private Label lblExpiryDate;
        private DateTimePicker dtpExpiryDate;
        private TextBox tbxAmountCharged;
        private Label lblTotalAmount;
        private Label label1;
        private RadioButton rbtnNo;
        private RadioButton rbtnYes;
        private Button btnSubmit;
    }
}
