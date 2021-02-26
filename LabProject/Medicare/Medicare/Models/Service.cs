using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medicare.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(300)]
        public string Description { get; set; }
        [Required, StringLength(100)]
        public string ServiceIcon { get; set; }
    }
}
