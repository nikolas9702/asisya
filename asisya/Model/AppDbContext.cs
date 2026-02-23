using Microsoft.EntityFrameworkCore;
using ProviderOptimizer.Domain;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ProviderOptimizer.API.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Provider> Providers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>()
                .Property(p => p.RowVersion)
                .IsRowVersion();
        }
    }
}
