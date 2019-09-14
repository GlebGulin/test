using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRules.Models.Rules
{
    public class Rule
    {
        public List<Rules> rules { get; }
    }
    public class Rules
    {
        public string Operator { get; }
        public List<Conditions> Condition { get; }
        public List<Effects> Effect { get; }

    }
    public class Conditions
    {
        public string Key { get; }
        public string Condition { get; }
        public object Val { get; }

    }
    public class Effects
    {
        public string Type { get; }
        public int Template_id { get; }
        public Placeholders Placeholder { get; }

    }
    public class Placeholders
    {
        public string Id { get; }
        public string Descriprion { get; }
        public string Name { get; }
    }
}
