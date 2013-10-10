using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using MMDB.Shared;

namespace MMDB.RazorEmail
{
	public class EmailSender : IEmailSender
	{
		private EmailServerSettings EmailServerSettings { get; set; }

		public EmailSender()
		{
		}

		public EmailSender(EmailServerSettings emailServerSettings)
		{
			this.EmailServerSettings = emailServerSettings;
		}

		public virtual void SendEmail(string subject, string body, IEnumerable<string> toAddressList, string fromAddress, params EmailAttachmentData[] attachments)
		{
			this.SendEmail(this.EmailServerSettings, subject, body, toAddressList, fromAddress, attachments);
		}

		private void SendEmail(EmailServerSettings emailServerSettings, string subject, string body, IEnumerable<string> toAddressList, string fromAddress, EmailAttachmentData[] attachments)
		{
			var toList = toAddressList.Select(i => new MailAddress(i));
			var from = new MailAddress(fromAddress);
			this.SendEmail(emailServerSettings, subject, body, toList, from, attachments);
		}

		public virtual void SendEmail(string subject, string body, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, params EmailAttachmentData[] attachments)
		{
			this.SendEmail(this.EmailServerSettings, subject, body, toAddressList, fromAddress, attachments);
		}

		public virtual void SendEmail(EmailServerSettings settings, string subject, string body, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, params EmailAttachmentData[] attachments)
		{
			using (var smtpClient = GetSmtpClient(settings))
			{
				var message = new MailMessage();
				message.From = fromAddress;
				message.Body = body;
				message.Subject = subject;
				message.IsBodyHtml = true;
				foreach (var toAddress in toAddressList)
				{
					message.To.Add(toAddress);
				}

				if (attachments != null)
				{
					foreach (var item in attachments)
					{
						var stream = StreamHelper.CreateMemoryStream(item.AttachmentData);
						stream.Position = 0;

						var attachment = new Attachment(stream, item.FileName);

						message.Attachments.Add(attachment);
					}
				}

				smtpClient.Send(message);
			}
		}

		private SmtpClient GetSmtpClient(EmailServerSettings emailServerSettings)
		{
			if(emailServerSettings == null)
			{
				emailServerSettings = this.EmailServerSettings;
			}
			if(emailServerSettings == null)
			{
				return new SmtpClient();
			}
			else 
			{
				int port = emailServerSettings.Port.GetValueOrDefault(25);
				var smtpClient = new SmtpClient(emailServerSettings.Host, port);
				if (!string.IsNullOrEmpty(emailServerSettings.UserName))
				{
					var credential = new NetworkCredential(emailServerSettings.UserName, emailServerSettings.Password);
					credential.GetCredential(smtpClient.Host, port, "Basic");
					smtpClient.UseDefaultCredentials = false;
					smtpClient.Credentials = credential;
				}
				return smtpClient;
			}
		}
	}
}
