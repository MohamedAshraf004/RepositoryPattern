using RepositoryPattern.Data;
using RepositoryPattern.Models;


namespace RepositoryPattern.Repositories
{
    public class EfCoreStarRepository : EfCoreRepository<Star, AppDbContext>
    {
        public EfCoreStarRepository(AppDbContext context) : base(context)
    {

    }
}
}
