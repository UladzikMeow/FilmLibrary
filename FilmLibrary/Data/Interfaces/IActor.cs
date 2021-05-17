using FilmLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Interfaces
{
    public interface IActor
    {
        IEnumerable<Actor> Actors { get; }
    }
}
