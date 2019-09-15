using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebR.Models.Rules;

namespace WebR
{
    public class Parser
    {
        //public Parser()
        //{
        //    object _result = r;
        //}
        private readonly string jsonpath = "rules.json";
        //private readonly string jsonpath = "test.json";
        public string result;
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
                //Test r = JsonConvert.DeserializeObject<Test>(jsonconfiguration);
                //dynamic c = JsonConvert.DeserializeObject(jsonconfiguration);
                dynamic c = JsonConvert.DeserializeObject(jsonconfiguration);
                //r.rules.ToArray();
                c.rules.ToArray();
                r.rules.ToArray();

                r.ToString();
                return r;





            }
            catch (Exception ex)
            {
                return false;

            }


        }

    }
    
}
