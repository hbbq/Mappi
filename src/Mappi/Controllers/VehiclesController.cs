using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mappi.Controllers
{
    [Route("api/Vehicles")]
    public class VehiclesController : Controller
    {

        [HttpGet]
        public IEnumerable<string> Get(
            [FromQuery] long minx, [FromQuery] long miny, [FromQuery] long maxx, [FromQuery] long maxy)
        {
            return new string[] { "1", "2", "3" };
        }

     }
}
