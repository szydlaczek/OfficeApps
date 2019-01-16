using OffieApps.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace OffieApps.Domain.Delegations
{
    public class Delegation
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string ChiefId { get; set; }
        public virtual User Chief { get; set; }
        public string CancelledByUserId { get; set; }
        public virtual User CancelledByUser { get; set; }
        public string AcceptedByUserId { get; set; }
        public virtual User AcceptedByUser { get; set; }
        public DelegationStatus Status { get; set; }
        public ICollection<DelegationOperationItem> OperationHistory { get; set; }
    }
}
