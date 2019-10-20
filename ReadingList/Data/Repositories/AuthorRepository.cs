using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class AuthorRepository : Repository<Author>
    {
        internal AuthorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
