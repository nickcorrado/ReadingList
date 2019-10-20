using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
