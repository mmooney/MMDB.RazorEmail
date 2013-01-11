using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MMDB.RazorEmail
{
	public class RazorEmailEngine
	{
		//private RazorHosting.RazorEngine< RazorEngine { get; set; }
		private EmailSender EmailSender { get; set; }

		public EmailServerSettings EmailServerSettings
		{
			get
			{
				return this.EmailSender.EmailServerSettings;
			}
			set
			{
				this.EmailSender.EmailServerSettings = value;
			}
		}

		public RazorEmailEngine()
		{
			this.EmailSender = new EmailSender();
		}

		public RazorEmailEngine(EmailServerSettings settings)
		{
			this.EmailSender = new EmailSender(settings);
		}

		public RazorEmailEngine(EmailSender emailSender)
		{
			this.EmailSender = emailSender;
		}

		public void SendEmail<T>(string subject, T model, string razorView, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, params EmailAttachmentData[] attachments)
		{
			string body = RazorEngine.Razor.Parse<T>(razorView, model);
			this.EmailSender.SendEmail(subject, body, toAddressList, fromAddress, attachments);
		}

		public void SendEmail<T>(string subject, T model, string razorView, IEnumerable<string> toAddressList, string fromAddress, params EmailAttachmentData[] attachments)
		{
			var to = toAddressList.Select(i => new MailAddress(i));
			var from = new MailAddress(fromAddress);
			this.SendEmail(subject, model, razorView, to, from, attachments);
		}
	}
}
