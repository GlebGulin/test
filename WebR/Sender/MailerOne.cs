using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebR.Sender
{
    public class MailerOne
    {
        public async Task SendEmailAsync(string subject, string message)
        {
            var emailMessage = new MimeMessage();


            emailMessage.From.Add(new MailboxAddress(Configuration.NameFrom, Configuration.MailFrom));
            emailMessage.To.Add(new MailboxAddress("", Configuration.MailTo));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(Configuration.Smtp, Configuration.Port, false);
                await client.AuthenticateAsync(Configuration.MailFrom, Configuration.MailPass);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }

    }
}
