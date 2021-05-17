using FilmLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Interfaces
{
    public interface IUser
    {
        IEnumerable<User> Users { get; }
        User GetUser(string userId);

    }
}
