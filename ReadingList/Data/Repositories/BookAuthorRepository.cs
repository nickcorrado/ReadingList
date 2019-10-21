using Core.Entities;

namespace Data.Repositories
{
    internal class BookAuthorRepository : Repository<BookAuthor>
    {
        internal BookAuthorRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
