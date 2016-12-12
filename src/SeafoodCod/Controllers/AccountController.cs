using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SeafoodCod.Models;
using SeafoodCod.ViewModels;
using Microsoft.EntityFrameworkCore;
// Microsoft.EntityFrameworkCore allows access to EntityState.


namespace SeafoodCod.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private IEnumerable<IdentityError> myErrors { get; set; }

        // Dependency injection n the constructor to configure our services/
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        //Get: /<controllers>/
        // This is were we set up the Identity or user and Sign in services/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var user = new ApplicationUser { UserName = model.Email };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Errors");
            }
        }


        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Account");
            }
            else
            {
                return View("Errors");
            }
        }
        
        public IActionResult CreateMarketing()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateMarketing(Marketing marketing)
        {
            _db.Marketings.Add(marketing);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        // Get
        public IActionResult MarketingEdit(int id)
        {
            var thisMarket = _db.Marketings.FirstOrDefault(marketings => marketings.MarketingId == id);
            return View();
        }

        //Post
        [HttpPost]
        public IActionResult MarketingEdit(Marketing marketing)
        {
            // modify the individual entry with EntityState.Modified, saves the changes, and takes us back to marketingEdit.
            _db.Entry(marketing).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("MarketingEdit");
        }

        public IActionResult Errors()
        {
            return View();
        }


        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }            
        }
    }
