﻿namespace Hairology
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
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("EurostileLTW03-Extended2", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(29, 28);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(495, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [USERNAME]";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(16F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 681);
            Controls.Add(lblWelcome);
            Font = new Font("EurostileLTW03-Extended2", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 5, 7, 5);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hairology";
            FormClosed += MainWindow_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
    }
}