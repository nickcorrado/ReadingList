using Core.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
        Tag FindByName(string tagName);
        Task<Tag> FindByNameAsync(string tagName);
        Task<Tag> FindByNameAsync(CancellationToken cancellationToken, string tagName);
    }
}
