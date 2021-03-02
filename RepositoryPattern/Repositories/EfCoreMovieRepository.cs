using RepositoryPattern.Data;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repositories
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, AppDbContext>
    {
        public EfCoreMovieRepository(AppDbContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here if I want
    }
}
