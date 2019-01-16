using Microsoft.EntityFrameworkCore;
using OffieApps.Domain.Delegations;
using OffieApps.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeApps.Persistence
{
    public class OfficeDbContext : DbContext
    {
        public OfficeDbContext(DbContextOptions<OfficeDbContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Delegation> Delegations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OfficeDbContext).Assembly);
        }
    }
}
