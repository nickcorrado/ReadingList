using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Claim
    {
        private User _user;

        public virtual int ClaimId { get; set; }
        public virtual int UserId { get; set; }
        public virtual string ClaimType { get; set; }
        public virtual string ClaimValue { get; set; }

        public virtual User User
        {
            get { return _user; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                _user = value;
                UserId = value.UserId;
            }
        }
    }
}
