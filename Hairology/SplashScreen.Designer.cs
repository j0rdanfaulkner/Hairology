namespace Hairology
{
    partial class SplashScreen
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
            pnlContainer = new Panel();
            pnlBackgroundImage = new Panel();
            pgbProgressBar = new ProgressBar();
            lblCurrentProgress = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            tmrTimer = new System.Windows.Forms.Timer(components);
            pnlContainer.SuspendLayout();
            pnlBackgroundImage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(pnlBackgroundImage);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(744, 744);
            pnlContainer.TabIndex = 0;
            // 
            // pnlBackgroundImage
            // 
            pnlBackgroundImage.BackgroundImage = Properties.Resources.splashscreen07;
            pnlBackgroundImage.BackgroundImageLayout = ImageLayout.Zoom;
            pnlBackgroundImage.Controls.Add(pgbProgressBar);
            pnlBackgroundImage.Controls.Add(lblCurrentProgress);
            pnlBackgroundImage.Controls.Add(lblSubtitle);
            pnlBackgroundImage.Controls.Add(lblTitle);
            pnlBackgroundImage.Dock = DockStyle.Fill;
            pnlBackgroundImage.Location = new Point(0, 0);
            pnlBackgroundImage.Name = "pnlBackgroundImage";
            pnlBackgroundImage.Size = new Size(744, 744);
            pnlBackgroundImage.TabIndex = 1;
            // 
            // pgbProgressBar
            // 
            pgbProgressBar.Cursor = Cursors.AppStarting;
            pgbProgressBar.Dock = DockStyle.Bottom;
            pgbProgressBar.Location = new Point(0, 726);
            pgbProgressBar.MarqueeAnimationSpeed = 25;
            pgbProgressBar.Name = "pgbProgressBar";
            pgbProgressBar.Size = new Size(744, 18);
            pgbProgressBar.Style = ProgressBarStyle.Marquee;
            pgbProgressBar.TabIndex = 0;
            // 
            // lblCurrentProgress
            // 
            lblCurrentProgress.AutoSize = true;
            lblCurrentProgress.BackColor = Color.Transparent;
            lblCurrentProgress.Font = new Font("EurostileLTW03-Extended2", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentProgress.ForeColor = SystemColors.ButtonShadow;
            lblCurrentProgress.Location = new Point(3, 702);
            lblCurrentProgress.Name = "lblCurrentProgress";
            lblCurrentProgress.Size = new Size(37, 21);
            lblCurrentProgress.TabIndex = 2;
            lblCurrentProgress.Text = "...";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("EurostileLTW03-Extended2", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtitle.ForeColor = SystemColors.ButtonShadow;
            lblSubtitle.Location = new Point(455, 139);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(273, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "BY JORDAN FAULKNER";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("EurostileLTW03-Extended2", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonShadow;
            lblTitle.Location = new Point(451, 103);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(268, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HAIROLOGY";
            // 
            // tmrTimer
            // 
            tmrTimer.Interval = 1000;
            tmrTimer.Tick += tmrTimer_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(744, 744);
            ControlBox = false;
            Controls.Add(pnlContainer);
            Cursor = Cursors.AppStarting;
            Font = new Font("EurostileLTW03-Extended2", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            Margin = new Padding(8, 6, 8, 6);
            MaximizeBox = false;
            MaximumSize = new Size(750, 750);
            MinimizeBox = false;
            MinimumSize = new Size(750, 750);
            Name = "SplashScreen";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += SplashScreen_FormClosing;
            pnlContainer.ResumeLayout(false);
            pnlBackgroundImage.ResumeLayout(false);
            pnlBackgroundImage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlBackgroundImage;
        private ProgressBar pgbProgressBar;
        private System.Windows.Forms.Timer tmrTimer;
        private Label lblSubtitle;
        private Label lblTitle;
        private Label lblCurrentProgress;
    }
}