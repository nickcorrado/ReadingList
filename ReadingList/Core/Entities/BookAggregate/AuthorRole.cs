using System;

namespace Core.Entities.BookAggregate
{
    public class AuthorRole
    {
        public AuthorRole(string role)
        {
            if (string.IsNullOrWhiteSpace(role))
                throw new ArgumentException("Role cannot be null.", nameof(role));

            Role = role;
        }

        public int AuthorRoleId { get; set; }
        public string Role { get; set; }
    }
}
