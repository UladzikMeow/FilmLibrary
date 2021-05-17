using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FilmLibrary.Data.Models
{
    public class FilmContext : IdentityDbContext<User>
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
