using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebR.Models.Rules
{
    public class Rule
    {
        public ICollection<Rules> rules { get; set; }
    }
    public class Rules
    {
        public string Operator { get; set; }
        public ICollection<Conditions> Condition { get; set; }
        public ICollection<Effects> Effect { get; set; }

    }
    public class Conditions
    {
        public string Key { get; set; }
        public string Condition { get; set; }
        public object Val { get; set; }

    }
    public class Effects
    {
        public string Type { get; set; }
        public int Template_id { get; set; }
        public Placeholders Placeholder { get; set; }

    }
    public class Placeholders
    {
        public string Id { get; set; }
        public string Descriprion { get; set ;}
        public string Name { get; set; }
    }
}
