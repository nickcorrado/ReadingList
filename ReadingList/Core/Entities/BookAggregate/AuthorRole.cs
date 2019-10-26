using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.BookAggregate
{
    public class AuthorRole
    {
        public AuthorRole(string role)
        {
            Role = role;
        }

        public int AuthorRoleId { get; set; }
        public string Role { get; set; }
    }
}
