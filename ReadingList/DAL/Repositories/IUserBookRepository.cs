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
        UserBook FindByUserId(int userId);
        Task<UserBook> FindByUserIdAsync(int userId);
        Task<UserBook> FindByUserIdAsync(CancellationToken cancellationToken, int userId);
    }
}
