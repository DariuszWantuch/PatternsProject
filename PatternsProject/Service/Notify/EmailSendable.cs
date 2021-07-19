using PatternsProject.Utility;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.Notify
{
    class EmailSendable : Sendable
    {
        public override void Send(string to, string subject, string message, int invoiceId, string invoicePath)
        {
            Execute(AuthMessageSenderOptions.SendGridKey, subject, message, to, invoiceId, invoicePath);
        }

        /*
        public Task SendEmailAsync(string email, string subject, string message, int invoiceId, string invoicePath)
        {
            return Execute(AuthMessageSenderOptions.SendGridKey, subject, message, to, invoiceId, invoicePath);
        }
        */

        private Task Execute(string apiKey, string _subject, string _message, string _email, int invoiceId, string invoicePath)
        {
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("darek.wantuch@wp.pl", "noreply@faktury.pl");
            var subject = _subject;
            var to = new EmailAddress(_email, "Witaj");
            var plainTextContent = _message;
            var htmlContent = _message;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            return client.SendEmailAsync(msg);
        }
    }
}
