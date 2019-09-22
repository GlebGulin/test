using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebR.Models.Rules;

namespace WebR
{
    public static class Parser
    {
       
        private static readonly string jsonpath = "rules.json";
        
        public static Rules LoadRules()
        {
            Rules r = new Rules();
            try
            {
                string jsonconfiguration;
                using (var reader = new StreamReader(jsonpath))
                {
                    jsonconfiguration = reader.ReadToEnd();
                }
                r = JsonConvert.DeserializeObject<Rules>(jsonconfiguration);

                
            }
            catch (FileNotFoundException)
            {
                r = null;

            }
            return r;
        }

    }
    
}
