using BusinessGarant.Models;
using BusinessGarant.Settings;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MailKit.Net.Smtp;
using MailKit.Security;
using System.Threading.Tasks;
using System.Net.Mail;

namespace BusinessGarant.Services
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        private readonly IMailRequest _mailRequest;
        public MailService(IOptions<MailSettings> mailSettings, IMailRequest mailRequest)
        {
            _mailSettings = mailSettings.Value;
            _mailRequest = mailRequest;
        }
        public async Task SendEmailAsync(string fileName,string subject, byte[] atachment, string message)
        {
            var email = new MailMessage
            {
                From = new MailAddress(_mailSettings.Mail,_mailSettings.DisplayName)
            };
            email.To.Add(new MailAddress(_mailRequest.ToEmail));
            email.Subject = subject;
            var builder = new BodyBuilder();
            builder.Attachments.Add($"{fileName}.docx", atachment, ContentType.Parse(_mailSettings.ContentType));

                email.Attachments.Add(new Attachment(new MemoryStream(atachment), $"{fileName}.docx", _mailSettings.ContentType));

                builder.TextBody = message;
                email.Body = message;
                var smtp = new System.Net.Mail.SmtpClient();
          
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("postmaster@gsu-tranzit.com", "13RKovLSqw!");
                smtp.Port = 25; // You can use Port 25 if 587 is blocked (mine is!)
                smtp.Host = "mail.gsu-tranzit.com";
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = false;
                smtp.SendCompleted += (s, e) => {
                smtp.Dispose();
                
            };
            smtp.SendAsync(email, null);

        }

        public async Task SendEmailAsync( string subject, string message)
        {
            var email = new MailMessage
            {
                From = new MailAddress(_mailSettings.Mail, _mailSettings.DisplayName)
            };
            email.To.Add(new MailAddress(_mailRequest.ToEmail));
            email.Subject = subject;
            email.Body = message;email.IsBodyHtml = true;
            var smtp = new System.Net.Mail.SmtpClient();

            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("postmaster@gsu-tranzit.com", "13RKovLSqw!");
            smtp.Port = 25; // You can use Port 25 if 587 is blocked (mine is!)
            smtp.Host = "mail.gsu-tranzit.com";
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = false;
            smtp.SendCompleted += (s, e) => {
                smtp.Dispose();

            };
            smtp.SendAsync(email, null);

        }
    }
}
