using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebR.Models.Rules;

namespace WebR.Controllers
{
    [Route("[controller]")]
    public class DefaultController : Controller
    {
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
        public JObject Post([FromBody] JObject data)

        {
//           

            Parser parsrul = new Parser();
            object resultrul = parsrul.LoadRules();
            string jsonstring = data.ToString();
            dynamic result = data;
            
                foreach (dynamic Proj in result.projects)
                {
                    object nameproject = Proj.name;
                    string sendname = nameproject.ToString();
                    foreach (dynamic Descr in result.projects)
                    {
                        object descriptproj = Descr.description;
                        string senddescriprion = descriptproj.ToString();
                        
                    //return Configuration.MailTo;
                    }


                }
            //}
            //else
            //{
            //    result.projects = "";
            //    //result.projects.description = "";
            //}

            //JArray jsonVal = JArray.Parse(jsonstring) as JArray;
            //dynamic result = jsonVal;
            //foreach (dynamic res in result )
            //{
            //    return Ok(res);
            //}

            //return Ok(data);
            return data;

        }
}
}