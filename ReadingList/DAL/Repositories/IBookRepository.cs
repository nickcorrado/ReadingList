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
        IList<Book> FindLikeTitle(string title);
        Task<IList<Book>> FindLikeTitleAsync(string title);
        Task<IList<Book>> FindLikeTitleAsync(CancellationToken cancellationToken, string title);
    }
}
