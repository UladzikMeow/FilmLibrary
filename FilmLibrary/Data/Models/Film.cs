using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Models
{
    public class Film
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string MovieImg { get; set; }
        public string Description { get; set; }

        public virtual List<Actor> Actors { get; set; } = new List<Actor>();
        public virtual List<Genre> Genres { get; set; } = new List<Genre>();
     
    }
}
