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

        //These need to return some kind of aggregate entity, they won't work as written
        //a List<UserBookWithBook> item or something
        List<UserBook> GetUserBooksAndBooks(int userId);
        Task<List<UserBook>> GetUserBooksAndBooksAsync(int userId);
        Task<List<UserBook>> GetUserBooksAndBooksAsync(CancellationToken cancellationToken, int userId);
    }
}
