using System.Collections.Generic;

namespace Core.Entities
{
    public class Role
    {
        private ICollection<User> _users;

        public int RoleId { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users
        {
            get { return _users ?? (_users = new List<User>()); }
            set { _users = value; }
        }
    }
}
