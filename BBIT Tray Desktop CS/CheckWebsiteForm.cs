using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace BBIT_Tray_Desktop_CS
{
    public partial class form_chckWbst : Form
    {
        public form_chckWbst()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        // attempt to connect to the website
        private void btn_chkurl_Click(object sender, EventArgs e)
        {
            txtbx_wbRspns.Clear(); // clear the previous request details 
            txtbx_wbstUrl.Enabled = false; // disable the text box
            btn_chkurl.Enabled = false;

            try
            {
                WebRequest wwwRequest = WebRequest.Create(txtbx_wbstUrl.Text.ToString());
                wwwRequest.Method = "GET";
                string postData = "This is a test";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                // wwwRequest.ContentType = "applicatoin/x-www-form-urlencoded";
                wwwRequest.ContentLength = byteArray.Length;
                Stream dataStream = wwwRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse wwwResponse = wwwRequest.GetResponse();
                txtbx_wbRspns.Text += (((HttpWebResponse)wwwResponse).StatusDescription);
                dataStream = wwwResponse.GetResponseStream();
                StreamReader wwwReader = new StreamReader(dataStream);
                string responseFromServer = wwwReader.ReadToEnd();
                txtbx_wbRspns.Text += responseFromServer;
                wwwReader.Close();
                dataStream.Close();
                wwwResponse.Close();
            }
            catch (Exception eMsg)
            {
                MessageBox.Show(eMsg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtbx_wbstUrl.Enabled = true; // re-enable the text box 
            btn_chkurl.Enabled = true;
        }
    }
}
