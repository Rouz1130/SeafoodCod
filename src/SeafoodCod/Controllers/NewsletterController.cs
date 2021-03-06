﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SeafoodCod.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;

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
        private readonly IHostingEnvironment _environement;


        public NewsletterController (UserManager <ApplicationUser> userManager, ApplicationDbContext db, IHostingEnvironment environment)
        {
            
            _userManager = userManager;
            _db = db;
            _environement = environment;
        }

        public async Task<IActionResult> Index()
        {
            var id = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(id);
            return View(_db.Newsletters.Where(x => x.User.Id == currentUser.Id));
            
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Newsletter newsletter)
        {
            
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var currentUser = await _userManager.FindByIdAsync(userId);

            newsletter.User = currentUser;
            _db.Newsletters.Add(newsletter);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}
