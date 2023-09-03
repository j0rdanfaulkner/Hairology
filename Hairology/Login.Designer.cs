namespace Hairology
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnlContainer = new Panel();
            pnlControls = new Panel();
            pbxTogglePassword = new PictureBox();
            btnLogin = new Button();
            tbxPassword = new TextBox();
            tbxUsername = new TextBox();
            pbxLogo = new PictureBox();
            pnlContainer.SuspendLayout();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTogglePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(pnlControls);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1264, 681);
            pnlContainer.TabIndex = 0;
            // 
            // pnlControls
            // 
            pnlControls.Anchor = AnchorStyles.None;
            pnlControls.Controls.Add(pbxTogglePassword);
            pnlControls.Controls.Add(btnLogin);
            pnlControls.Controls.Add(tbxPassword);
            pnlControls.Controls.Add(tbxUsername);
            pnlControls.Controls.Add(pbxLogo);
            pnlControls.Location = new Point(295, 125);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(663, 444);
            pnlControls.TabIndex = 0;
            // 
            // pbxTogglePassword
            // 
            pbxTogglePassword.Anchor = AnchorStyles.None;
            pbxTogglePassword.BackgroundImage = Properties.Resources.showpassword;
            pbxTogglePassword.BackgroundImageLayout = ImageLayout.Zoom;
            pbxTogglePassword.Cursor = Cursors.Hand;
            pbxTogglePassword.Location = new Point(520, 333);
            pbxTogglePassword.Name = "pbxTogglePassword";
            pbxTogglePassword.Size = new Size(33, 33);
            pbxTogglePassword.TabIndex = 4;
            pbxTogglePassword.TabStop = false;
            pbxTogglePassword.Click += pbxTogglePassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(160, 372);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(354, 55);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.None;
            tbxPassword.Location = new Point(160, 333);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PlaceholderText = " PASSWORD";
            tbxPassword.Size = new Size(354, 33);
            tbxPassword.TabIndex = 2;
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = AnchorStyles.None;
            tbxUsername.Location = new Point(160, 294);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.PlaceholderText = " USERNAME";
            tbxUsername.Size = new Size(354, 33);
            tbxUsername.TabIndex = 1;
            // 
            // pbxLogo
            // 
            pbxLogo.Anchor = AnchorStyles.None;
            pbxLogo.BackgroundImage = Properties.Resources.logo;
            pbxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbxLogo.Location = new Point(206, 19);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(256, 256);
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(16F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlContainer);
            Font = new Font("EurostileLTW03-Extended2", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 5, 7, 5);
            Name = "Login";
            Text = "Hairology - Login";
            pnlContainer.ResumeLayout(false);
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTogglePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlControls;
        private TextBox tbxUsername;
        private PictureBox pbxLogo;
        private Button btnLogin;
        private TextBox tbxPassword;
        private PictureBox pbxTogglePassword;
    }
}