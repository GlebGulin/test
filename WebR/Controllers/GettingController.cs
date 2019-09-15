using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebR.Models.Body;
using WebR.Models.Rules;
using WebRules;

namespace WebR.Controllers
{
    [Route("api/[controller]")]
    //[Route("")]
    [ApiController]
    public class GettingController : ControllerBase
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
        // GET: api/Getting
        [HttpGet]
        public IEnumerable<object> Get()
        {
            object b = LoadRules();
            
            
            
            return new object[] { b };
        }

        // GET: api/Getting/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Getting
        [HttpPost]
        public void Post([FromBody] Project project)
        {
            //return project;

        }

        // PUT: api/Getting/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
       
    }
}
