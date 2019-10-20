using Core.Entities;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
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

        public Task<List<UserBook>> FindByUserIdAsync(int userId)
        {
            return Set.Where(x => x.UserId == userId).ToListAsync();
        }

        public Task<List<UserBook>> FindByUserIdAsync(CancellationToken cancellationToken, int userId)
        {
            return Set.Where(x => x.UserId == userId).ToListAsync(cancellationToken);
        }
    }
}
