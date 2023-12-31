﻿namespace Hairology
{
    partial class EditPerson
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
            panel1 = new Panel();
            btnDiscardChanges = new Button();
            btnDelete = new Button();
            lblSex = new Label();
            lblDOB = new Label();
            dtpDateOfBirth = new DateTimePicker();
            cbxRegularCustomer = new CheckBox();
            tbxFirstName = new TextBox();
            lbllEditPerson = new Label();
            rbtnMale = new RadioButton();
            btnSubmit = new Button();
            tbxAddressLine2 = new TextBox();
            cbxCounty = new ComboBox();
            tbxLastName = new TextBox();
            rbtnFemale = new RadioButton();
            tbxPostCode = new TextBox();
            tbxAddressLine1 = new TextBox();
            ttpUsernameOK = new ToolTip(components);
            pnlContainer.SuspendLayout();
            pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsernameOK).BeginInit();
            pnlAdminRights.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = SystemColors.ActiveCaption;
            pnlContainer.Controls.Add(pnlEmployee);
            pnlContainer.Controls.Add(panel1);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
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
            pnlEmployee.Location = new Point(586, 0);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(678, 449);
            pnlEmployee.TabIndex = 14;
            // 
            // pbxUsernameOK
            // 
            pbxUsernameOK.Anchor = AnchorStyles.None;
            pbxUsernameOK.BackgroundImageLayout = ImageLayout.Zoom;
            pbxUsernameOK.Location = new Point(627, 296);
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
            pnlAdminRights.Location = new Point(150, 182);
            pnlAdminRights.Name = "pnlAdminRights";
            pnlAdminRights.Size = new Size(473, 33);
            pnlAdminRights.TabIndex = 26;
            // 
            // lblAdminRights
            // 
            lblAdminRights.Anchor = AnchorStyles.Top;
            lblAdminRights.AutoSize = true;
            lblAdminRights.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminRights.Location = new Point(45, 0);
            lblAdminRights.Name = "lblAdminRights";
            lblAdminRights.Size = new Size(164, 25);
            lblAdminRights.TabIndex = 28;
            lblAdminRights.Text = "Admin Rights?";
            // 
            // rbtnAdminRightsYes
            // 
            rbtnAdminRightsYes.Anchor = AnchorStyles.Top;
            rbtnAdminRightsYes.AutoSize = true;
            rbtnAdminRightsYes.Cursor = Cursors.Hand;
            rbtnAdminRightsYes.Location = new Point(290, -3);
            rbtnAdminRightsYes.Name = "rbtnAdminRightsYes";
            rbtnAdminRightsYes.Size = new Size(68, 28);
            rbtnAdminRightsYes.TabIndex = 20;
            rbtnAdminRightsYes.TabStop = true;
            rbtnAdminRightsYes.Text = "YES";
            rbtnAdminRightsYes.UseVisualStyleBackColor = true;
            // 
            // rbtnAdminRightsNo
            // 
            rbtnAdminRightsNo.Anchor = AnchorStyles.Top;
            rbtnAdminRightsNo.AutoSize = true;
            rbtnAdminRightsNo.Cursor = Cursors.Hand;
            rbtnAdminRightsNo.Location = new Point(400, -3);
            rbtnAdminRightsNo.Name = "rbtnAdminRightsNo";
            rbtnAdminRightsNo.Size = new Size(59, 28);
            rbtnAdminRightsNo.TabIndex = 21;
            rbtnAdminRightsNo.TabStop = true;
            rbtnAdminRightsNo.Text = "NO";
            rbtnAdminRightsNo.UseVisualStyleBackColor = true;
            // 
            // tbxConfirmPassword
            // 
            tbxConfirmPassword.Anchor = AnchorStyles.None;
            tbxConfirmPassword.Location = new Point(83, 374);
            tbxConfirmPassword.MaxLength = 256;
            tbxConfirmPassword.Name = "tbxConfirmPassword";
            tbxConfirmPassword.PlaceholderText = "  CONFIRM PASSWORD";
            tbxConfirmPassword.Size = new Size(538, 29);
            tbxConfirmPassword.TabIndex = 24;
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.None;
            tbxPassword.Location = new Point(83, 335);
            tbxPassword.MaxLength = 256;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PlaceholderText = "  PASSWORD";
            tbxPassword.Size = new Size(538, 29);
            tbxPassword.TabIndex = 23;
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = AnchorStyles.None;
            tbxUsername.Location = new Point(83, 296);
            tbxUsername.MaxLength = 256;
            tbxUsername.Name = "tbxUsername";
            tbxUsername.PlaceholderText = "  USERNAME";
            tbxUsername.Size = new Size(538, 29);
            tbxUsername.TabIndex = 22;
            // 
            // btnGenerateEmployeeNumber
            // 
            btnGenerateEmployeeNumber.Anchor = AnchorStyles.None;
            btnGenerateEmployeeNumber.Cursor = Cursors.Hand;
            btnGenerateEmployeeNumber.FlatStyle = FlatStyle.System;
            btnGenerateEmployeeNumber.Location = new Point(83, 223);
            btnGenerateEmployeeNumber.Name = "btnGenerateEmployeeNumber";
            btnGenerateEmployeeNumber.Size = new Size(538, 60);
            btnGenerateEmployeeNumber.TabIndex = 14;
            btnGenerateEmployeeNumber.Text = "GENERATE EMPLOYEE NUMBER";
            btnGenerateEmployeeNumber.UseVisualStyleBackColor = true;
            // 
            // rbtnTrainingCompletedNo
            // 
            rbtnTrainingCompletedNo.Anchor = AnchorStyles.None;
            rbtnTrainingCompletedNo.AutoSize = true;
            rbtnTrainingCompletedNo.Cursor = Cursors.Hand;
            rbtnTrainingCompletedNo.Location = new Point(550, 145);
            rbtnTrainingCompletedNo.Name = "rbtnTrainingCompletedNo";
            rbtnTrainingCompletedNo.Size = new Size(59, 28);
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
            rbtnTrainingCompletedYes.Location = new Point(440, 145);
            rbtnTrainingCompletedYes.Name = "rbtnTrainingCompletedYes";
            rbtnTrainingCompletedYes.Size = new Size(68, 28);
            rbtnTrainingCompletedYes.TabIndex = 17;
            rbtnTrainingCompletedYes.TabStop = true;
            rbtnTrainingCompletedYes.Text = "YES";
            rbtnTrainingCompletedYes.UseVisualStyleBackColor = true;
            // 
            // lblCompletedTraining
            // 
            lblCompletedTraining.Anchor = AnchorStyles.None;
            lblCompletedTraining.AutoSize = true;
            lblCompletedTraining.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompletedTraining.Location = new Point(109, 146);
            lblCompletedTraining.Name = "lblCompletedTraining";
            lblCompletedTraining.Size = new Size(230, 25);
            lblCompletedTraining.TabIndex = 16;
            lblCompletedTraining.Text = "Completed Training?";
            // 
            // tbxEmployeeNumber
            // 
            tbxEmployeeNumber.Anchor = AnchorStyles.None;
            tbxEmployeeNumber.Location = new Point(83, 67);
            tbxEmployeeNumber.MaxLength = 8;
            tbxEmployeeNumber.Name = "tbxEmployeeNumber";
            tbxEmployeeNumber.PlaceholderText = "  EMPLOYEE NUMBER";
            tbxEmployeeNumber.ReadOnly = true;
            tbxEmployeeNumber.Size = new Size(538, 29);
            tbxEmployeeNumber.TabIndex = 14;
            tbxEmployeeNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxDepartment
            // 
            cbxDepartment.Anchor = AnchorStyles.None;
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.Items.AddRange(new object[] { "Barber/Hairdresser", "Cleaning and Maintenance", "Intern", "IT and Helpdesk", "Management" });
            cbxDepartment.Location = new Point(83, 106);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(538, 32);
            cbxDepartment.TabIndex = 15;
            cbxDepartment.Text = "  DEPARTMENT";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnDiscardChanges);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(lblSex);
            panel1.Controls.Add(lblDOB);
            panel1.Controls.Add(dtpDateOfBirth);
            panel1.Controls.Add(cbxRegularCustomer);
            panel1.Controls.Add(tbxFirstName);
            panel1.Controls.Add(lbllEditPerson);
            panel1.Controls.Add(rbtnMale);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(tbxAddressLine2);
            panel1.Controls.Add(cbxCounty);
            panel1.Controls.Add(tbxLastName);
            panel1.Controls.Add(rbtnFemale);
            panel1.Controls.Add(tbxPostCode);
            panel1.Controls.Add(tbxAddressLine1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 449);
            panel1.TabIndex = 13;
            // 
            // btnDiscardChanges
            // 
            btnDiscardChanges.Anchor = AnchorStyles.Top;
            btnDiscardChanges.BackColor = SystemColors.ControlLightLight;
            btnDiscardChanges.BackgroundImage = Properties.Resources.notok;
            btnDiscardChanges.BackgroundImageLayout = ImageLayout.Zoom;
            btnDiscardChanges.Cursor = Cursors.Hand;
            btnDiscardChanges.Location = new Point(171, 347);
            btnDiscardChanges.Name = "btnDiscardChanges";
            btnDiscardChanges.Size = new Size(146, 60);
            btnDiscardChanges.TabIndex = 18;
            btnDiscardChanges.UseVisualStyleBackColor = false;
            btnDiscardChanges.Click += btnDiscardChanges_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = SystemColors.ControlLightLight;
            btnDelete.BackgroundImage = Properties.Resources.bin;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(413, 347);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 60);
            btnDelete.TabIndex = 17;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSex.Location = new Point(27, 179);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(59, 25);
            lblSex.TabIndex = 16;
            lblSex.Text = "Sex:";
            // 
            // lblDOB
            // 
            lblDOB.Anchor = AnchorStyles.Top;
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.Location = new Point(12, 147);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(67, 25);
            lblDOB.TabIndex = 15;
            lblDOB.Text = "DOB:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.Top;
            dtpDateOfBirth.Location = new Point(109, 145);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(448, 29);
            dtpDateOfBirth.TabIndex = 14;
            // 
            // cbxRegularCustomer
            // 
            cbxRegularCustomer.Anchor = AnchorStyles.Top;
            cbxRegularCustomer.AutoSize = true;
            cbxRegularCustomer.Cursor = Cursors.Hand;
            cbxRegularCustomer.Location = new Point(273, 178);
            cbxRegularCustomer.Name = "cbxRegularCustomer";
            cbxRegularCustomer.Size = new Size(208, 28);
            cbxRegularCustomer.TabIndex = 13;
            cbxRegularCustomer.Text = "Regular Customer?";
            cbxRegularCustomer.UseVisualStyleBackColor = true;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Anchor = AnchorStyles.Top;
            tbxFirstName.Location = new Point(19, 67);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.PlaceholderText = "  FIRST NAME";
            tbxFirstName.Size = new Size(538, 29);
            tbxFirstName.TabIndex = 1;
            // 
            // lbllEditPerson
            // 
            lbllEditPerson.Anchor = AnchorStyles.Top;
            lbllEditPerson.AutoSize = true;
            lbllEditPerson.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbllEditPerson.Location = new Point(19, 15);
            lbllEditPerson.Name = "lbllEditPerson";
            lbllEditPerson.Size = new Size(168, 25);
            lbllEditPerson.TabIndex = 12;
            lbllEditPerson.Text = "Edit [PERSON]";
            // 
            // rbtnMale
            // 
            rbtnMale.Anchor = AnchorStyles.Top;
            rbtnMale.AutoSize = true;
            rbtnMale.Cursor = Cursors.Hand;
            rbtnMale.Location = new Point(109, 178);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(45, 28);
            rbtnMale.TabIndex = 4;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "M";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top;
            btnSubmit.BackColor = SystemColors.ControlLightLight;
            btnSubmit.BackgroundImage = Properties.Resources.save;
            btnSubmit.BackgroundImageLayout = ImageLayout.Zoom;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Location = new Point(19, 347);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(146, 60);
            btnSubmit.TabIndex = 10;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxAddressLine2
            // 
            tbxAddressLine2.Anchor = AnchorStyles.Top;
            tbxAddressLine2.Location = new Point(19, 251);
            tbxAddressLine2.Multiline = true;
            tbxAddressLine2.Name = "tbxAddressLine2";
            tbxAddressLine2.PlaceholderText = "  ADDRESS LINE 2";
            tbxAddressLine2.Size = new Size(538, 33);
            tbxAddressLine2.TabIndex = 7;
            // 
            // cbxCounty
            // 
            cbxCounty.Anchor = AnchorStyles.Top;
            cbxCounty.FormattingEnabled = true;
            cbxCounty.Items.AddRange(new object[] { "Bath and North East Somerset", "Bedfordshire", "Berkshire", "Bristol", "Buckinghamshire", "Cambridgeshire", "Cheshire", "Cornwall", "County Durham", "Cumbria", "Derbyshire", "Devon", "Dorset", "East Riding of Yorkshire", "East Sussex", "Essex", "Gloucestershire", "Greater London", "Greater Manchester", "Hampshire", "Herefordshire", "Hertfordshire", "Isle of Wight", "Isles of Scilly", "Kent", "Lancashire", "Leicestershire", "Lincolnshire", "Merseyside", "Norfolk", "North Somerset", "North Yorkshire", "Northamptonshire", "Northumberland", "Nottinghamshire", "Oxfordshire", "Rutland", "Shropshire", "Somerset", "South Gloucestershire", "South Yorkshire", "Staffordshire", "Suffolk", "Surrey", "Tyne & Wear", "Warwickshire", "West Midlands", "West Sussex", "West Yorkshire", "Wiltshire", "Worcestershire" });
            cbxCounty.Location = new Point(19, 290);
            cbxCounty.Name = "cbxCounty";
            cbxCounty.Size = new Size(293, 32);
            cbxCounty.TabIndex = 8;
            cbxCounty.Text = "  COUNTY";
            // 
            // tbxLastName
            // 
            tbxLastName.Anchor = AnchorStyles.Top;
            tbxLastName.Location = new Point(19, 106);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PlaceholderText = "  LAST NAME";
            tbxLastName.Size = new Size(538, 29);
            tbxLastName.TabIndex = 2;
            // 
            // rbtnFemale
            // 
            rbtnFemale.Anchor = AnchorStyles.Top;
            rbtnFemale.AutoSize = true;
            rbtnFemale.Cursor = Cursors.Hand;
            rbtnFemale.Location = new Point(171, 178);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(41, 28);
            rbtnFemale.TabIndex = 5;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "F";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // tbxPostCode
            // 
            tbxPostCode.Anchor = AnchorStyles.Top;
            tbxPostCode.Location = new Point(326, 290);
            tbxPostCode.MaxLength = 8;
            tbxPostCode.Name = "tbxPostCode";
            tbxPostCode.PlaceholderText = "  POST CODE";
            tbxPostCode.Size = new Size(231, 29);
            tbxPostCode.TabIndex = 9;
            tbxPostCode.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxAddressLine1
            // 
            tbxAddressLine1.Anchor = AnchorStyles.Top;
            tbxAddressLine1.Location = new Point(19, 212);
            tbxAddressLine1.Multiline = true;
            tbxAddressLine1.Name = "tbxAddressLine1";
            tbxAddressLine1.PlaceholderText = "  ADDRESS LINE 1";
            tbxAddressLine1.Size = new Size(538, 33);
            tbxAddressLine1.TabIndex = 6;
            // 
            // ttpUsernameOK
            // 
            ttpUsernameOK.AutoPopDelay = 5000;
            ttpUsernameOK.InitialDelay = 0;
            ttpUsernameOK.ReshowDelay = 100;
            // 
            // EditPerson
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlContainer);
            Name = "EditPerson";
            Size = new Size(1264, 449);
            pnlContainer.ResumeLayout(false);
            pnlEmployee.ResumeLayout(false);
            pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsernameOK).EndInit();
            pnlAdminRights.ResumeLayout(false);
            pnlAdminRights.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private TextBox tbxAddressLine1;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private TextBox tbxAddressLine2;
        private Label lbllEditPerson;
        private Button btnSubmit;
        private TextBox tbxPostCode;
        private ComboBox cbxCounty;
        private Panel panel1;
        private CheckBox cbxRegularCustomer;
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
        private DateTimePicker dtpDateOfBirth;
        private Label lblSex;
        private Label lblDOB;
        private Label lblAdminRights;
        private Button btnDelete;
        private Button btnDiscardChanges;
    }
}
