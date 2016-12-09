using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeafoodCod.Models;

namespace SeafoodCod.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ApplicationUser Title { get; internal set; }
    }
}
