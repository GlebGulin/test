using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebRules.Models.Rules;

namespace WebRules.Controllers
{
    public class RestfullyController : Controller
    {
        public string Index()
        {
            Parser parser = new Parser();
            parser.LoadRules();
            string res = parser.result;
            //Rule r = new Rule();

            return res;
        }
    }
}