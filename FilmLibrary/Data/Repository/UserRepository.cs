/*using FilmLibrary.Data.Interfaces;
using FilmLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Repository
{
    public class UserRepository : IUser
    {

        private readonly FilmContext filmContext;
        public UserRepository(FilmContext filmContext)
        {
            this.filmContext = filmContext;
        }

        public IEnumerable<User> Users => filmContext.Users;
        public User GetUser(string userId) => filmContext.Users.FirstOrDefault(u => u.Id == userId);
    }
}*/