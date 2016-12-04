using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SeafoodCod.Models
{
    public class ApplicationUser : IdentityUser
    {
    }
}

//Identity is a system for managing users. Identity comes with a class to represent users, named *IdentityUser.//
// ApplicationUser is a class that extends from IdentityUser to serve as one of the models in our application.//