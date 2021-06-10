using FilmLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Repository
{
    public class ReviewRepository
    {
        private readonly FilmContext filmContext;
        public ReviewRepository(FilmContext filmContext)
        {
            this.filmContext = filmContext;
        }

        public IEnumerable<Review> Genres => filmContext.Reviews;
    }
}
