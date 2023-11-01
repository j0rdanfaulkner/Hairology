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
            components = new System.ComponentModel.Container();
            pnlContainer = new Panel();
            pnlEmployee = new Panel();
            pbxUsernameOK = new PictureBox();
            pnlAdminRights = new Panel();
            lblAdminRights = new Label();
            rbtnAdminRightsYes = new RadioButton();
            rbtnAdminRightsNo = new RadioButton();
            tbxConfirmPassword = new TextBox();
            tbxPassword = new TextBox();
            tbxUsername = new TextBox();
            btnGenerateEmployeeNumber = new Button();
            rbtnTrainingCompletedNo = new RadioButton();
            rbtnTrainingCompletedYes = new RadioButton();
            lblCompletedTraining = new Label();
            tbxEmployeeNumber = new TextBox();
            cbxDepartment = new ComboBox();
            pnlPersonal = new Panel();
            lblSex = new Label();
            lblDOB = new Label();
            dtpDateOfBirth = new DateTimePicker();
            cbxRegularCustomer = new CheckBox();
            tbxFirstName = new TextBox();
            rbtnMale = new RadioButton();
            btnSubmit = new Button();
            tbxAddressLine2 = new TextBox();
            cbxCounty = new ComboBox();
            tbxLastName = new TextBox();
            rbtnFemale = new RadioButton();
            tbxPostCode = new TextBox();
            tbxAddressLine1 = new TextBox();
            lblAddNewPerson = new Label();
            ttpUsernameOK = new ToolTip(components);
            pnlContainer.SuspendLayout();
            pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsernameOK).BeginInit();
            pnlAdminRights.SuspendLayout();
            pnlPersonal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = SystemColors.ActiveCaption;
            pnlContainer.Controls.Add(pnlEmployee);
            pnlContainer.Controls.Add(pnlPersonal);
            pnlContainer.Controls.Add(lblAddNewPerson);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Font = new Font("EurostileLTW03-Extended2", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 449);
            pnlContainer.TabIndex = 0;
            // 
            // pnlEmployee
            // 
            pnlEmployee.Anchor = AnchorStyles.None;
            pnlEmployee.Controls.Add(pbxUsernameOK);
            pnlEmployee.Controls.Add(pnlAdminRights);
            pnlEmployee.Controls.Add(tbxConfirmPassword);
            pnlEmployee.Controls.Add(tbxPassword);
            pnlEmployee.Controls.Add(tbxUsername);
            pnlEmployee.Controls.Add(btnGenerateEmployeeNumber);
            pnlEmployee.Controls.Add(rbtnTrainingCompletedNo);
            pnlEmployee.Controls.Add(rbtnTrainingCompletedYes);
            pnlEmployee.Controls.Add(lblCompletedTraining);
            pnlEmployee.Controls.Add(tbxEmployeeNumber);
            pnlEmployee.Controls.Add(cbxDepartment);
            pnlEmployee.Location = new Point(575, 0);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(689, 449);
            pnlEmployee.TabIndex = 14;
            // 
            // pbxUsernameOK
            // 
            pbxUsernameOK.Anchor = AnchorStyles.None;
            pbxUsernameOK.BackgroundImageLayout = ImageLayout.Zoom;
            pbxUsernameOK.Location = new Point(608, 291);
            pbxUsernameOK.Name = "pbxUsernameOK";
            pbxUsernameOK.Size = new Size(33, 33);
            pbxUsernameOK.TabIndex = 27;
            pbxUsernameOK.TabStop = false;
            // 
            // pnlAdminRights
            // 
            pnlAdminRights.Anchor = AnchorStyles.None;
            pnlAdminRights.Controls.Add(lblAdminRights);
            pnlAdminRights.Controls.Add(rbtnAdminRightsYes);
            pnlAdminRights.Controls.Add(rbtnAdminRightsNo);
            pnlAdminRights.Location = new Point(131, 177);
            pnlAdminRights.Name = "pnlAdminRights";
            pnlAdminRights.Size = new Size(473, 33);
            pnlAdminRights.TabIndex = 26;
            // 
            // lblAdminRights
            // 
            lblAdminRights.Anchor = AnchorStyles.None;
            lblAdminRights.AutoSize = true;
            lblAdminRights.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminRights.Location = new Point(42, 0);
            lblAdminRights.Name = "lblAdminRights";
            lblAdminRights.Size = new Size(228, 28);
            lblAdminRights.TabIndex = 28;
            lblAdminRights.Text = "Admin Rights?";
            // 
            // rbtnAdminRightsYes
            // 
            rbtnAdminRightsYes.Anchor = AnchorStyles.None;
            rbtnAdminRightsYes.AutoSize = true;
            rbtnAdminRightsYes.Cursor = Cursors.Hand;
            rbtnAdminRightsYes.Location = new Point(290, 1);
            rbtnAdminRightsYes.Name = "rbtnAdminRightsYes";
            rbtnAdminRightsYes.Size = new Size(86, 29);
            rbtnAdminRightsYes.TabIndex = 20;
            rbtnAdminRightsYes.TabStop = true;
            rbtnAdminRightsYes.Text = "YES";
            rbtnAdminRightsYes.UseVisualStyleBackColor = true;
            // 
            // rbtnAdminRightsNo
            // 
            rbtnAdminRightsNo.Anchor = AnchorStyles.None;
            rbtnAdminRightsNo.AutoSize = true;
            rbtnAdminRightsNo.Cursor = Cursors.Hand;
            rbtnAdminRightsNo.Location = new Point(400, 1);
            rbtnAdminRightsNo.Name = "rbtnAdminRightsNo";
            rbtnAdminRightsNo.Size = new Size(74, 29);
            rbtnAdminRightsNo.TabIndex = 21;
            rbtnAdminRightsNo.TabStop = true;
            rbtnAdminRightsNo.Text = "NO";
            rbtnAdminRightsNo.UseVisualStyleBackColor = true;
            // 
            // tbxConfirmPassword
            // 
            tbxConfirmPassword.Anchor = AnchorStyles.None;
            tbxConfirmPassword.Location = new Point(64, 369);
            tbxConfirmPassword.MaxLength = 256;
            tbxConfirmPassword.Name = "tbxConfirmPassword";
            tbxConfirmPassword.PlaceholderText = "  CONFIRM PASSWORD";
            tbxConfirmPassword.Size = new Size(538, 33);
            tbxConfirmPassword.TabIndex = 24;
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.None;
            tbxPassword.Location = new Point(64, 330);
            tbxPassword.MaxLength = 256;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PlaceholderText = "  PASSWORD";
            tbxPassword.Size = new Size(538, 33);
            tbxPassword.TabIndex = 23;
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = AnchorStyles.None;
            tbxUsername.Location = new Point(64, 291);
            tbxUsername.MaxLength = 256;
            tbxUsername.Name = "tbxUsername";
            tbxUsername.PlaceholderText = "  USERNAME";
            tbxUsername.Size = new Size(538, 33);
            tbxUsername.TabIndex = 22;
            tbxUsername.TextChanged += tbxUsername_TextChanged;
            // 
            // btnGenerateEmployeeNumber
            // 
            btnGenerateEmployeeNumber.Anchor = AnchorStyles.None;
            btnGenerateEmployeeNumber.Cursor = Cursors.Hand;
            btnGenerateEmployeeNumber.FlatStyle = FlatStyle.System;
            btnGenerateEmployeeNumber.Location = new Point(64, 218);
            btnGenerateEmployeeNumber.Name = "btnGenerateEmployeeNumber";
            btnGenerateEmployeeNumber.Size = new Size(538, 60);
            btnGenerateEmployeeNumber.TabIndex = 14;
            btnGenerateEmployeeNumber.Text = "GENERATE EMPLOYEE NUMBER";
            btnGenerateEmployeeNumber.UseVisualStyleBackColor = true;
            btnGenerateEmployeeNumber.Click += btnGenerateEmployeeNumber_Click;
            // 
            // rbtnTrainingCompletedNo
            // 
            rbtnTrainingCompletedNo.Anchor = AnchorStyles.None;
            rbtnTrainingCompletedNo.AutoSize = true;
            rbtnTrainingCompletedNo.Cursor = Cursors.Hand;
            rbtnTrainingCompletedNo.Location = new Point(531, 140);
            rbtnTrainingCompletedNo.Name = "rbtnTrainingCompletedNo";
            rbtnTrainingCompletedNo.Size = new Size(74, 29);
            rbtnTrainingCompletedNo.TabIndex = 18;
            rbtnTrainingCompletedNo.TabStop = true;
            rbtnTrainingCompletedNo.Text = "NO";
            rbtnTrainingCompletedNo.UseVisualStyleBackColor = true;
            // 
            // rbtnTrainingCompletedYes
            // 
            rbtnTrainingCompletedYes.Anchor = AnchorStyles.None;
            rbtnTrainingCompletedYes.AutoSize = true;
            rbtnTrainingCompletedYes.Cursor = Cursors.Hand;
            rbtnTrainingCompletedYes.Location = new Point(421, 140);
            rbtnTrainingCompletedYes.Name = "rbtnTrainingCompletedYes";
            rbtnTrainingCompletedYes.Size = new Size(86, 29);
            rbtnTrainingCompletedYes.TabIndex = 17;
            rbtnTrainingCompletedYes.TabStop = true;
            rbtnTrainingCompletedYes.Text = "YES";
            rbtnTrainingCompletedYes.UseVisualStyleBackColor = true;
            // 
            // lblCompletedTraining
            // 
            lblCompletedTraining.Anchor = AnchorStyles.None;
            lblCompletedTraining.AutoSize = true;
            lblCompletedTraining.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompletedTraining.Location = new Point(87, 140);
            lblCompletedTraining.Name = "lblCompletedTraining";
            lblCompletedTraining.Size = new Size(314, 28);
            lblCompletedTraining.TabIndex = 16;
            lblCompletedTraining.Text = "Completed Training?";
            // 
            // tbxEmployeeNumber
            // 
            tbxEmployeeNumber.Anchor = AnchorStyles.None;
            tbxEmployeeNumber.Location = new Point(64, 62);
            tbxEmployeeNumber.MaxLength = 8;
            tbxEmployeeNumber.Name = "tbxEmployeeNumber";
            tbxEmployeeNumber.PlaceholderText = "  EMPLOYEE NUMBER";
            tbxEmployeeNumber.ReadOnly = true;
            tbxEmployeeNumber.Size = new Size(538, 33);
            tbxEmployeeNumber.TabIndex = 14;
            tbxEmployeeNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxDepartment
            // 
            cbxDepartment.Anchor = AnchorStyles.None;
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.Items.AddRange(new object[] { "Barber/Hairdresser", "Cleaning and Maintenance", "Intern", "IT and Helpdesk", "Management" });
            cbxDepartment.Location = new Point(64, 101);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(538, 33);
            cbxDepartment.TabIndex = 15;
            cbxDepartment.Text = "  DEPARTMENT";
            // 
            // pnlPersonal
            // 
            pnlPersonal.Anchor = AnchorStyles.None;
            pnlPersonal.Controls.Add(lblSex);
            pnlPersonal.Controls.Add(lblDOB);
            pnlPersonal.Controls.Add(dtpDateOfBirth);
            pnlPersonal.Controls.Add(cbxRegularCustomer);
            pnlPersonal.Controls.Add(tbxFirstName);
            pnlPersonal.Controls.Add(rbtnMale);
            pnlPersonal.Controls.Add(btnSubmit);
            pnlPersonal.Controls.Add(tbxAddressLine2);
            pnlPersonal.Controls.Add(cbxCounty);
            pnlPersonal.Controls.Add(tbxLastName);
            pnlPersonal.Controls.Add(rbtnFemale);
            pnlPersonal.Controls.Add(tbxPostCode);
            pnlPersonal.Controls.Add(tbxAddressLine1);
            pnlPersonal.Location = new Point(0, 53);
            pnlPersonal.Name = "pnlPersonal";
            pnlPersonal.Size = new Size(580, 396);
            pnlPersonal.TabIndex = 13;
            // 
            // lblSex
            // 
            lblSex.Anchor = AnchorStyles.None;
            lblSex.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSex.Location = new Point(3, 120);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(106, 28);
            lblSex.TabIndex = 16;
            lblSex.Text = "Sex:";
            lblSex.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDOB
            // 
            lblDOB.Anchor = AnchorStyles.None;
            lblDOB.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.Location = new Point(3, 89);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(106, 28);
            lblDOB.TabIndex = 15;
            lblDOB.Text = "DOB:";
            lblDOB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.None;
            dtpDateOfBirth.Location = new Point(110, 86);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(448, 33);
            dtpDateOfBirth.TabIndex = 14;
            // 
            // cbxRegularCustomer
            // 
            cbxRegularCustomer.Anchor = AnchorStyles.None;
            cbxRegularCustomer.CheckAlign = ContentAlignment.MiddleRight;
            cbxRegularCustomer.Cursor = Cursors.Hand;
            cbxRegularCustomer.Location = new Point(225, 119);
            cbxRegularCustomer.Name = "cbxRegularCustomer";
            cbxRegularCustomer.Size = new Size(333, 31);
            cbxRegularCustomer.TabIndex = 13;
            cbxRegularCustomer.Text = "Regular Customer?";
            cbxRegularCustomer.UseVisualStyleBackColor = true;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Anchor = AnchorStyles.None;
            tbxFirstName.Location = new Point(20, 8);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.PlaceholderText = "  FIRST NAME";
            tbxFirstName.Size = new Size(538, 33);
            tbxFirstName.TabIndex = 1;
            // 
            // rbtnMale
            // 
            rbtnMale.Anchor = AnchorStyles.None;
            rbtnMale.AutoSize = true;
            rbtnMale.Cursor = Cursors.Hand;
            rbtnMale.Location = new Point(110, 119);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(56, 29);
            rbtnMale.TabIndex = 4;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "M";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatStyle = FlatStyle.System;
            btnSubmit.Location = new Point(20, 274);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(538, 75);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "SUBMIT DETAILS";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxAddressLine2
            // 
            tbxAddressLine2.Anchor = AnchorStyles.None;
            tbxAddressLine2.Location = new Point(20, 192);
            tbxAddressLine2.Multiline = true;
            tbxAddressLine2.Name = "tbxAddressLine2";
            tbxAddressLine2.PlaceholderText = "  ADDRESS LINE 2";
            tbxAddressLine2.Size = new Size(538, 33);
            tbxAddressLine2.TabIndex = 7;
            // 
            // cbxCounty
            // 
            cbxCounty.Anchor = AnchorStyles.None;
            cbxCounty.FormattingEnabled = true;
            cbxCounty.Items.AddRange(new object[] { "Bath and North East Somerset", "Bedfordshire", "Berkshire", "Bristol", "Buckinghamshire", "Cambridgeshire", "Cheshire", "Cornwall", "County Durham", "Cumbria", "Derbyshire", "Devon", "Dorset", "East Riding of Yorkshire", "East Sussex", "Essex", "Gloucestershire", "Greater London", "Greater Manchester", "Hampshire", "Herefordshire", "Hertfordshire", "Isle of Wight", "Isles of Scilly", "Kent", "Lancashire", "Leicestershire", "Lincolnshire", "Merseyside", "Norfolk", "North Somerset", "North Yorkshire", "Northamptonshire", "Northumberland", "Nottinghamshire", "Oxfordshire", "Rutland", "Shropshire", "Somerset", "South Gloucestershire", "South Yorkshire", "Staffordshire", "Suffolk", "Surrey", "Tyne & Wear", "Warwickshire", "West Midlands", "West Sussex", "West Yorkshire", "Wiltshire", "Worcestershire" });
            cbxCounty.Location = new Point(20, 231);
            cbxCounty.Name = "cbxCounty";
            cbxCounty.Size = new Size(293, 33);
            cbxCounty.TabIndex = 8;
            cbxCounty.Text = "  COUNTY";
            // 
            // tbxLastName
            // 
            tbxLastName.Anchor = AnchorStyles.None;
            tbxLastName.Location = new Point(20, 47);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PlaceholderText = "  LAST NAME";
            tbxLastName.Size = new Size(538, 33);
            tbxLastName.TabIndex = 2;
            // 
            // rbtnFemale
            // 
            rbtnFemale.Anchor = AnchorStyles.None;
            rbtnFemale.AutoSize = true;
            rbtnFemale.Cursor = Cursors.Hand;
            rbtnFemale.Location = new Point(172, 119);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(47, 29);
            rbtnFemale.TabIndex = 5;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "F";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // tbxPostCode
            // 
            tbxPostCode.Anchor = AnchorStyles.None;
            tbxPostCode.Location = new Point(327, 231);
            tbxPostCode.MaxLength = 8;
            tbxPostCode.Name = "tbxPostCode";
            tbxPostCode.PlaceholderText = "  POST CODE";
            tbxPostCode.Size = new Size(231, 33);
            tbxPostCode.TabIndex = 9;
            tbxPostCode.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxAddressLine1
            // 
            tbxAddressLine1.Anchor = AnchorStyles.None;
            tbxAddressLine1.Location = new Point(20, 153);
            tbxAddressLine1.Multiline = true;
            tbxAddressLine1.Name = "tbxAddressLine1";
            tbxAddressLine1.PlaceholderText = "  ADDRESS LINE 1";
            tbxAddressLine1.Size = new Size(538, 33);
            tbxAddressLine1.TabIndex = 6;
            // 
            // lblAddNewPerson
            // 
            lblAddNewPerson.AutoSize = true;
            lblAddNewPerson.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddNewPerson.Location = new Point(15, 15);
            lblAddNewPerson.Name = "lblAddNewPerson";
            lblAddNewPerson.Size = new Size(306, 28);
            lblAddNewPerson.TabIndex = 12;
            lblAddNewPerson.Text = "Add New [PERSON]";
            // 
            // ttpUsernameOK
            // 
            ttpUsernameOK.AutoPopDelay = 5000;
            ttpUsernameOK.InitialDelay = 0;
            ttpUsernameOK.ReshowDelay = 100;
            // 
            // AddNewPerson
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlContainer);
            Name = "AddNewPerson";
            Size = new Size(1264, 449);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlEmployee.ResumeLayout(false);
            pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsernameOK).EndInit();
            pnlAdminRights.ResumeLayout(false);
            pnlAdminRights.PerformLayout();
            pnlPersonal.ResumeLayout(false);
            pnlPersonal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlEmployee;
        private Button btnGenerateEmployeeNumber;
        private RadioButton rbtnAdminRightsNo;
        private RadioButton rbtnAdminRightsYes;
        private RadioButton rbtnTrainingCompletedNo;
        private RadioButton rbtnTrainingCompletedYes;
        private Label lblCompletedTraining;
        private TextBox tbxEmployeeNumber;
        private ComboBox cbxDepartment;
        private TextBox tbxConfirmPassword;
        private TextBox tbxPassword;
        private TextBox tbxUsername;
        private Panel pnlAdminRights;
        private PictureBox pbxUsernameOK;
        private ToolTip ttpUsernameOK;
        private Label lblAdminRights;
        private Panel pnlPersonal;
        private Label lblSex;
        private Label lblDOB;
        private DateTimePicker dtpDateOfBirth;
        private CheckBox cbxRegularCustomer;
        private TextBox tbxFirstName;
        private Label lblAddNewPerson;
        private RadioButton rbtnMale;
        private Button btnSubmit;
        private TextBox tbxAddressLine2;
        private ComboBox cbxCounty;
        private TextBox tbxLastName;
        private RadioButton rbtnFemale;
        private TextBox tbxPostCode;
        private TextBox tbxAddressLine1;
    }
}
