using Core.Entities;
using Core.Repositories;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class TagRepository : Repository<Tag>, ITagRepository
    {
        internal TagRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Tag FindByName(string tagName)
        {
            return Set.FirstOrDefault(x => x.TagName == tagName);
        }

        public async Task<Tag> FindByNameAsync(string tagName)
        {
            return await Set.FirstOrDefaultAsync(x => x.TagName == tagName);
        }

        public async Task<Tag> FindByNameAsync(CancellationToken cancellationToken, string tagName)
        {
            return await Set.FirstOrDefaultAsync(x => x.TagName == tagName, cancellationToken);
        }
    }
}
