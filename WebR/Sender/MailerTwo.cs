using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebR.Sender
{
    public class MailerTwo
    {
        public async Task SendEmailAsync(string subject, string message)
        {
            var emailMessage = new MimeMessage();


            emailMessage.From.Add(new MailboxAddress(Configuration.NameFrom2, Configuration.MailFrom2));
            emailMessage.To.Add(new MailboxAddress("", Configuration.MailTo2));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(Configuration.Smtp2, Configuration.Port2, false);
                await client.AuthenticateAsync(Configuration.MailFrom2, Configuration.MailPass2);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
