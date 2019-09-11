using Newtonsoft.Json;
using System;
using System.IO;


namespace TestPars
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();
            parser.LoadRules();
            string k = parser.result;

            Console.WriteLine(k);
            Console.ReadKey();
        }
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
                    dynamic array = JsonConvert.DeserializeObject(jsonconfiguration);
                    foreach (var item in array)
                    {
                        result = item.rules;
                    }
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}
