using Core.Entities.BookAggregate;

namespace Data.Repositories
{
    internal class AuthorRepository : Repository<Author>
    {
        internal AuthorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
