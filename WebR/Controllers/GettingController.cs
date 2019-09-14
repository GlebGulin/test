using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebR.Models.Body;
using WebRules;

namespace WebR.Controllers
{
    [Route("api/[controller]")]
    //[Route("")]
    [ApiController]
    public class GettingController : ControllerBase
    {
        // GET: api/Getting
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Parser p = new Parser();
            p.LoadRules();
            return new string[] { "value1", "value2" };
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
