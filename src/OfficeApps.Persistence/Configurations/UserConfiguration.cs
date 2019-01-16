using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OffieApps.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeApps.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(u => u.Delegations)
                .WithOne(u => u.User)
                .HasForeignKey(f => f.UserId);
        }
    }
}
