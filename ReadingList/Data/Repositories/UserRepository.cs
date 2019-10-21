using Core.Entities;
using Core.Repositories;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class UserRepository : Repository<User>, IUserRepository
    {
        internal UserRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public User FindByEmail(string email)
        {
            return Set.FirstOrDefault(x => x.Email == email);
        }

        public async Task<User> FindByEmailAsync(string email)
        {
            return await Set.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<User> FindByEmailAsync(CancellationToken cancellationToken, string email)
        {
            return await Set.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }

        public User FindByUserName(string username)
        {
            return Set.FirstOrDefault(x => x.UserName == username);
        }

        public async Task<User> FindByUserNameAsync(string username)
        {
            return await Set.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<User> FindByUserNameAsync(CancellationToken cancellationToken, string username)
        {
            return await Set.FirstOrDefaultAsync(x => x.UserName == username, cancellationToken);
        }
    }
}
