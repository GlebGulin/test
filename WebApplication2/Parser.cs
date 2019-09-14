using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebRules.Models.Rules;

namespace WebRules
{
    public class Parser
    {
        public Parser()
        {
            string _result = result;
        }
        private readonly string jsonpath = "rules.json";
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
                dynamic c = JsonConvert.DeserializeObject(jsonconfiguration);
                r.rules.ToArray();
                c.rules.ToArray();
               
               
            }
            catch (Exception ex)
            {

            }
            

        }

    }
    
}
