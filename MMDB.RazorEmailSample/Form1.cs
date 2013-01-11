using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMDB.RazorEmail;
using MMDB.RazorEmailSample.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MMDB.RazorEmailSample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var sampleObject = new 
			{
				ReportDate = DateTime.Now,
				DepartmentList = new []
				{
					new 
					{
						DepartmentName = "Developers",
						EmployeeList = new []
						{
							new { FirstName="Essie", LastName="Vaill" },
							new { FirstName="Cruz", LastName="Roudabush" },
							new { FirstName="Billie", LastName="Tinnes" },
							new { FirstName="Lashawn", LastName="Hasty" },
							new { FirstName="Marianne", LastName="Earman" }
						}
					},
					new 
					{
						DepartmentName = "QA",
						EmployeeList = new []
						{
							new { FirstName="Zackary", LastName="Mockus" },
							new { FirstName="Rosemarie", LastName="Fifield" },
							new { FirstName="Bernard", LastName="Laboy" },
						}
					},
					new
					{
						DepartmentName = "ProjectManagemnt",
						EmployeeList = new []
						{
							new { FirstName="Sue", LastName="Haakinson" },
							new { FirstName="Valerie", LastName="Pou" },
						}
					}
				}
			};
			_txtJson.Text = sampleObject.ToJson(true);
			_txtRazorView.Text = Resources.RazorSampleView;
			this.UpdatePreview();
			this.UpdateSmtpSettings();
		}

		private void UpdatePreview()
		{
			string html;
			dynamic model;
			try 
			{
				model = JObject.Parse(_txtJson.Text);
				html = RazorEngine.Razor.Parse(_txtRazorView.Text, (dynamic)model);
			}
			catch(Exception err)
			{
				html = "<h1>Error:</h1><pre>" + System.Web.HttpUtility.HtmlEncode(err.ToString()) + "</pre>";
			}
			_wbPreview.Navigate("about:blank");
			_wbPreview.Document.Write(html);
			_wbPreview.DocumentText = html;
		}

		private void _btnUpdatePreview_Click(object sender, EventArgs e)
		{
			this.UpdatePreview();
		}

		private void _txtUserName_TextChanged(object sender, EventArgs e)
		{

		}

		private void _rdoUseAppConfigSettings_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSmtpSettings();
		}

		private void _rdoUseSpecifiedSettings_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSmtpSettings();
		}

		private void UpdateSmtpSettings()
		{
			_pnlSmptSettings.Enabled = _rdoUseSpecifiedSettings.Checked;
		}

		private void _btnSendIt_Click(object sender, EventArgs e)
		{
			dynamic model;
			try
			{
				model = JObject.Parse(_txtJson.Text);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.ToString(), "Error");
				return;
			}

			EmailServerSettings settings = null;
			if(_rdoUseSpecifiedSettings.Checked)
			{
				if(string.IsNullOrEmpty(_txtSmtpServerName.Text))
				{
					MessageBox.Show("Please enter a server name", "Error");
					return;
				}
				settings = new EmailServerSettings
				{
					Host = _txtSmtpServerName.Text,
					Port = Convert.ToInt32(_numPort.Value),
					UserName = _txtUserName.Text,
					Password = _txtPassword.Text
				};
			}
			

			string from = _txtFrom.Text;
			if(string.IsNullOrEmpty(_txtFrom.Text))
			{
				from = "test@mmdbsolutions.com";
			}
			if(string.IsNullOrEmpty(_txtFrom.Text))
			{
				MessageBox.Show("Please enter at least one To email", "Error");
				return;
			}
			List<string> toList = new List<string>(_txtFrom.Text.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries));
			RazorEmailEngine emailEngine = new RazorEmailEngine(settings);
			try 
			{
				emailEngine.SendEmail(_txtSubject.Text, model, _txtRazorView.Text, toList, from);
				MessageBox.Show("Message sent successfully!");
			}
			catch(Exception err)
			{
				MessageBox.Show(err.ToString(), "Error");
				return;
			}
		}


	}
}
