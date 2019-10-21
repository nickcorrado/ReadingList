using Core.Entities;

namespace Data.Repositories
{
    internal class AuthorRepository : Repository<Author>
    {
        internal AuthorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
