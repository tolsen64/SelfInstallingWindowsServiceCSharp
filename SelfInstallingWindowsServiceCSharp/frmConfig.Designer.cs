namespace SelfInstallingWindowsServiceCSharp
{
    partial class frmConfig
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itmInstallUninstallService = new System.Windows.Forms.ToolStripMenuItem();
            this.itmStartStopService = new System.Windows.Forms.ToolStripMenuItem();
            this.itmRunAsApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInstallStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRunStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmInstallUninstallService,
            this.itmStartStopService,
            this.itmRunAsApplication});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(499, 24);
            this.MenuStrip1.TabIndex = 3;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // itmInstallUninstallService
            // 
            this.itmInstallUninstallService.Name = "itmInstallUninstallService";
            this.itmInstallUninstallService.Size = new System.Drawing.Size(90, 20);
            this.itmInstallUninstallService.Text = "Install Service";
            this.itmInstallUninstallService.Click += new System.EventHandler(this.itmInstallUninstallService_Click);
            // 
            // itmStartStopService
            // 
            this.itmStartStopService.Enabled = false;
            this.itmStartStopService.Name = "itmStartStopService";
            this.itmStartStopService.Size = new System.Drawing.Size(83, 20);
            this.itmStartStopService.Text = "Start Service";
            this.itmStartStopService.Click += new System.EventHandler(this.itmStartStopService_Click);
            // 
            // itmRunAsApplication
            // 
            this.itmRunAsApplication.Name = "itmRunAsApplication";
            this.itmRunAsApplication.Size = new System.Drawing.Size(118, 20);
            this.itmRunAsApplication.Text = "Run as Application";
            this.itmRunAsApplication.Click += new System.EventHandler(this.itmRunAsApplication_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.lblInstallStatus,
            this.ToolStripStatusLabel2,
            this.lblRunStatus});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 310);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(499, 22);
            this.StatusStrip1.TabIndex = 4;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.ToolStripStatusLabel1.Text = "Service Status:";
            // 
            // lblInstallStatus
            // 
            this.lblInstallStatus.Name = "lblInstallStatus";
            this.lblInstallStatus.Size = new System.Drawing.Size(74, 17);
            this.lblInstallStatus.Text = "Not Installed";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.ToolStripStatusLabel2.Text = ",";
            // 
            // lblRunStatus
            // 
            this.lblRunStatus.Name = "lblRunStatus";
            this.lblRunStatus.Size = new System.Drawing.Size(51, 17);
            this.lblRunStatus.Text = "Stopped";
            // 
            // Label1
            // 
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label1.Location = new System.Drawing.Point(12, 102);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(475, 115);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Delete this label and add necessary service configuration user interface controls" +
    " and code-behind.";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 332);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.Label1);
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem itmInstallUninstallService;
        internal System.Windows.Forms.ToolStripMenuItem itmStartStopService;
        internal System.Windows.Forms.ToolStripMenuItem itmRunAsApplication;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel lblInstallStatus;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel lblRunStatus;
        internal System.Windows.Forms.Label Label1;
    }
}