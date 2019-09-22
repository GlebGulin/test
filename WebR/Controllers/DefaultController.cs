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
using Telegram.Bot;
using WebR.Sender.Telegram;
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
            catch (FileNotFoundException)
            {
                return "Not found rules.json";

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
            Rules myrule = Parser.LoadRules() as Rules;
            string jsonstring = data.ToString();
            dynamic result = data;
            foreach (dynamic Proj in result.projects)
            {
                string sendname;
                string senddescriprion;
                object nameproject = Proj.name;
                if (nameproject!=null)
                {
                    sendname = nameproject.ToString();
                }
                else
                {
                    sendname = String.Empty;
                }

                object descriptproj = Proj.description;
                 if (descriptproj!=null)
                {
                    senddescriprion = descriptproj.ToString();
                }
                 else
                {
                    senddescriprion = String.Empty;
                }

                
                if (myrule != null)
                {
                    foreach (Rule Item in myrule.rules)
                    {
                        foreach (Effect item in Item.effects)
                        {
                            string type = item.type.ToString();
                            if (type == "telegram")
                            {
                                string id = item.placeholders.id.ToString();
                                string name = item.placeholders.name.ToString();
                                if (id != null && name != null)
                                {
                                    await TelegramerOne.telegram.SendTextMessageAsync(Configuration.NameChanelOne, sendname );
                                    await TelegramerTwo.telegram2.SendTextMessageAsync(Configuration.NameChanelTwo, sendname );
                                }
                            }
                            else if (type == "smtp")
                            {
                                
                                string name = item.placeholders.name.ToString();
                                string description = item.placeholders.description.ToString();
                                if (name!=null && description!=null)
                                {
                                    MailerOne mailer = new MailerOne();
                                    MailerTwo mailer2 = new MailerTwo();
                                    await mailer.SendEmailAsync(sendname, "Project name:"+ sendname  +"</br>"+ senddescriprion);
                                    await mailer2.SendEmailAsync(sendname, "Project name:"+ sendname  + "</br>"+senddescriprion);

                                }
                             }
                        }
                    }
                }

            }
           
        }

      
    }
   
}