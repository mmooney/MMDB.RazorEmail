using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMDB.RazorEmail
{
	public interface IEmailSender
	{
		void SendEmail(string subject, string body, IEnumerable<string> toAddressList, string fromAddress, params EmailAttachmentData[] attachments);
		void SendEmail(string subject, string body, IEnumerable<System.Net.Mail.MailAddress> toAddressList, System.Net.Mail.MailAddress fromAddress, params EmailAttachmentData[] attachments);
	}
}
