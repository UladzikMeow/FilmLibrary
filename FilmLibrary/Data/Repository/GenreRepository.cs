using FilmLibrary.Data.Interfaces;
using FilmLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Repository
{
    public class GenreRepository : IGenre
    {
        private readonly FilmContext filmContext;
        public GenreRepository(FilmContext filmContext)
        {
            this.filmContext = filmContext;
        }

        public IEnumerable<Genre> Genres => filmContext.Genres;
    }
}
