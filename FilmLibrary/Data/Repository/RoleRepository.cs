/*using FilmLibrary.Data.Interfaces;
using FilmLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Repository
{
    public class RoleRepository : IRole
    {
        private readonly FilmContext filmContext;
        public RoleRepository(FilmContext filmContext)
        {
            this.filmContext = filmContext;
        }
        public IEnumerable<Roles> Roles => filmContext.Roles;
    }
}
*/