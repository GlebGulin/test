using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Mime;
using WebR.Models.Rules;
using WebR.Sender;
//using System.Net.Mail.SmtpClient;

namespace WebR.Controllers
{
    [Route("[controller]")]
    public class DefaultController : Controller
    {
        private SmtpClient smtpClient;
        public DefaultController(SmtpClient smtpClient)
        {
            this.smtpClient = smtpClient;
        }
        private readonly string jsonpath = "rules.json";

        public Object LoadRules()
        {

            try
            {
                string jsonconfiguration;
                using (var reader = new StreamReader(jsonpath))
                {
                    jsonconfiguration = reader.ReadToEnd();
                }
                Rules r = JsonConvert.DeserializeObject<Rules>(jsonconfiguration);
                return r;


            }
            catch (Exception ex)
            {
                return false;

            }
        }
        //[Route("get")]
        [HttpGet]
        public IActionResult Get()
        {
            object b = LoadRules();
            return Ok(b) ;
        }
        //[Route("post")]
        [HttpPost]
        public async Task Post([FromBody] JObject data)

        {
            Parser parsrul = new Parser();
            object resultrul = parsrul.LoadRules();
            string jsonstring = data.ToString();
            dynamic result = data;
            foreach (dynamic Proj in result.projects)
            {
                    object nameproject = Proj.name;
                    object descriptproj = Proj.description;
                    string sendname = nameproject.ToString();
                    string senddescriprion = descriptproj.ToString();
                //PostSend(sendname, senddescriprion);
                    MailerOne mailer = new MailerOne();
                MailerTwo mailer2 = new MailerTwo();
                await mailer.SendEmailAsync(sendname, senddescriprion);
                await mailer2.SendEmailAsync(sendname, senddescriprion);
                //return data;

            }
            //return data;
        }

        //public async Task<IActionResult> PostSend(string sub, string bod)
        //{
        //    await this.smtpClient.SendMailAsync(new MailMessage(
        //        from: "glepsgulin@gmail.com",
        //        to: "hannah.petrova@gmail.com",
        //        subject: sub,
        //        body: bod
        //        ));

        //    return Ok("OK");

        //}
        //public void PostSend(string sub, string bod)
        //{
        //    MailAddress to = new MailAddress("hannah.petrova@gmail.com");
            
        //    MailAddress from = new MailAddress("glepsgulin@gmail.com");
        //    MailMessage mail = new MailMessage(from, to);
            
        //    mail.Subject = sub;
        //    mail.Body = bod;
            
        //    SmtpClient client = new SmtpClient();
        //    client.Host = "smtp.gmail.com";
        //    client.Credentials = new NetworkCredential(from.ToString(), "password");
        //    client.Host = "smtp.gmail.com";
        //    client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
        //    client.Port = 25;
        //    client.EnableSsl = true;
        //    client.Send(mail);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    this.smtpClient.Dispose();
        //    base.Dispose(disposing);
        //}
    }
   
}