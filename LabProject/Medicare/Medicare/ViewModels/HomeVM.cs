using Medicare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicare.ViewModels
{
    public class HomeVM
    {
        public WellComing WellComing { get; set; }
        public List<Feature> Features { get; set; }
        public List<Service> Services { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
