using FilmLibrary.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FilmLibrary.Controllers
{
    public class UserAccountController : Controller
    {

        RoleManager<IdentityRole> _roleManager;
        UserManager<User> _userManager;
        public UserAccountController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
       
        [Authorize]
        public IActionResult UserIndex()
        {
            return View(_userManager.Users.ToList());
        }
    }
}
