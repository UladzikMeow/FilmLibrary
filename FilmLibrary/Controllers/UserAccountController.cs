using FilmLibrary.Data.Models;
using Microsoft.AspNetCore.Authorization;
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
        FilmContext db;
        public UserAccountController(FilmContext context)
        {
            db = context;
        }

        public IActionResult UserIndex()
        {
            return View();
        }
    }
}
