using FilmLibrary.Data.Interfaces;
using FilmLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Repository
{
    public class ActorRepository : IActor
    {
        private readonly FilmContext filmContext;
        public ActorRepository(FilmContext filmContext)
        {
            this.filmContext = filmContext;
        }
        public IEnumerable<Actor> Actors => filmContext.Actors;
    }
    
}
