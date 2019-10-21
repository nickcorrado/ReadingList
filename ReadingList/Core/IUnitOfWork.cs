using Core.Entities;
using Core.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWork : IDisposable
    {
        //iffy on these; do they all need to exist? claims doesn't
        IExternalLoginRepository ExternalLoginRepository { get; }
        IRoleRepository RoleRepository { get; }
        IUserRepository UserRepository { get; }

        IBookRepository BookRepository { get; }
        ITagRepository TagRepository { get; }
        IUserBookRepository UserBookRepository { get; }
        IRepository<Author> AuthorRepository { get; }
        IRepository<BookAuthor> BookAuthorRepository { get; }
        IRepository<Lection> LectionRepository { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
