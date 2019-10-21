using Core.Entities;

namespace Data.Repositories
{
    internal class LectionRepository : Repository<Lection>
    {
        internal LectionRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
