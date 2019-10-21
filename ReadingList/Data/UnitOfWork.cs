using Core;
using Core.Entities;
using Core.Repositories;
using Data.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IExternalLoginRepository _externalLoginRepository;
        private IRoleRepository _roleRepository;
        private IUserRepository _userRepository;
        private IBookRepository _bookRepository;
        private ITagRepository _tagRepository;
        private IUserBookRepository _userBookRepository;
        private IRepository<Author> _authorRepository;
        private IRepository<BookAuthor> _bookAuthorRepository;
        private IRepository<Lection> _lectionRepository;

        public UnitOfWork(string nameOrConnectionString) => _context = new ApplicationDbContext(nameOrConnectionString);

        public IExternalLoginRepository ExternalLoginRepository => _externalLoginRepository ?? (_externalLoginRepository = new ExternalLoginRepository(_context));

        public IRoleRepository RoleRepository => _roleRepository ?? (_roleRepository = new RoleRepository(_context));

        public IUserRepository UserRepository => _userRepository ?? (_userRepository = new UserRepository(_context));

        public IBookRepository BookRepository => _bookRepository ?? (_bookRepository = new BookRepository(_context));

        public ITagRepository TagRepository => _tagRepository ?? (_tagRepository = new TagRepository(_context));

        public IUserBookRepository UserBookRepository => _userBookRepository ?? (_userBookRepository = new UserBookRepository(_context));

        public IRepository<Author> AuthorRepository => _authorRepository ?? (_authorRepository = new AuthorRepository(_context));

        public IRepository<BookAuthor> BookAuthorRepository => _bookAuthorRepository ?? (_bookAuthorRepository = new BookAuthorRepository(_context));

        public IRepository<Lection> LectionRepository => _lectionRepository ?? (_lectionRepository = new LectionRepository(_context));

        public int SaveChanges() => _context.SaveChanges();

        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken) => await _context.SaveChangesAsync(cancellationToken);

        public void Dispose()
        {
            _externalLoginRepository = null;
            _roleRepository = null;
            _userRepository = null;
            _bookRepository = null;
            _tagRepository = null;
            _userBookRepository = null;
            _authorRepository = null;
            _bookAuthorRepository = null;
            _lectionRepository = null;
            _context.Dispose();
        }
    }
}
