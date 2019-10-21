using Core.Entities;
using System.Collections.Generic;
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
