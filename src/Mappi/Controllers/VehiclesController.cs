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
    [Microsoft.AspNetCore.Cors.EnableCors("AllAllowed")]
    public class VehiclesController : Controller
    {

        private Connectors.VT.Service GetVTService()
        {
            return new Connectors.VT.Service();
        }

        // 57983000 12433800
        // 57882000 12567700

        /// <summary>
        /// Get information about all vehicles in the area
        /// </summary>
        /// <param name="minx">?</param>
        /// <param name="miny">?</param>
        /// <param name="maxx">?</param>
        /// <param name="maxy">?</param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Vehicle> Get(
            [Required] long minx,
            [Required] long miny,
            [Required] long maxx,
            [Required] long maxy
        )
        {
            var ret = GetVTService().GetVehicles(minx, miny, maxx, maxy);
            return new List<Vehicle> { new Vehicle { Direction = 48, Name = "60", X = minx, Y = maxy, Type = "Buss" } };
        }

     }
}
