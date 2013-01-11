namespace MMDB.RazorEmailSample
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this._btnSendIt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this._txtJson = new System.Windows.Forms.TextBox();
			this._txtRazorView = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._wbPreview = new System.Windows.Forms.WebBrowser();
			this.label3 = new System.Windows.Forms.Label();
			this._btnUpdatePreview = new System.Windows.Forms.Button();
			this._grpSmtpOptions = new System.Windows.Forms.GroupBox();
			this._rdoUseAppConfigSettings = new System.Windows.Forms.RadioButton();
			this._rdoUseSpecifiedSettings = new System.Windows.Forms.RadioButton();
			this._pnlSmptSettings = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this._txtSmtpServerName = new System.Windows.Forms.TextBox();
			this._txtUserName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._numPort = new System.Windows.Forms.NumericUpDown();
			this._txtPassword = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this._txtFrom = new System.Windows.Forms.TextBox();
			this._txtTo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this._txtSubject = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this._grpSmtpOptions.SuspendLayout();
			this._pnlSmptSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._numPort)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnSendIt
			// 
			this._btnSendIt.Location = new System.Drawing.Point(684, 461);
			this._btnSendIt.Name = "_btnSendIt";
			this._btnSendIt.Size = new System.Drawing.Size(75, 23);
			this._btnSendIt.TabIndex = 9;
			this._btnSendIt.Text = "Send It!";
			this._btnSendIt.UseVisualStyleBackColor = true;
			this._btnSendIt.Click += new System.EventHandler(this._btnSendIt_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Model JSON:";
			// 
			// _txtJson
			// 
			this._txtJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtJson.Location = new System.Drawing.Point(6, 25);
			this._txtJson.Multiline = true;
			this._txtJson.Name = "_txtJson";
			this._txtJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this._txtJson.Size = new System.Drawing.Size(753, 144);
			this._txtJson.TabIndex = 1;
			this._txtJson.WordWrap = false;
			// 
			// _txtRazorView
			// 
			this._txtRazorView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtRazorView.Location = new System.Drawing.Point(6, 193);
			this._txtRazorView.Multiline = true;
			this._txtRazorView.Name = "_txtRazorView";
			this._txtRazorView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this._txtRazorView.Size = new System.Drawing.Size(753, 119);
			this._txtRazorView.TabIndex = 3;
			this._txtRazorView.WordWrap = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Razor View:";
			// 
			// _wbPreview
			// 
			this._wbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._wbPreview.Location = new System.Drawing.Point(6, 344);
			this._wbPreview.MinimumSize = new System.Drawing.Size(20, 20);
			this._wbPreview.Name = "_wbPreview";
			this._wbPreview.Size = new System.Drawing.Size(753, 110);
			this._wbPreview.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 320);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Preview:";
			// 
			// _btnUpdatePreview
			// 
			this._btnUpdatePreview.Location = new System.Drawing.Point(66, 318);
			this._btnUpdatePreview.Name = "_btnUpdatePreview";
			this._btnUpdatePreview.Size = new System.Drawing.Size(75, 20);
			this._btnUpdatePreview.TabIndex = 5;
			this._btnUpdatePreview.Text = "Update";
			this._btnUpdatePreview.UseVisualStyleBackColor = true;
			this._btnUpdatePreview.Click += new System.EventHandler(this._btnUpdatePreview_Click);
			// 
			// _grpSmtpOptions
			// 
			this._grpSmtpOptions.Controls.Add(this._pnlSmptSettings);
			this._grpSmtpOptions.Controls.Add(this._rdoUseSpecifiedSettings);
			this._grpSmtpOptions.Controls.Add(this._rdoUseAppConfigSettings);
			this._grpSmtpOptions.Location = new System.Drawing.Point(6, 461);
			this._grpSmtpOptions.Name = "_grpSmtpOptions";
			this._grpSmtpOptions.Size = new System.Drawing.Size(276, 181);
			this._grpSmtpOptions.TabIndex = 7;
			this._grpSmtpOptions.TabStop = false;
			this._grpSmtpOptions.Text = "SMTP Options";
			// 
			// _rdoUseAppConfigSettings
			// 
			this._rdoUseAppConfigSettings.AutoSize = true;
			this._rdoUseAppConfigSettings.Checked = true;
			this._rdoUseAppConfigSettings.Location = new System.Drawing.Point(9, 20);
			this._rdoUseAppConfigSettings.Name = "_rdoUseAppConfigSettings";
			this._rdoUseAppConfigSettings.Size = new System.Drawing.Size(159, 17);
			this._rdoUseAppConfigSettings.TabIndex = 0;
			this._rdoUseAppConfigSettings.TabStop = true;
			this._rdoUseAppConfigSettings.Text = "Use settings from app.config";
			this._rdoUseAppConfigSettings.UseVisualStyleBackColor = true;
			this._rdoUseAppConfigSettings.CheckedChanged += new System.EventHandler(this._rdoUseAppConfigSettings_CheckedChanged);
			// 
			// _rdoUseSpecifiedSettings
			// 
			this._rdoUseSpecifiedSettings.AutoSize = true;
			this._rdoUseSpecifiedSettings.Location = new System.Drawing.Point(9, 43);
			this._rdoUseSpecifiedSettings.Name = "_rdoUseSpecifiedSettings";
			this._rdoUseSpecifiedSettings.Size = new System.Drawing.Size(115, 17);
			this._rdoUseSpecifiedSettings.TabIndex = 1;
			this._rdoUseSpecifiedSettings.Text = "Use these settings:";
			this._rdoUseSpecifiedSettings.UseVisualStyleBackColor = true;
			this._rdoUseSpecifiedSettings.CheckedChanged += new System.EventHandler(this._rdoUseSpecifiedSettings_CheckedChanged);
			// 
			// _pnlSmptSettings
			// 
			this._pnlSmptSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pnlSmptSettings.Controls.Add(this._txtPassword);
			this._pnlSmptSettings.Controls.Add(this.label7);
			this._pnlSmptSettings.Controls.Add(this._numPort);
			this._pnlSmptSettings.Controls.Add(this.label6);
			this._pnlSmptSettings.Controls.Add(this._txtUserName);
			this._pnlSmptSettings.Controls.Add(this.label5);
			this._pnlSmptSettings.Controls.Add(this._txtSmtpServerName);
			this._pnlSmptSettings.Controls.Add(this.label4);
			this._pnlSmptSettings.Location = new System.Drawing.Point(9, 63);
			this._pnlSmptSettings.Name = "_pnlSmptSettings";
			this._pnlSmptSettings.Size = new System.Drawing.Size(261, 112);
			this._pnlSmptSettings.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "SMTP Server:";
			// 
			// _txtSmtpServerName
			// 
			this._txtSmtpServerName.Location = new System.Drawing.Point(93, 6);
			this._txtSmtpServerName.Name = "_txtSmtpServerName";
			this._txtSmtpServerName.Size = new System.Drawing.Size(149, 20);
			this._txtSmtpServerName.TabIndex = 1;
			// 
			// _txtUserName
			// 
			this._txtUserName.Location = new System.Drawing.Point(93, 56);
			this._txtUserName.Name = "_txtUserName";
			this._txtUserName.Size = new System.Drawing.Size(149, 20);
			this._txtUserName.TabIndex = 5;
			this._txtUserName.TextChanged += new System.EventHandler(this._txtUserName_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "User Name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(58, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Port:";
			// 
			// _numPort
			// 
			this._numPort.Location = new System.Drawing.Point(93, 34);
			this._numPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this._numPort.Name = "_numPort";
			this._numPort.Size = new System.Drawing.Size(120, 20);
			this._numPort.TabIndex = 3;
			this._numPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			// 
			// _txtPassword
			// 
			this._txtPassword.Location = new System.Drawing.Point(93, 82);
			this._txtPassword.Name = "_txtPassword";
			this._txtPassword.PasswordChar = '*';
			this._txtPassword.Size = new System.Drawing.Size(149, 20);
			this._txtPassword.TabIndex = 7;
			this._txtPassword.UseSystemPasswordChar = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(31, 85);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Password:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this._txtSubject);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this._txtTo);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this._txtFrom);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Location = new System.Drawing.Point(288, 461);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(390, 175);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Message Details";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "From:";
			// 
			// _txtFrom
			// 
			this._txtFrom.Location = new System.Drawing.Point(59, 17);
			this._txtFrom.Name = "_txtFrom";
			this._txtFrom.Size = new System.Drawing.Size(315, 20);
			this._txtFrom.TabIndex = 1;
			this._txtFrom.Text = "test@mmdbsolutions.com";
			// 
			// _txtTo
			// 
			this._txtTo.Location = new System.Drawing.Point(59, 40);
			this._txtTo.Name = "_txtTo";
			this._txtTo.Size = new System.Drawing.Size(315, 20);
			this._txtTo.TabIndex = 3;
			this._txtTo.Text = "razoremail@mmdbsolutions.com";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(30, 43);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "To:";
			// 
			// _txtSubject
			// 
			this._txtSubject.Location = new System.Drawing.Point(59, 84);
			this._txtSubject.Name = "_txtSubject";
			this._txtSubject.Size = new System.Drawing.Size(315, 20);
			this._txtSubject.TabIndex = 6;
			this._txtSubject.Text = "Email without Razor is a like a bowling ball without a liquid center";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 87);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(46, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Subject:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(59, 67);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(229, 13);
			this.label11.TabIndex = 4;
			this.label11.Text = "Seperate To: email address with a semicolun (;)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 642);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this._grpSmtpOptions);
			this.Controls.Add(this._btnUpdatePreview);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._wbPreview);
			this.Controls.Add(this._txtRazorView);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._txtJson);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._btnSendIt);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "MMDB Razor Email Sample";
			this.Load += new System.EventHandler(this.Form1_Load);
			this._grpSmtpOptions.ResumeLayout(false);
			this._grpSmtpOptions.PerformLayout();
			this._pnlSmptSettings.ResumeLayout(false);
			this._pnlSmptSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._numPort)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _btnSendIt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _txtJson;
		private System.Windows.Forms.TextBox _txtRazorView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.WebBrowser _wbPreview;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _btnUpdatePreview;
		private System.Windows.Forms.GroupBox _grpSmtpOptions;
		private System.Windows.Forms.Panel _pnlSmptSettings;
		private System.Windows.Forms.NumericUpDown _numPort;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _txtUserName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox _txtSmtpServerName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton _rdoUseSpecifiedSettings;
		private System.Windows.Forms.RadioButton _rdoUseAppConfigSettings;
		private System.Windows.Forms.TextBox _txtPassword;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox _txtSubject;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox _txtTo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox _txtFrom;
		private System.Windows.Forms.Label label8;
	}
}

