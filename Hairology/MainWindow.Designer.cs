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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            lblWelcome = new Label();
            pnlContainer = new Panel();
            pnlBottom = new Panel();
            mstNavigationBar = new MenuStrip();
            AddNewToolStripMenuItem = new ToolStripMenuItem();
            addNewCustomerToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            customerToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            customersToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem1 = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            pnlTop = new Panel();
            lblTime = new Label();
            lblDate = new Label();
            pictureBox1 = new PictureBox();
            pnlContainer.SuspendLayout();
            pnlBottom.SuspendLayout();
            mstNavigationBar.SuspendLayout();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pnlBottom.Controls.Add(mstNavigationBar);
            pnlBottom.Dock = DockStyle.Top;
            pnlBottom.Location = new Point(0, 192);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1264, 489);
            pnlBottom.TabIndex = 2;
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
            AddNewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewCustomerToolStripMenuItem });
            AddNewToolStripMenuItem.Image = Properties.Resources.addnew;
            AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            AddNewToolStripMenuItem.Size = new Size(99, 46);
            AddNewToolStripMenuItem.Text = "Add";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            addNewCustomerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeToolStripMenuItem, toolStripSeparator1, customerToolStripMenuItem });
            addNewCustomerToolStripMenuItem.Image = Properties.Resources.addnew;
            addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            addNewCustomerToolStripMenuItem.Size = new Size(235, 38);
            addNewCustomerToolStripMenuItem.Text = "New Person";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Image = Properties.Resources.user;
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(209, 38);
            employeeToolStripMenuItem.Text = "Employee";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(206, 6);
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Image = Properties.Resources.customer;
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(209, 38);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { peopleToolStripMenuItem, productsToolStripMenuItem, transactionsToolStripMenuItem1 });
            searchToolStripMenuItem.Image = Properties.Resources.search;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(135, 46);
            searchToolStripMenuItem.Text = "Search";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeesToolStripMenuItem, toolStripSeparator2, customersToolStripMenuItem });
            peopleToolStripMenuItem.Image = Properties.Resources.people;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(242, 38);
            peopleToolStripMenuItem.Text = "People";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Image = Properties.Resources.searchemployees;
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(222, 38);
            employeesToolStripMenuItem.Text = "Employees";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(219, 6);
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Image = Properties.Resources.searchcustomers;
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(222, 38);
            customersToolStripMenuItem.Text = "Customers";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Image = Properties.Resources.products;
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(242, 38);
            productsToolStripMenuItem.Text = "Products";
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
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Image = Properties.Resources.inventory;
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(160, 46);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Image = Properties.Resources.invoice;
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(200, 46);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Image = Properties.Resources.settings;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(150, 46);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblTime);
            pnlTop.Controls.Add(lblDate);
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Controls.Add(lblWelcome);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1264, 192);
            pnlTop.TabIndex = 1;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(912, 60);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(340, 28);
            lblTime.TabIndex = 2;
            lblTime.Text = "[TIME]";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(912, 22);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.No;
            lblDate.Size = new Size(340, 28);
            lblDate.TabIndex = 1;
            lblDate.Text = "[DATE]";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            FormClosed += MainWindow_FormClosed;
            pnlContainer.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            mstNavigationBar.ResumeLayout(false);
            mstNavigationBar.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Panel pnlContainer;
        private Panel pnlTop;
        private Panel pnlBottom;
        private MenuStrip mstNavigationBar;
        private ToolStripMenuItem AddNewToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem1;
        private Label lblDate;
        private Label lblTime;
    }
}