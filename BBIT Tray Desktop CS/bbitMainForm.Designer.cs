namespace BBIT_Tray_Desktop_CS
{
    partial class bbitMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bbitMainForm));
            this.bbitMainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.bbitMainContextNotifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.and1LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBITEmailOffice365ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bBITOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBITWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fusionInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qDPMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBITSocialMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbitMainContextNotifyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bbitMainNotifyIcon
            // 
            this.bbitMainNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.bbitMainNotifyIcon.ContextMenuStrip = this.bbitMainContextNotifyMenuStrip;
            this.bbitMainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("bbitMainNotifyIcon.Icon")));
            this.bbitMainNotifyIcon.Text = "Black Box Innovation Technologies Desktop";
            this.bbitMainNotifyIcon.Visible = true;
            this.bbitMainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bbitMainNotifyIcon_MouseDoubleClick);
            // 
            // bbitMainContextNotifyMenuStrip
            // 
            this.bbitMainContextNotifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.and1LoginToolStripMenuItem,
            this.bBITEmailOffice365ToolStripMenuItem,
            this.websiteCheckerToolStripMenuItem,
            this.toolStripSeparator2,
            this.bBITOnlineToolStripMenuItem,
            this.bBITSocialMediaToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.bbitMainContextNotifyMenuStrip.Name = "bbitMainContextNotifyMenuStrip";
            this.bbitMainContextNotifyMenuStrip.Size = new System.Drawing.Size(195, 148);
            // 
            // and1LoginToolStripMenuItem
            // 
            this.and1LoginToolStripMenuItem.Name = "and1LoginToolStripMenuItem";
            this.and1LoginToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.and1LoginToolStripMenuItem.Text = "1 and 1 Login";
            // 
            // bBITEmailOffice365ToolStripMenuItem
            // 
            this.bBITEmailOffice365ToolStripMenuItem.Name = "bBITEmailOffice365ToolStripMenuItem";
            this.bBITEmailOffice365ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bBITEmailOffice365ToolStripMenuItem.Text = "BBIT Email / Office 365";
            // 
            // websiteCheckerToolStripMenuItem
            // 
            this.websiteCheckerToolStripMenuItem.Name = "websiteCheckerToolStripMenuItem";
            this.websiteCheckerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.websiteCheckerToolStripMenuItem.Text = "Website Checker";
            this.websiteCheckerToolStripMenuItem.Click += new System.EventHandler(this.websiteCheckerToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // bBITOnlineToolStripMenuItem
            // 
            this.bBITOnlineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bBITWebsiteToolStripMenuItem,
            this.fusionInvoiceToolStripMenuItem,
            this.qDPMToolStripMenuItem});
            this.bBITOnlineToolStripMenuItem.Name = "bBITOnlineToolStripMenuItem";
            this.bBITOnlineToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bBITOnlineToolStripMenuItem.Text = "BBIT Online";
            // 
            // bBITWebsiteToolStripMenuItem
            // 
            this.bBITWebsiteToolStripMenuItem.Name = "bBITWebsiteToolStripMenuItem";
            this.bBITWebsiteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bBITWebsiteToolStripMenuItem.Text = "BBIT Website";
            this.bBITWebsiteToolStripMenuItem.ToolTipText = "Go to the Black Box Innovation Technologies website.";
            this.bBITWebsiteToolStripMenuItem.Click += new System.EventHandler(this.bBITWebsiteToolStripMenuItem_Click);
            // 
            // fusionInvoiceToolStripMenuItem
            // 
            this.fusionInvoiceToolStripMenuItem.Name = "fusionInvoiceToolStripMenuItem";
            this.fusionInvoiceToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fusionInvoiceToolStripMenuItem.Text = "Fusion Invoice";
            this.fusionInvoiceToolStripMenuItem.ToolTipText = "Go to the invoicing system for BBIT. ";
            this.fusionInvoiceToolStripMenuItem.Click += new System.EventHandler(this.fusionInvoiceToolStripMenuItem_Click);
            // 
            // qDPMToolStripMenuItem
            // 
            this.qDPMToolStripMenuItem.Name = "qDPMToolStripMenuItem";
            this.qDPMToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.qDPMToolStripMenuItem.Text = "QDPM";
            this.qDPMToolStripMenuItem.ToolTipText = "Go to the project management system for BBIT.";
            this.qDPMToolStripMenuItem.Click += new System.EventHandler(this.qDPMToolStripMenuItem_Click);
            // 
            // bBITSocialMediaToolStripMenuItem
            // 
            this.bBITSocialMediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookToolStripMenuItem,
            this.linkedInToolStripMenuItem,
            this.twitterToolStripMenuItem,
            this.youTubeToolStripMenuItem});
            this.bBITSocialMediaToolStripMenuItem.Name = "bBITSocialMediaToolStripMenuItem";
            this.bBITSocialMediaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bBITSocialMediaToolStripMenuItem.Text = "BBIT Social Media";
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // linkedInToolStripMenuItem
            // 
            this.linkedInToolStripMenuItem.Name = "linkedInToolStripMenuItem";
            this.linkedInToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.linkedInToolStripMenuItem.Text = "LinkedIn";
            this.linkedInToolStripMenuItem.Click += new System.EventHandler(this.linkedInToolStripMenuItem_Click);
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitterToolStripMenuItem_Click);
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            this.youTubeToolStripMenuItem.Click += new System.EventHandler(this.youTubeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit BBIT Desktop.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bbitMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bbitMainForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "BBIT Desktop";
            this.Load += new System.EventHandler(this.bbitMainForm_Load);
            this.bbitMainContextNotifyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon bbitMainNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip bbitMainContextNotifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem bBITOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bBITWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qDPMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fusionInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bBITSocialMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem and1LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bBITEmailOffice365ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteCheckerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}