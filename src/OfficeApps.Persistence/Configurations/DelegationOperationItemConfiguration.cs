using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OffieApps.Domain.Delegations;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeApps.Persistence.Configurations
{
    public class DelegationOperationItemConfiguration : IEntityTypeConfiguration<DelegationOperationItem>
    {
        public void Configure(EntityTypeBuilder<DelegationOperationItem> builder)
        {
            builder.HasOne(d => d.Delegation)
                .WithMany(dg => dg.OperationHistory)
                .HasForeignKey(f => f.DelegationId);

            builder.HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(f => f.UserId);
        }
    }
}
