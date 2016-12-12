using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeafoodCod.Models;
using Microsoft.AspNetCore.Identity;
using SeafoodCod.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

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
            return View();
        }

        public IActionResult MarketingEdit()
        {
            return View();
        }

        
        }
    }

