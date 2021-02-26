using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medicare.Models
{
    public class WellComing
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,StringLength(100)]

        public string Title { get; set; }
        [Required, StringLength(400)]

        public string Description { get; set; }
    }
}
