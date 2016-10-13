using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mappi.Models;
using System.ComponentModel.DataAnnotations;

namespace Mappi.Controllers
{

    /// <summary>
    /// Information about vehicles
    /// </summary>
    [Route("api/Vehicles")]
    public class VehiclesController : Controller
    {

        /// <summary>
        /// Get information about all vehicles in the area
        /// </summary>
        /// <param name="minx">Minimum longitude of the area times 100 000</param>
        /// <param name="miny">Minimum latitude of the area times 100 000</param>
        /// <param name="maxx">Maximum longitude of the area times 100 000</param>
        /// <param name="maxy">Maximum latitude of the area times 100 000</param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Vehicle> Get(
            [FromQuery, Required] long minx, 
            [FromQuery, Required] long miny, 
            [FromQuery, Required] long maxx,
            [FromQuery, Required] long maxy)
        {
            return new List<Vehicle> { new Vehicle { Direction = 48, Name = "Test", X = 12123, Y = 123898 } };
        }

     }
}
