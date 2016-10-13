using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mappi.Models
{

    /// <summary>
    /// Information about a vehicle
    /// </summary>
    public class Vehicle
    {

        /// <summary>
        /// Name of vehicle
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Current longitude of vehicle times 100 000
        /// </summary>
        [Required]
        public long X { get; set; }
        /// <summary>
        /// Current latitude of vehicle times 100 000
        /// </summary>
        [Required]
        public long Y { get; set; }
        /// <summary>
        /// The direction the vehicle is currently heading, in degrees (North is zero)
        /// </summary>
        [Required]
        public long Direction { get; set; }

    }

}
