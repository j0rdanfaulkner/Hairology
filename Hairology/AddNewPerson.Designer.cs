namespace Hairology
{
    partial class AddNewPerson
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
            panel1 = new Panel();
            cbxRegularCustomer = new CheckBox();
            tbxFirstName = new TextBox();
            lblAddNewPerson = new Label();
            rbtnMale = new RadioButton();
            btnSubmit = new Button();
            tbxAddressLine2 = new TextBox();
            cbxCounty = new ComboBox();
            tbxLastName = new TextBox();
            rbtnFemale = new RadioButton();
            tbxPostCode = new TextBox();
            cbxAge = new ComboBox();
            tbxAddressLine1 = new TextBox();
            pnlContainer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = SystemColors.ActiveCaption;
            pnlContainer.Controls.Add(panel1);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Font = new Font("EurostileLTW03-Extended2", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 449);
            pnlContainer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxRegularCustomer);
            panel1.Controls.Add(tbxFirstName);
            panel1.Controls.Add(lblAddNewPerson);
            panel1.Controls.Add(rbtnMale);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(tbxAddressLine2);
            panel1.Controls.Add(cbxCounty);
            panel1.Controls.Add(tbxLastName);
            panel1.Controls.Add(rbtnFemale);
            panel1.Controls.Add(tbxPostCode);
            panel1.Controls.Add(cbxAge);
            panel1.Controls.Add(tbxAddressLine1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 449);
            panel1.TabIndex = 13;
            // 
            // cbxRegularCustomer
            // 
            cbxRegularCustomer.AutoSize = true;
            cbxRegularCustomer.Location = new Point(22, 300);
            cbxRegularCustomer.Name = "cbxRegularCustomer";
            cbxRegularCustomer.Size = new Size(293, 29);
            cbxRegularCustomer.TabIndex = 13;
            cbxRegularCustomer.Text = "Regular Customer?";
            cbxRegularCustomer.UseVisualStyleBackColor = true;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Anchor = AnchorStyles.Top;
            tbxFirstName.Location = new Point(22, 67);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.PlaceholderText = "  FIRST NAME";
            tbxFirstName.Size = new Size(399, 33);
            tbxFirstName.TabIndex = 1;
            // 
            // lblAddNewPerson
            // 
            lblAddNewPerson.AutoSize = true;
            lblAddNewPerson.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddNewPerson.Location = new Point(15, 15);
            lblAddNewPerson.Name = "lblAddNewPerson";
            lblAddNewPerson.Size = new Size(324, 28);
            lblAddNewPerson.TabIndex = 12;
            lblAddNewPerson.Text = "ADD NEW [PERSON]";
            // 
            // rbtnMale
            // 
            rbtnMale.Anchor = AnchorStyles.Top;
            rbtnMale.AutoSize = true;
            rbtnMale.Cursor = Cursors.Hand;
            rbtnMale.Location = new Point(163, 145);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(109, 29);
            rbtnMale.TabIndex = 4;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "MALE";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatStyle = FlatStyle.System;
            btnSubmit.Location = new Point(22, 333);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(399, 60);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "SUBMIT DETAILS";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxAddressLine2
            // 
            tbxAddressLine2.Anchor = AnchorStyles.Top;
            tbxAddressLine2.Location = new Point(22, 223);
            tbxAddressLine2.Multiline = true;
            tbxAddressLine2.Name = "tbxAddressLine2";
            tbxAddressLine2.PlaceholderText = "  ADDRESS LINE 2";
            tbxAddressLine2.Size = new Size(399, 33);
            tbxAddressLine2.TabIndex = 7;
            // 
            // cbxCounty
            // 
            cbxCounty.Anchor = AnchorStyles.Top;
            cbxCounty.FormattingEnabled = true;
            cbxCounty.Location = new Point(22, 262);
            cbxCounty.Name = "cbxCounty";
            cbxCounty.Size = new Size(192, 33);
            cbxCounty.TabIndex = 8;
            cbxCounty.Text = "  COUNTY";
            // 
            // tbxLastName
            // 
            tbxLastName.Anchor = AnchorStyles.Top;
            tbxLastName.Location = new Point(22, 106);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PlaceholderText = "  LAST NAME";
            tbxLastName.Size = new Size(399, 33);
            tbxLastName.TabIndex = 2;
            // 
            // rbtnFemale
            // 
            rbtnFemale.Anchor = AnchorStyles.Top;
            rbtnFemale.AutoSize = true;
            rbtnFemale.Cursor = Cursors.Hand;
            rbtnFemale.Location = new Point(278, 145);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(143, 29);
            rbtnFemale.TabIndex = 5;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "FEMALE";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // tbxPostCode
            // 
            tbxPostCode.Anchor = AnchorStyles.Top;
            tbxPostCode.Location = new Point(220, 262);
            tbxPostCode.MaxLength = 8;
            tbxPostCode.Name = "tbxPostCode";
            tbxPostCode.PlaceholderText = "  POST CODE";
            tbxPostCode.Size = new Size(201, 33);
            tbxPostCode.TabIndex = 9;
            tbxPostCode.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxAge
            // 
            cbxAge.Anchor = AnchorStyles.Top;
            cbxAge.FormattingEnabled = true;
            cbxAge.Location = new Point(22, 145);
            cbxAge.Name = "cbxAge";
            cbxAge.Size = new Size(135, 33);
            cbxAge.TabIndex = 3;
            cbxAge.Text = "  AGE";
            // 
            // tbxAddressLine1
            // 
            tbxAddressLine1.Anchor = AnchorStyles.Top;
            tbxAddressLine1.Location = new Point(22, 184);
            tbxAddressLine1.Multiline = true;
            tbxAddressLine1.Name = "tbxAddressLine1";
            tbxAddressLine1.PlaceholderText = "  ADDRESS LINE 1";
            tbxAddressLine1.Size = new Size(399, 33);
            tbxAddressLine1.TabIndex = 6;
            // 
            // AddNewPerson
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlContainer);
            Name = "AddNewPerson";
            Size = new Size(1264, 449);
            pnlContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private TextBox tbxAddressLine1;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private ComboBox cbxAge;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private TextBox tbxAddressLine2;
        private Label lblAddNewPerson;
        private Button btnSubmit;
        private TextBox tbxPostCode;
        private ComboBox cbxCounty;
        private Panel panel1;
        private CheckBox cbxRegularCustomer;
    }
}
