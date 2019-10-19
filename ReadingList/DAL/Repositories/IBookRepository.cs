using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Repositories
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
