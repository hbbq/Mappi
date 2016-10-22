using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Mappi.Controllers
{
    [Route("api/Test")]
    [Microsoft.AspNetCore.Cors.EnableCors("AllAllowed")]
    public class TestController : Controller
    {
        
        // GET api/values/5
        [HttpGet]
        public string Get(string value)
        {
            if (value.ToLowerInvariant() == "ping") return "Pong";
            return value;
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]string value)
        {
            return "";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
