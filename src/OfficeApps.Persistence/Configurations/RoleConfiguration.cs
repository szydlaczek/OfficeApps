using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OffieApps.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeApps.Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasMany(u => u.UserRoles)
                .WithOne(r => r.Role)
                .HasForeignKey(d => d.RoleId);
        }
    }
}
