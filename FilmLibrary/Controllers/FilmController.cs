using FilmLibrary.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace FilmLibrary.Controllers
{
    public class FilmController : Controller
    {
        FilmContext db;
        public FilmController(FilmContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Films.ToList());
        }

        [HttpGet]
        public IActionResult Watch(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            Film film = db.Films.Find(id);
            return View(film);
        }

        [HttpPost]
        public IActionResult Serch(string Title)
        {
            List<Film> serchedFilms = new List<Film>();
            foreach(Film film in db.Films)
            {
                if(film.Title == Title)
                {
                    serchedFilms.Add(film);
                }
            }
            return View(serchedFilms);
        }

    }
}
