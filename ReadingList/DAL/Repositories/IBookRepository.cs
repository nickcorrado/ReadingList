using Core.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Book FindByTitle(string title);
        Task<Book> FindByTitleAsync(string title);
        Task<Book> FindByTitleAsync(CancellationToken cancellationToken, string title);
        List<Book> FindLikeTitle(string title);
        Task<List<Book>> FindLikeTitleAsync(string title);
        Task<List<Book>> FindLikeTitleAsync(CancellationToken cancellationToken, string title);
    }
}
