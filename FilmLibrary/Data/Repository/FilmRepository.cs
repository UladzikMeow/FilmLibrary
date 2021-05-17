using FilmLibrary.Data.Interfaces;
using FilmLibrary.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Repository
{
    public class FilmRepository : IFilms
    {
        private readonly FilmContext filmContext;
        public FilmRepository(FilmContext filmContext)
        {
            this.filmContext = filmContext;
        }
        public IEnumerable<Film> Films => filmContext.Films.Include(c => c.id);
        public Film getObjectFilm(int id) => filmContext.Films.FirstOrDefault(p => p.id == id);
    }
}
    