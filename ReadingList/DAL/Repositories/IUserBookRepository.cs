using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IUserBookRepository : IRepository<UserBook>
    {
        List<UserBook> FindByUserId(int userId);
        Task<List<UserBook>> FindByUserIdAsync(int userId);
        Task<List<UserBook>> FindByUserIdAsync(CancellationToken cancellationToken, int userId);
    }
}
