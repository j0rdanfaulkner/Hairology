namespace Hairology
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            lblWelcome = new Label();
            pnlContainer = new Panel();
            pnlBottom = new Panel();
            uscAddNewTransaction = new AddNewTransaction();
            uscSearch = new Search();
            uscAddNewPerson = new AddNewPerson();
            uscInventory = new Inventory();
            uscTransactions = new Transactions();
            uscSettings = new Settings();
            mstNavigationBar = new MenuStrip();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            newPersonToolStripMenuItem = new ToolStripMenuItem();
            addNewEmployeeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewCustomerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            newProductToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            newTransactionToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            searchEmployeesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            searchCustomersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            productsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            transactionsToolStripMenuItem1 = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            pnlTop = new Panel();
            lblDepartment = new Label();
            pbxAdminRights = new PictureBox();
            lblFullName = new Label();
            lblTime = new Label();
            lblDate = new Label();
            pbxLogo = new PictureBox();
            tmrTimer = new System.Windows.Forms.Timer(components);
            ttpInfo = new ToolTip(components);
            pnlContainer.SuspendLayout();
            pnlBottom.SuspendLayout();
            mstNavigationBar.SuspendLayout();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAdminRights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("EurostileLTW03-Extended2", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(318, 22);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(495, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [USERNAME]";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(pnlBottom);
            pnlContainer.Controls.Add(pnlTop);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 681);
            pnlContainer.TabIndex = 1;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(uscAddNewTransaction);
            pnlBottom.Controls.Add(uscSearch);
            pnlBottom.Controls.Add(uscAddNewPerson);
            pnlBottom.Controls.Add(uscInventory);
            pnlBottom.Controls.Add(uscTransactions);
            pnlBottom.Controls.Add(uscSettings);
            pnlBottom.Controls.Add(mstNavigationBar);
            pnlBottom.Dock = DockStyle.Fill;
            pnlBottom.Location = new Point(0, 192);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1264, 489);
            pnlBottom.TabIndex = 2;
            // 
            // uscAddNewTransaction
            // 
            uscAddNewTransaction.BackColor = SystemColors.ActiveCaption;
            uscAddNewTransaction.Dock = DockStyle.Fill;
            uscAddNewTransaction.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            uscAddNewTransaction.Location = new Point(0, 50);
            uscAddNewTransaction.Margin = new Padding(8, 6, 8, 6);
            uscAddNewTransaction.Name = "uscAddNewTransaction";
            uscAddNewTransaction.Size = new Size(1264, 439);
            uscAddNewTransaction.TabIndex = 6;
            // 
            // uscSearch
            // 
            uscSearch.Dock = DockStyle.Fill;
            uscSearch.Location = new Point(0, 50);
            uscSearch.Margin = new Padding(7, 5, 7, 5);
            uscSearch.Name = "uscSearch";
            uscSearch.Size = new Size(1264, 439);
            uscSearch.TabIndex = 5;
            // 
            // uscAddNewPerson
            // 
            uscAddNewPerson.Dock = DockStyle.Fill;
            uscAddNewPerson.Location = new Point(0, 50);
            uscAddNewPerson.Name = "uscAddNewPerson";
            uscAddNewPerson.Size = new Size(1264, 439);
            uscAddNewPerson.TabIndex = 4;
            // 
            // uscInventory
            // 
            uscInventory.Dock = DockStyle.Fill;
            uscInventory.Location = new Point(0, 50);
            uscInventory.Margin = new Padding(16, 8, 16, 8);
            uscInventory.Name = "uscInventory";
            uscInventory.Size = new Size(1264, 439);
            uscInventory.TabIndex = 3;
            // 
            // uscTransactions
            // 
            uscTransactions.Dock = DockStyle.Fill;
            uscTransactions.Location = new Point(0, 50);
            uscTransactions.Margin = new Padding(16, 8, 16, 8);
            uscTransactions.Name = "uscTransactions";
            uscTransactions.Size = new Size(1264, 439);
            uscTransactions.TabIndex = 2;
            // 
            // uscSettings
            // 
            uscSettings.BackColor = Color.Silver;
            uscSettings.Dock = DockStyle.Fill;
            uscSettings.Font = new Font("EurostileLTW03-Extended2", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uscSettings.Location = new Point(0, 50);
            uscSettings.Margin = new Padding(6, 4, 6, 4);
            uscSettings.Name = "uscSettings";
            uscSettings.Size = new Size(1264, 439);
            uscSettings.TabIndex = 1;
            // 
            // mstNavigationBar
            // 
            mstNavigationBar.AutoSize = false;
            mstNavigationBar.BackColor = Color.SteelBlue;
            mstNavigationBar.Font = new Font("EurostileLTW03-Extended2", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mstNavigationBar.ImageScalingSize = new Size(32, 32);
            mstNavigationBar.Items.AddRange(new ToolStripItem[] { AddNewToolStripMenuItem, searchToolStripMenuItem, logOutToolStripMenuItem, inventoryToolStripMenuItem, transactionsToolStripMenuItem, settingsToolStripMenuItem });
            mstNavigationBar.Location = new Point(0, 0);
            mstNavigationBar.Name = "mstNavigationBar";
            mstNavigationBar.RenderMode = ToolStripRenderMode.System;
            mstNavigationBar.Size = new Size(1264, 50);
            mstNavigationBar.TabIndex = 0;
            // 
            // AddNewToolStripMenuItem
            // 
            AddNewToolStripMenuItem.BackColor = Color.SteelBlue;
            AddNewToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            AddNewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newPersonToolStripMenuItem, toolStripSeparator3, newProductToolStripMenuItem, toolStripSeparator4, newTransactionToolStripMenuItem });
            AddNewToolStripMenuItem.Image = Properties.Resources.addnew;
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(99, 46);
            AddNewToolStripMenuItem.Text = "Add";
            // 
            // newPersonToolStripMenuItem
            // 
            newPersonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewEmployeeToolStripMenuItem, toolStripSeparator1, addNewCustomerToolStripMenuItem });
            newPersonToolStripMenuItem.Image = Properties.Resources.addnew;
            newPersonToolStripMenuItem.Name = "newPersonToolStripMenuItem";
            newPersonToolStripMenuItem.Size = new Size(287, 38);
            newPersonToolStripMenuItem.Text = "New Person";
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            addNewEmployeeToolStripMenuItem.Image = Properties.Resources.user;
            addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            addNewEmployeeToolStripMenuItem.Size = new Size(209, 38);
            addNewEmployeeToolStripMenuItem.Text = "Employee";
            addNewEmployeeToolStripMenuItem.Click += addNewEmployeeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(206, 6);
            // 
            // addNewCustomerToolStripMenuItem
            // 
            addNewCustomerToolStripMenuItem.Image = Properties.Resources.customer;
            addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            addNewCustomerToolStripMenuItem.Size = new Size(209, 38);
            addNewCustomerToolStripMenuItem.Text = "Customer";
            addNewCustomerToolStripMenuItem.Click += addNewCustomerToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(284, 6);
            // 
            // newProductToolStripMenuItem
            // 
            newProductToolStripMenuItem.Image = Properties.Resources.addnew;
            newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            newProductToolStripMenuItem.Size = new Size(287, 38);
            newProductToolStripMenuItem.Text = "New Product";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(284, 6);
            // 
            // newTransactionToolStripMenuItem
            // 
            newTransactionToolStripMenuItem.Image = Properties.Resources.addnew;
            newTransactionToolStripMenuItem.Name = "newTransactionToolStripMenuItem";
            newTransactionToolStripMenuItem.Size = new Size(287, 38);
            newTransactionToolStripMenuItem.Text = "New Transaction";
            newTransactionToolStripMenuItem.Click += newTransactionToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { peopleToolStripMenuItem, toolStripSeparator5, productsToolStripMenuItem, toolStripSeparator6, transactionsToolStripMenuItem1 });
            searchToolStripMenuItem.Image = Properties.Resources.search;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(135, 46);
            searchToolStripMenuItem.Text = "Search";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchEmployeesToolStripMenuItem, toolStripSeparator2, searchCustomersToolStripMenuItem });
            peopleToolStripMenuItem.Image = Properties.Resources.people;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(242, 38);
            peopleToolStripMenuItem.Text = "People";
            // 
            // searchEmployeesToolStripMenuItem
            // 
            searchEmployeesToolStripMenuItem.Image = Properties.Resources.searchemployees;
            searchEmployeesToolStripMenuItem.Name = "searchEmployeesToolStripMenuItem";
            searchEmployeesToolStripMenuItem.Size = new Size(222, 38);
            searchEmployeesToolStripMenuItem.Text = "Employees";
            searchEmployeesToolStripMenuItem.Click += searchEmployeesToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(219, 6);
            // 
            // searchCustomersToolStripMenuItem
            // 
            searchCustomersToolStripMenuItem.Image = Properties.Resources.searchcustomers;
            searchCustomersToolStripMenuItem.Name = "searchCustomersToolStripMenuItem";
            searchCustomersToolStripMenuItem.Size = new Size(222, 38);
            searchCustomersToolStripMenuItem.Text = "Customers";
            searchCustomersToolStripMenuItem.Click += searchCustomersToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(239, 6);
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Image = Properties.Resources.products;
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(242, 38);
            productsToolStripMenuItem.Text = "Products";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(239, 6);
            // 
            // transactionsToolStripMenuItem1
            // 
            transactionsToolStripMenuItem1.Image = Properties.Resources.invoice;
            transactionsToolStripMenuItem1.Name = "transactionsToolStripMenuItem1";
            transactionsToolStripMenuItem1.Size = new Size(242, 38);
            transactionsToolStripMenuItem1.Text = "Transactions";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            logOutToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            logOutToolStripMenuItem.Image = Properties.Resources.logout;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(146, 46);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Image = Properties.Resources.inventory;
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(160, 46);
            inventoryToolStripMenuItem.Text = "Inventory";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Image = Properties.Resources.invoice;
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(200, 46);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Image = Properties.Resources.settings;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(150, 46);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblDepartment);
            pnlTop.Controls.Add(pbxAdminRights);
            pnlTop.Controls.Add(lblFullName);
            pnlTop.Controls.Add(lblTime);
            pnlTop.Controls.Add(lblDate);
            pnlTop.Controls.Add(pbxLogo);
            pnlTop.Controls.Add(lblWelcome);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1264, 192);
            pnlTop.TabIndex = 1;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(327, 137);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(211, 25);
            lblDepartment.TabIndex = 5;
            lblDepartment.Text = "[DEPARTMENT]";
            lblDepartment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbxAdminRights
            // 
            pbxAdminRights.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxAdminRights.BackgroundImageLayout = ImageLayout.Zoom;
            pbxAdminRights.Location = new Point(1177, 101);
            pbxAdminRights.Name = "pbxAdminRights";
            pbxAdminRights.Size = new Size(75, 75);
            pbxAdminRights.TabIndex = 4;
            pbxAdminRights.TabStop = false;
            pbxAdminRights.MouseEnter += pbxAdminRights_MouseEnter;
            pbxAdminRights.MouseLeave += pbxAdminRights_MouseLeave;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("EurostileLTW03-Extended2", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullName.Location = new Point(327, 65);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(164, 21);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "([FULL NAME])";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(884, 60);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(368, 28);
            lblTime.TabIndex = 2;
            lblTime.Text = "[TIME]";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(884, 22);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.No;
            lblDate.Size = new Size(368, 28);
            lblDate.TabIndex = 1;
            lblDate.Text = "[DATE]";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbxLogo
            // 
            pbxLogo.BackgroundImage = Properties.Resources.logo;
            pbxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbxLogo.InitialImage = Properties.Resources.logo;
            pbxLogo.Location = new Point(12, 12);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(300, 150);
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // tmrTimer
            // 
            tmrTimer.Interval = 1000;
            tmrTimer.Tick += tmrTimer_Tick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(16F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlContainer);
            Font = new Font("EurostileLTW03-Extended2", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mstNavigationBar;
            Margin = new Padding(7, 5, 7, 5);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hairology";
            FormClosing += MainWindow_FormClosing;
            pnlContainer.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            mstNavigationBar.ResumeLayout(false);
            mstNavigationBar.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxAdminRights).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Panel pnlContainer;
        private Panel pnlTop;
        private Panel pnlBottom;
        private MenuStrip mstNavigationBar;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private PictureBox pbxLogo;
        private ToolStripMenuItem newPersonToolStripMenuItem;
        private ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem searchCustomersToolStripMenuItem;
        private ToolStripMenuItem searchEmployeesToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem1;
        private Label lblDate;
        private Label lblTime;
        private System.Windows.Forms.Timer tmrTimer;
        private Label lblFullName;
        private PictureBox pbxAdminRights;
        private ToolTip ttpInfo;
        private Settings uscSettings;
        private Inventory uscInventory;
        private Transactions uscTransactions;
        private ToolStripMenuItem newProductToolStripMenuItem;
        private ToolStripMenuItem newTransactionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private AddNewPerson uscAddNewPerson;
        private Search uscSearch;
        private Label lblDepartment;
        private AddNewTransaction uscAddNewTransaction;
    }
}