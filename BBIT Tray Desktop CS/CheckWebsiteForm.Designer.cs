namespace BBIT_Tray_Desktop_CS
{
    partial class form_chckWbst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_chckWbst));
            this.txtbx_wbstUrl = new System.Windows.Forms.TextBox();
            this.websiteUrl_label = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_chkurl = new System.Windows.Forms.Button();
            this.txtbx_wbRspns = new System.Windows.Forms.TextBox();
            this.wbRspns_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_wbstUrl
            // 
            this.txtbx_wbstUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbx_wbstUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtbx_wbstUrl.Location = new System.Drawing.Point(12, 29);
            this.txtbx_wbstUrl.Name = "txtbx_wbstUrl";
            this.txtbx_wbstUrl.Size = new System.Drawing.Size(467, 20);
            this.txtbx_wbstUrl.TabIndex = 0;
            // 
            // websiteUrl_label
            // 
            this.websiteUrl_label.AutoSize = true;
            this.websiteUrl_label.Location = new System.Drawing.Point(13, 13);
            this.websiteUrl_label.Name = "websiteUrl_label";
            this.websiteUrl_label.Size = new System.Drawing.Size(71, 13);
            this.websiteUrl_label.TabIndex = 1;
            this.websiteUrl_label.Text = "Website URL";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(404, 327);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.close_button_Click);
            // 
            // btn_chkurl
            // 
            this.btn_chkurl.Location = new System.Drawing.Point(323, 327);
            this.btn_chkurl.Name = "btn_chkurl";
            this.btn_chkurl.Size = new System.Drawing.Size(75, 23);
            this.btn_chkurl.TabIndex = 2;
            this.btn_chkurl.Text = "Check URL";
            this.btn_chkurl.UseVisualStyleBackColor = true;
            this.btn_chkurl.Click += new System.EventHandler(this.btn_chkurl_Click);
            // 
            // txtbx_wbRspns
            // 
            this.txtbx_wbRspns.Enabled = false;
            this.txtbx_wbRspns.Location = new System.Drawing.Point(12, 72);
            this.txtbx_wbRspns.Multiline = true;
            this.txtbx_wbRspns.Name = "txtbx_wbRspns";
            this.txtbx_wbRspns.Size = new System.Drawing.Size(467, 249);
            this.txtbx_wbRspns.TabIndex = 1;
            // 
            // wbRspns_label
            // 
            this.wbRspns_label.AutoSize = true;
            this.wbRspns_label.Location = new System.Drawing.Point(13, 56);
            this.wbRspns_label.Name = "wbRspns_label";
            this.wbRspns_label.Size = new System.Drawing.Size(97, 13);
            this.wbRspns_label.TabIndex = 5;
            this.wbRspns_label.Text = "Website Response";
            // 
            // form_chckWbst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(491, 362);
            this.Controls.Add(this.wbRspns_label);
            this.Controls.Add(this.txtbx_wbRspns);
            this.Controls.Add(this.btn_chkurl);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.websiteUrl_label);
            this.Controls.Add(this.txtbx_wbstUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 396);
            this.MinimumSize = new System.Drawing.Size(499, 396);
            this.Name = "form_chckWbst";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BBIT Desktop - Check Website";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_wbstUrl;
        private System.Windows.Forms.Label websiteUrl_label;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_chkurl;
        private System.Windows.Forms.TextBox txtbx_wbRspns;
        private System.Windows.Forms.Label wbRspns_label;
    }
}