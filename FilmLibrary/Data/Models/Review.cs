using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Models
{
    public class Review
    {
        public int id { get; set; }
        public string ReviewText { get; set; }
        public virtual User User { get; set; }
        public virtual Film Film { get; set; }
    }
}
