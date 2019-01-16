using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OffieApps.Domain.Delegations;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeApps.Persistence.Configurations
{
    public class DelegationConfiguration : IEntityTypeConfiguration<Delegation>
    {
        public void Configure(EntityTypeBuilder<Delegation> builder)
        {
            builder.HasKey(d => d.Id);
            builder.HasOne(d => d.User)
                .WithMany(a => a.Delegations)
                .HasForeignKey(f => f.UserId);

            builder.HasOne(d => d.AcceptedByUser)
                .WithMany(a => a.Delegations)
                .HasForeignKey(f => f.AcceptedByUserId);

            builder.HasOne(d => d.CancelledByUser)
                .WithMany(a => a.Delegations)
                .HasForeignKey(f => f.CancelledByUserId);
        }
    }
}
