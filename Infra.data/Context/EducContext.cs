using Domain.Entidades;
using Domain.Entidades.basic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.data.Context
{
    public class EducContext : DbContext
    {  
        public EducContext(DbContextOptions<EducContext> options): base(options)
        {
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ConvertToUtc();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void ConvertToUtc()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).Updated_At = DateTime.UtcNow;
 
                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).Created_At = DateTime.UtcNow;
                }
            }
        }

        public DbSet<User> Users { get; set; }

    }
}
