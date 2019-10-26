using Core.Entities;
using Core.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class UserBookRepository : Repository<UserBook>, IUserBookRepository
    {
        internal UserBookRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public List<UserBook> FindByUserId(int userId)
        {
            return Set.Where(x => x.UserId == userId).ToList();
        }

        public async Task<List<UserBook>> FindByUserIdAsync(int userId)
        {
            return await Set.Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<List<UserBook>> FindByUserIdAsync(CancellationToken cancellationToken, int userId)
        {
            return await Set.Where(x => x.UserId == userId).ToListAsync(cancellationToken);
        }

        public List<UserBook> GetUserBooksAndBooks(int userId)
        {
            return Set.Where(x => x.UserId == userId).Include(x => x.Book).ToList();
        }

        public async Task<List<UserBook>> GetUserBooksAndBooksAsync(int userId)
        {
            return await Set.Where(x => x.UserId == userId).Include(x => x.Book).ToListAsync();
        }

        public async Task<List<UserBook>> GetUserBooksAndBooksAsync(CancellationToken cancellationToken, int userId)
        {
            return await Set.Where(x => x.UserId == userId).Include(x => x.Book).ToListAsync();
        }
    }
}
