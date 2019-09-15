using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebR.Models.Rules
{
    public class Rules
    {
        public List<Rule> rules { get; set; }
    }
    public class Rule
    {
        public string @operator { get; set; }
        public List<Condition> conditions { get; set; }
        public List<Effect> effects { get; set; }
    }
    public class Condition
    {
        public string key { get; set; }
        public string condition { get; set; }
        public object val { get; set; }
    }

    public class Effect
    {
        public string type { get; set; }
        public int template_id { get; set; }
        public Placeholders placeholders { get; set; }
    }
    public class Placeholders
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
