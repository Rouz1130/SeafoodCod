using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeafoodCod.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SeafoodCod.Controllers
{
    public class MarketingController : Controller
    {
        private ApplicationDbContext _db;

        public MarketingController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Marketing.ToList());
        }
    }
}
