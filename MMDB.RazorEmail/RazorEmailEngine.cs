using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MMDB.RazorEmail
{
	public class RazorEmailEngine : IRazorEmailEngine
	{
		private EmailSender EmailSender { get; set; }

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

		public void SendEmail<T>(EmailServerSettings emailServerSettings, string subject, T model, string razorView, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, params EmailAttachmentData[] attachments)
		{
            string body = RazorEngine.Razor.Parse<T>(razorView, model);
            this.EmailSender.SendEmail(emailServerSettings, subject, body, toAddressList, fromAddress, attachments);
        }

        public void SendEmail<T>(EmailServerSettings emailServerSettings, string subject, T model, string razorView, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, bool bodyHtml, params EmailAttachmentData[] attachments)
        {
            string body = RazorEngine.Razor.Parse<T>(razorView, model);
            this.EmailSender.SendEmail(emailServerSettings, subject, body, toAddressList, fromAddress, bodyHtml, attachments);
        }

		public void SendEmail<T>(string subject, T model, string razorView, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, params EmailAttachmentData[] attachments)
		{
			this.SendEmail(null, subject, model, razorView, toAddressList, fromAddress, attachments);
		}

        public void SendEmail<T>(string subject, T model, string razorView, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, bool bodyHtml, params EmailAttachmentData[] attachments)
        {
            this.SendEmail(null, subject, model, razorView, toAddressList, fromAddress, bodyHtml, attachments);
        }

		public void SendEmail<T>(EmailServerSettings emailServerSettings, string subject, T model, string razorView, IEnumerable<string> toAddressList, string fromAddress, params EmailAttachmentData[] attachments)
		{
			var to = toAddressList.Select(i => new MailAddress(i));
			var from = new MailAddress(fromAddress);
			this.SendEmail(emailServerSettings, subject, model, razorView, to, from, attachments);
		}

        public void SendEmail<T>(EmailServerSettings emailServerSettings, string subject, T model, string razorView, IEnumerable<string> toAddressList, string fromAddress, bool bodyHtml, params EmailAttachmentData[] attachments)
        {
            var to = toAddressList.Select(i => new MailAddress(i));
            var from = new MailAddress(fromAddress);
            this.SendEmail(emailServerSettings, subject, model, razorView, to, from, bodyHtml, attachments);
        }

        public void SendEmail<T>(string subject, T model, string razorView, IEnumerable<string> toAddressList, string fromAddress, params EmailAttachmentData[] attachments)
		{
			this.SendEmail(null, subject, model, razorView, toAddressList, fromAddress, attachments);
		}

        public void SendEmail<T>(string subject, T model, string razorView, IEnumerable<string> toAddressList, string fromAddress, bool bodyHtml, params EmailAttachmentData[] attachments)
        {
            this.SendEmail(null, subject, model, razorView, toAddressList, fromAddress, bodyHtml, attachments);
        }
    }
}
