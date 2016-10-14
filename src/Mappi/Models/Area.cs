using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mappi.Models
{

    /// <summary>
    /// Area
    /// </summary>
    public class Area
    {

        /// <summary>
        /// Minimum latitude (times 1 000 000)
        /// </summary>
        [Required]
        public long MinLat { get; set; }

        /// <summary>
        /// Maximum latitude (times 1 000 000)
        /// </summary>
        [Required]
        public long MaxLat { get; set; }

        /// <summary>
        /// Minimum longitude (times 1 000 000)
        /// </summary>
        [Required]
        public long MinLon { get; set; }

        /// <summary>
        /// Maximum longitude (times 1 000 000)
        /// </summary>
        [Required]
        public long MaxLon { get; set; }

    }

}
