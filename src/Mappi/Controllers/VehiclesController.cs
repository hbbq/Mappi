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

        // 57983000 12433800
        // 57882000 12567700

        /// <summary>
        /// Get information about all vehicles in the area
        /// </summary>
        /// <param name="area">The area to search</param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Vehicle> Get([FromBody, Required] Area area)
        {
            return new List<Vehicle> { new Vehicle { Direction = 48, Name = "60", X = 12123, Y = 123898, Type = "Buss" } };
        }

     }
}
