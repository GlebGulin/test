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
        public Parser()
        {
            string _result = result;
        }
        private readonly string jsonpath = "rules.json";
        //private readonly string jsonpath = "test.json";
        public string result;
        public void LoadRules()
        {
            try
            {
                string jsonconfiguration;
                using (var reader = new StreamReader(jsonpath))
                {
                    jsonconfiguration = reader.ReadToEnd();
                }
                Rule r = JsonConvert.DeserializeObject<Rule>(jsonconfiguration);
                //Test r = JsonConvert.DeserializeObject<Test>(jsonconfiguration);
                //dynamic c = JsonConvert.DeserializeObject(jsonconfiguration);
                dynamic c = JsonConvert.DeserializeObject(jsonconfiguration);
                //r.rules.ToArray();
                c.rules.ToArray();
                r.rules.ToArray();

                r.ToString();
                
               
               
            }
            catch (Exception ex)
            {

            }
            

        }

    }
    
}
