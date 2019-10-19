using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class BookRepository : Repository<Book>, IBookRepository
    {
        internal BookRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Book FindByTitle(string title)
        {
            return Set.FirstOrDefault(x => x.Title == title);
        }

        public Task<Book> FindByTitleAsync(string title)
        {
            return Set.FirstOrDefaultAsync(x => x.Title == title);
        }

        public Task<Book> FindByTitleAsync(CancellationToken cancellationToken, string title)
        {
            return Set.FirstOrDefaultAsync(x => x.Title == title, cancellationToken);
        }

        public List<Book> FindLikeTitle(string title)
        {
            return Set.Where(x => x.Title.Contains(title)).ToList();
        }

        public Task<List<Book>> FindLikeTitleAsync(string title)
        {
            return Set.Where(x => x.Title.Contains(title)).ToListAsync();
        }

        public Task<List<Book>> FindLikeTitleAsync(CancellationToken cancellationToken, string title)
        {
            return Set.Where(x => x.Title.Contains(title)).ToListAsync(cancellationToken);
        }
    }
}
