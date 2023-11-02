namespace Hairology
{
    partial class Setup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            lblWelcome = new Label();
            lblSubtitle = new Label();
            pnlContainer = new Panel();
            pnlTraining = new Panel();
            lblCompletedTraining = new Label();
            rbtnTrainingCompletedNo = new RadioButton();
            rbtnTrainingCompletedYes = new RadioButton();
            lblSex = new Label();
            tbxConfirmPassword = new TextBox();
            lblDOB = new Label();
            tbxPassword = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            tbxUsername = new TextBox();
            btnGenerateEmployeeNumber = new Button();
            tbxFirstName = new TextBox();
            rbtnMale = new RadioButton();
            tbxAddressLine1 = new TextBox();
            tbxEmployeeNumber = new TextBox();
            cbxDepartment = new ComboBox();
            btnSubmit = new Button();
            tbxPostCode = new TextBox();
            tbxAddressLine2 = new TextBox();
            rbtnFemale = new RadioButton();
            cbxCounty = new ComboBox();
            tbxLastName = new TextBox();
            pnlContainer.SuspendLayout();
            pnlTraining.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("EurostileLTW03-Extended2", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(15, 15);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(454, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Hairology";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(15, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(1099, 50);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "As this is your first time, please create an administrator account by entering all of the\r\ninformation below.";
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(pnlTraining);
            pnlContainer.Controls.Add(lblSex);
            pnlContainer.Controls.Add(tbxConfirmPassword);
            pnlContainer.Controls.Add(lblDOB);
            pnlContainer.Controls.Add(tbxPassword);
            pnlContainer.Controls.Add(dtpDateOfBirth);
            pnlContainer.Controls.Add(tbxUsername);
            pnlContainer.Controls.Add(btnGenerateEmployeeNumber);
            pnlContainer.Controls.Add(tbxFirstName);
            pnlContainer.Controls.Add(rbtnMale);
            pnlContainer.Controls.Add(tbxAddressLine1);
            pnlContainer.Controls.Add(tbxEmployeeNumber);
            pnlContainer.Controls.Add(cbxDepartment);
            pnlContainer.Controls.Add(btnSubmit);
            pnlContainer.Controls.Add(tbxPostCode);
            pnlContainer.Controls.Add(tbxAddressLine2);
            pnlContainer.Controls.Add(rbtnFemale);
            pnlContainer.Controls.Add(cbxCounty);
            pnlContainer.Controls.Add(tbxLastName);
            pnlContainer.Controls.Add(lblWelcome);
            pnlContainer.Controls.Add(lblSubtitle);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 681);
            pnlContainer.TabIndex = 2;
            // 
            // pnlTraining
            // 
            pnlTraining.Anchor = AnchorStyles.None;
            pnlTraining.Controls.Add(lblCompletedTraining);
            pnlTraining.Controls.Add(rbtnTrainingCompletedNo);
            pnlTraining.Controls.Add(rbtnTrainingCompletedYes);
            pnlTraining.Location = new Point(656, 307);
            pnlTraining.Name = "pnlTraining";
            pnlTraining.Size = new Size(538, 41);
            pnlTraining.TabIndex = 50;
            // 
            // lblCompletedTraining
            // 
            lblCompletedTraining.Anchor = AnchorStyles.None;
            lblCompletedTraining.AutoSize = true;
            lblCompletedTraining.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompletedTraining.Location = new Point(0, 6);
            lblCompletedTraining.Name = "lblCompletedTraining";
            lblCompletedTraining.Size = new Size(314, 28);
            lblCompletedTraining.TabIndex = 43;
            lblCompletedTraining.Text = "Completed Training?";
            // 
            // rbtnTrainingCompletedNo
            // 
            rbtnTrainingCompletedNo.Anchor = AnchorStyles.None;
            rbtnTrainingCompletedNo.AutoSize = true;
            rbtnTrainingCompletedNo.Cursor = Cursors.Hand;
            rbtnTrainingCompletedNo.Location = new Point(348, 6);
            rbtnTrainingCompletedNo.Name = "rbtnTrainingCompletedNo";
            rbtnTrainingCompletedNo.Size = new Size(72, 29);
            rbtnTrainingCompletedNo.TabIndex = 45;
            rbtnTrainingCompletedNo.TabStop = true;
            rbtnTrainingCompletedNo.Text = "NO";
            rbtnTrainingCompletedNo.UseVisualStyleBackColor = true;
            // 
            // rbtnTrainingCompletedYes
            // 
            rbtnTrainingCompletedYes.Anchor = AnchorStyles.None;
            rbtnTrainingCompletedYes.AutoSize = true;
            rbtnTrainingCompletedYes.Cursor = Cursors.Hand;
            rbtnTrainingCompletedYes.Location = new Point(442, 6);
            rbtnTrainingCompletedYes.Name = "rbtnTrainingCompletedYes";
            rbtnTrainingCompletedYes.Size = new Size(83, 29);
            rbtnTrainingCompletedYes.TabIndex = 44;
            rbtnTrainingCompletedYes.TabStop = true;
            rbtnTrainingCompletedYes.Text = "YES";
            rbtnTrainingCompletedYes.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            lblSex.Anchor = AnchorStyles.None;
            lblSex.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSex.Location = new Point(44, 337);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(106, 28);
            lblSex.TabIndex = 42;
            lblSex.Text = "Sex:";
            lblSex.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxConfirmPassword
            // 
            tbxConfirmPassword.Anchor = AnchorStyles.None;
            tbxConfirmPassword.Location = new Point(656, 535);
            tbxConfirmPassword.MaxLength = 256;
            tbxConfirmPassword.Name = "tbxConfirmPassword";
            tbxConfirmPassword.PlaceholderText = "  CONFIRM PASSWORD";
            tbxConfirmPassword.Size = new Size(538, 33);
            tbxConfirmPassword.TabIndex = 48;
            // 
            // lblDOB
            // 
            lblDOB.Anchor = AnchorStyles.None;
            lblDOB.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.Location = new Point(44, 306);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(106, 28);
            lblDOB.TabIndex = 40;
            lblDOB.Text = "DOB:";
            lblDOB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.None;
            tbxPassword.Location = new Point(656, 496);
            tbxPassword.MaxLength = 256;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PlaceholderText = "  PASSWORD";
            tbxPassword.Size = new Size(538, 33);
            tbxPassword.TabIndex = 47;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.None;
            dtpDateOfBirth.Location = new Point(156, 305);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(448, 33);
            dtpDateOfBirth.TabIndex = 37;
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = AnchorStyles.None;
            tbxUsername.Location = new Point(656, 457);
            tbxUsername.MaxLength = 256;
            tbxUsername.Name = "tbxUsername";
            tbxUsername.PlaceholderText = "  USERNAME";
            tbxUsername.Size = new Size(538, 33);
            tbxUsername.TabIndex = 46;
            // 
            // btnGenerateEmployeeNumber
            // 
            btnGenerateEmployeeNumber.Anchor = AnchorStyles.None;
            btnGenerateEmployeeNumber.Cursor = Cursors.Hand;
            btnGenerateEmployeeNumber.FlatStyle = FlatStyle.System;
            btnGenerateEmployeeNumber.Location = new Point(656, 354);
            btnGenerateEmployeeNumber.Name = "btnGenerateEmployeeNumber";
            btnGenerateEmployeeNumber.Size = new Size(538, 90);
            btnGenerateEmployeeNumber.TabIndex = 38;
            btnGenerateEmployeeNumber.Text = "GENERATE EMPLOYEE NUMBER";
            btnGenerateEmployeeNumber.UseVisualStyleBackColor = true;
            btnGenerateEmployeeNumber.Click += btnGenerateEmployeeNumber_Click;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Anchor = AnchorStyles.None;
            tbxFirstName.Location = new Point(66, 227);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.PlaceholderText = "  FIRST NAME";
            tbxFirstName.Size = new Size(538, 33);
            tbxFirstName.TabIndex = 28;
            // 
            // rbtnMale
            // 
            rbtnMale.Anchor = AnchorStyles.None;
            rbtnMale.AutoSize = true;
            rbtnMale.Cursor = Cursors.Hand;
            rbtnMale.Location = new Point(156, 338);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(55, 29);
            rbtnMale.TabIndex = 30;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "M";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // tbxAddressLine1
            // 
            tbxAddressLine1.Anchor = AnchorStyles.None;
            tbxAddressLine1.Location = new Point(66, 372);
            tbxAddressLine1.Multiline = true;
            tbxAddressLine1.Name = "tbxAddressLine1";
            tbxAddressLine1.PlaceholderText = "  ADDRESS LINE 1";
            tbxAddressLine1.Size = new Size(538, 33);
            tbxAddressLine1.TabIndex = 32;
            // 
            // tbxEmployeeNumber
            // 
            tbxEmployeeNumber.Anchor = AnchorStyles.None;
            tbxEmployeeNumber.Location = new Point(656, 227);
            tbxEmployeeNumber.MaxLength = 8;
            tbxEmployeeNumber.Name = "tbxEmployeeNumber";
            tbxEmployeeNumber.PlaceholderText = "  EMPLOYEE NUMBER";
            tbxEmployeeNumber.ReadOnly = true;
            tbxEmployeeNumber.Size = new Size(538, 33);
            tbxEmployeeNumber.TabIndex = 39;
            tbxEmployeeNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxDepartment
            // 
            cbxDepartment.Anchor = AnchorStyles.None;
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.Items.AddRange(new object[] { "Barber/Hairdresser", "Cleaning and Maintenance", "Intern", "IT and Helpdesk", "Management" });
            cbxDepartment.Location = new Point(656, 266);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(538, 33);
            cbxDepartment.TabIndex = 41;
            cbxDepartment.Text = "  DEPARTMENT";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatStyle = FlatStyle.System;
            btnSubmit.Location = new Point(66, 493);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(538, 75);
            btnSubmit.TabIndex = 36;
            btnSubmit.Text = "SUBMIT DETAILS";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxPostCode
            // 
            tbxPostCode.Anchor = AnchorStyles.None;
            tbxPostCode.Location = new Point(373, 450);
            tbxPostCode.MaxLength = 8;
            tbxPostCode.Name = "tbxPostCode";
            tbxPostCode.PlaceholderText = "  POST CODE";
            tbxPostCode.Size = new Size(231, 33);
            tbxPostCode.TabIndex = 35;
            tbxPostCode.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxAddressLine2
            // 
            tbxAddressLine2.Anchor = AnchorStyles.None;
            tbxAddressLine2.Location = new Point(66, 411);
            tbxAddressLine2.Multiline = true;
            tbxAddressLine2.Name = "tbxAddressLine2";
            tbxAddressLine2.PlaceholderText = "  ADDRESS LINE 2";
            tbxAddressLine2.Size = new Size(538, 33);
            tbxAddressLine2.TabIndex = 33;
            // 
            // rbtnFemale
            // 
            rbtnFemale.Anchor = AnchorStyles.None;
            rbtnFemale.AutoSize = true;
            rbtnFemale.Cursor = Cursors.Hand;
            rbtnFemale.Location = new Point(218, 338);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(46, 29);
            rbtnFemale.TabIndex = 31;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "F";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // cbxCounty
            // 
            cbxCounty.Anchor = AnchorStyles.None;
            cbxCounty.FormattingEnabled = true;
            cbxCounty.Items.AddRange(new object[] { "Bath and North East Somerset", "Bedfordshire", "Berkshire", "Bristol", "Buckinghamshire", "Cambridgeshire", "Cheshire", "Cornwall", "County Durham", "Cumbria", "Derbyshire", "Devon", "Dorset", "East Riding of Yorkshire", "East Sussex", "Essex", "Gloucestershire", "Greater London", "Greater Manchester", "Hampshire", "Herefordshire", "Hertfordshire", "Isle of Wight", "Isles of Scilly", "Kent", "Lancashire", "Leicestershire", "Lincolnshire", "Merseyside", "Norfolk", "North Somerset", "North Yorkshire", "Northamptonshire", "Northumberland", "Nottinghamshire", "Oxfordshire", "Rutland", "Shropshire", "Somerset", "South Gloucestershire", "South Yorkshire", "Staffordshire", "Suffolk", "Surrey", "Tyne & Wear", "Warwickshire", "West Midlands", "West Sussex", "West Yorkshire", "Wiltshire", "Worcestershire" });
            cbxCounty.Location = new Point(66, 450);
            cbxCounty.Name = "cbxCounty";
            cbxCounty.Size = new Size(293, 33);
            cbxCounty.TabIndex = 34;
            cbxCounty.Text = "  COUNTY";
            // 
            // tbxLastName
            // 
            tbxLastName.Anchor = AnchorStyles.None;
            tbxLastName.Location = new Point(66, 266);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PlaceholderText = "  LAST NAME";
            tbxLastName.Size = new Size(538, 33);
            tbxLastName.TabIndex = 29;
            // 
            // Setup
            // 
            AutoScaleDimensions = new SizeF(16F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlContainer);
            Font = new Font("EurostileLTW03-Extended2", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 5, 7, 5);
            MinimumSize = new Size(1280, 720);
            Name = "Setup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hairology - Setup";
            FormClosing += Setup_FormClosing;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlTraining.ResumeLayout(false);
            pnlTraining.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Label lblSubtitle;
        private Panel pnlContainer;
        private Label lblSex;
        private TextBox tbxConfirmPassword;
        private Label lblDOB;
        private TextBox tbxPassword;
        private DateTimePicker dtpDateOfBirth;
        private TextBox tbxUsername;
        private Button btnGenerateEmployeeNumber;
        private RadioButton rbtnTrainingCompletedNo;
        private TextBox tbxFirstName;
        private RadioButton rbtnTrainingCompletedYes;
        private RadioButton rbtnMale;
        private Label lblCompletedTraining;
        private TextBox tbxAddressLine1;
        private TextBox tbxEmployeeNumber;
        private ComboBox cbxDepartment;
        private Button btnSubmit;
        private TextBox tbxPostCode;
        private TextBox tbxAddressLine2;
        private RadioButton rbtnFemale;
        private ComboBox cbxCounty;
        private TextBox tbxLastName;
        private Panel pnlTraining;
    }
}