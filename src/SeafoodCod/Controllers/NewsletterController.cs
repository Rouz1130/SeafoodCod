using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SeafoodCod.Models;
using Microsoft.AspNetCore.Identity;

// this controller is too manage our newsletter.

namespace SeafoodCod.Controllers
{
    // Authorize attribute allows access to the controller only if a user is logged in.
    [Authorize]
    public class NewsletterController : Controller
    {
        // Private instance of our Databse to work with, we need the userManager to work with users.
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public NewsletterController (UserManager <ApplicationUser> userManager, ApplicationDbContext db)
        {
            
            _userManager = userManager;
            _db = db;
        }        

        public IActionResult Index()
        {
            return View();
        }
    }
}
