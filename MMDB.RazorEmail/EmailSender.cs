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
	public class EmailSender
	{
		public EmailServerSettings EmailServerSettings { get; set; }

		public EmailSender()
		{
		}

		public EmailSender(EmailServerSettings emailServerSettings)
		{
			this.EmailServerSettings = emailServerSettings;
		}

		public virtual void SendEmail(string subject, string body, IEnumerable<string> toAddressList, string fromAddress, params EmailAttachmentData[] attachments)
		{
			var toList = toAddressList.Select(i => new MailAddress(i));
			var from = new MailAddress(fromAddress);
			this.SendEmail(subject, body, toList, from, attachments);
		}

		public virtual void SendEmail(string subject, string body, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, params EmailAttachmentData[] attachments)
		{
			using (var smtpClient = GetSmtpClient())
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

		private SmtpClient GetSmtpClient()
		{
			if(this.EmailServerSettings == null)
			{
				return new SmtpClient();
			}
			else 
			{
				int port = this.EmailServerSettings.Port.GetValueOrDefault(25);
				var smtpClient = new SmtpClient(this.EmailServerSettings.Host, port);
				if (!string.IsNullOrEmpty(this.EmailServerSettings.UserName))
				{
					var credential = new NetworkCredential(this.EmailServerSettings.UserName, this.EmailServerSettings.Password);
					credential.GetCredential(smtpClient.Host, port, "Basic");
					smtpClient.UseDefaultCredentials = false;
					smtpClient.Credentials = credential;
				}
				return smtpClient;
			}
		}
	}
}
