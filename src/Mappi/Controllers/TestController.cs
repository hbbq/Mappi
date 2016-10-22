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
        
        // GET api/test
        [HttpGet]
        public string Get(string value)
        {
            if (value.ToLowerInvariant() == "ping") return "Pong";
            return value;
        }
        
    }
}
