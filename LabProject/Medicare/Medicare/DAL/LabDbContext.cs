using Medicare.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicare.DAL
{
    public class LabDbContext:DbContext
    {
        public LabDbContext(DbContextOptions<LabDbContext> options):base(options){}
        public DbSet<WellComing> WellComings { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }

    }
}
