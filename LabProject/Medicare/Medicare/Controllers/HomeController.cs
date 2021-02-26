using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medicare.DAL;
using Medicare.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Medicare.Controllers
{
    public class HomeController : Controller
    {
        private readonly LabDbContext _db;
        public HomeController(LabDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                WellComing=_db.WellComings.FirstOrDefault(),
                Features=_db.Features.Take(3).ToList(),
                Services=_db.Services.Take(3).ToList(),
                Blogs=_db.Blogs.Include(b=>b.BlogTags).ToList()

            };
            
            return View(homeVM);
        }
    }
}