using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBIT_Tray_Desktop_CS
{
    public partial class bbitMainForm : Form
    {
        public bbitMainForm()
        {
            InitializeComponent();
        }

        private void bbitMainForm_Load(object sender, EventArgs e)
        {
            bool firstRun = true;
            int balloonTipDisplay = 60000;
            string balloonTipTitle = "BBIT Desktop is running";
            string balloonTipText = "";

            if (firstRun == true){
                balloonTipText = "BBIT Desktop running the system tray. ";
            } // end if (firstRun == true)

            balloonTipText += "Right-click the BBIT logo to see options.";

            bbitMainNotifyIcon.ShowBalloonTip(balloonTipDisplay, balloonTipTitle, balloonTipText, ToolTipIcon.Info);

        } // end private void bbitMainForm_Load(object sender, EventArgs e)

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // end private void exitToolStripMenuItem_Click(object sender, EventArgs e)

        private void and1LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.1and1.com/login");
        } // end private void and1LoginToolStripMenuItem_Click(object sender, EventArgs e)

        private void bBITWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.blackboxitech.com");
        } // end private void bBITWebsiteToolStripMenuItem_Click(object sender, EventArgs e)

        private void qDPMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://projects.blackboxitech.com");
        } // end private void qDPMToolStripMenuItem_Click(object sender, EventArgs e)

        private void fusionInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://billing.blackboxitech.com");
        } // end private void fusionInvoiceToolStripMenuItem_Click(object sender, EventArgs e)

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/blackboxitech");
        } // end private void facebookToolStripMenuItem_Click(object sender, EventArgs e)

        private void linkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Process.Start("http://www.1and1.com/login");
        } // end private void linkedInToolStripMenuItem_Click(object sender, EventArgs e)

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://twitter.com/blackboxitech");
        } // end private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        
        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wwww.youtube.com/blackboxitech");
        }

        private void websiteCheckerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            form_chckWbst checkWebsiteFormHandle = new form_chckWbst();
            checkWebsiteFormHandle.Show();
        }

        private void bbitMainNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        } // end private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        
    } // end public partial class bbitMainForm : Form
} // end namespace BBIT_Tray_Desktop_CS
