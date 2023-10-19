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
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddNewProduct
            // 
            lblAddNewProduct.AutoSize = true;
            lblAddNewProduct.Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddNewProduct.Location = new Point(15, 15);
            lblAddNewProduct.Name = "lblAddNewProduct";
            lblAddNewProduct.Size = new Size(328, 28);
            lblAddNewProduct.TabIndex = 14;
            lblAddNewProduct.Text = "ADD NEW PRODUCT";
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(lblAddNewProduct);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 449);
            pnlContainer.TabIndex = 15;
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
            ResumeLayout(false);
        }

        #endregion

        private Label lblAddNewProduct;
        private Panel pnlContainer;
    }
}
