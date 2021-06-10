using FilmLibrary.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using System;

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

        [HttpGet]
        public IActionResult Serch(string Title)
        {
            List<Film> serchedFilms = new List<Film>();
            if (Title == null) return View(db.Films.ToList());
            foreach(Film film in db.Films)
            {
                if(film.Title.Contains(Title))
                {
                    serchedFilms.Add(film);
                }
            }
            return View(serchedFilms);
        }

        [HttpPost]
        public IActionResult addReview()
        {

            return RedirectToAction("Film/Watch");
        }
    }
}
