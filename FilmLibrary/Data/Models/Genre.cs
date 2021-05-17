using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Models
{
    public class Genre
    {
        public int id { get; set; }
        public string Gener { get; set; }
        public virtual List<Film> Films {get; set;} = new List<Film>();
    }
}
