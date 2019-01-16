using OffieApps.Domain.Delegations;
using System;
using System.Collections.Generic;
using System.Text;

namespace OffieApps.Domain.Shared
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string SO_ID { get; set; }
        public string Card_UID { get; set; }
        public byte[] Signature { get; set; }
        public virtual ICollection<Delegation> Delegations { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }

    }
}
