namespace Hairology
{
    partial class Search
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
            dgvSearch = new DataGridView();
            pnlContainer = new Panel();
            pnlBottom = new Panel();
            pnlTop = new Panel();
            lblSearch = new Label();
            btnSubmit = new Button();
            tbxSearchTerm = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            pnlContainer.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSearch
            // 
            dgvSearch.AllowUserToAddRows = false;
            dgvSearch.AllowUserToDeleteRows = false;
            dgvSearch.AllowUserToResizeRows = false;
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Dock = DockStyle.Fill;
            dgvSearch.Location = new Point(0, 0);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.ReadOnly = true;
            dgvSearch.RowTemplate.Height = 25;
            dgvSearch.Size = new Size(1264, 386);
            dgvSearch.TabIndex = 0;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = SystemColors.ActiveCaption;
            pnlContainer.Controls.Add(pnlBottom);
            pnlContainer.Controls.Add(pnlTop);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Font = new Font("EurostileLTW03-Extended2", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 449);
            pnlContainer.TabIndex = 1;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(dgvSearch);
            pnlBottom.Dock = DockStyle.Fill;
            pnlBottom.Location = new Point(0, 63);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1264, 386);
            pnlBottom.TabIndex = 5;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblSearch);
            pnlTop.Controls.Add(btnSubmit);
            pnlTop.Controls.Add(tbxSearchTerm);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1264, 63);
            pnlTop.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(15, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(117, 28);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatStyle = FlatStyle.System;
            btnSubmit.Location = new Point(1139, 15);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 29);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // tbxSearchTerm
            // 
            tbxSearchTerm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxSearchTerm.Cursor = Cursors.IBeam;
            tbxSearchTerm.Location = new Point(861, 16);
            tbxSearchTerm.Name = "tbxSearchTerm";
            tbxSearchTerm.PlaceholderText = "  SEARCH FOR...";
            tbxSearchTerm.Size = new Size(263, 29);
            tbxSearchTerm.TabIndex = 2;
            // 
            // Search
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlContainer);
            Name = "Search";
            Size = new Size(1264, 449);
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            pnlContainer.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSearch;
        private Panel pnlContainer;
        private Button btnSubmit;
        private Label lblSearch;
        private TextBox tbxSearchTerm;
        private Panel pnlTop;
        private Panel pnlBottom;
    }
}
