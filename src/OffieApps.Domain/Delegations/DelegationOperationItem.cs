using System;
using System.Collections.Generic;
using System.Text;

namespace OffieApps.Domain.Delegations
{
    public class DelegationOperationItem
    {
        public int Id { get; set; }
        public string DelegationId { get; set; }
        public virtual Delegation Delegation { get; set; }
        public DateTime OperationDate { get; set; }
        public DelegationStatus StatusAssigned { get; set; }
        public string UserId { get; protected set; }

        public virtual User User { get; protected set; }
    }
}
