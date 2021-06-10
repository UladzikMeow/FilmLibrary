using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Models
{
    public class User : IdentityUser
    {
        public virtual List<Review> Review { get; set; } = new List<Review>();
    }
}
