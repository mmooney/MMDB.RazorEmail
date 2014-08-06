using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace MMDB.RazorEmail
{
	public interface IRazorEmailEngine
	{
        void SendEmail<T>(EmailServerSettings emailServerSettings, string subject, T model, string razorView, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, params EmailAttachmentData[] attachments);
        void SendEmail<T>(EmailServerSettings emailServerSettings, string subject, T model, string razorView, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, bool bodyHtml, params EmailAttachmentData[] attachments);
        void SendEmail<T>(string subject, T model, string razorView, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, params EmailAttachmentData[] attachments);
        void SendEmail<T>(string subject, T model, string razorView, IEnumerable<MailAddress> toAddressList, MailAddress fromAddress, bool bodyHtml, params EmailAttachmentData[] attachments);
        void SendEmail<T>(EmailServerSettings emailServerSettings, string subject, T model, string razorView, IEnumerable<string> toAddressList, string fromAddress, params EmailAttachmentData[] attachments);
        void SendEmail<T>(EmailServerSettings emailServerSettings, string subject, T model, string razorView, IEnumerable<string> toAddressList, string fromAddress, bool bodyHtml, params EmailAttachmentData[] attachments);
        void SendEmail<T>(string subject, T model, string razorView, IEnumerable<string> toAddressList, string fromAddress, bool bodyHtml, params EmailAttachmentData[] attachments);
        void SendEmail<T>(string subject, T model, string razorView, IEnumerable<string> toAddressList, string fromAddress, params EmailAttachmentData[] attachments);
    }
}
