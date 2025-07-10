using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using LadysmithProperties.Model;

namespace LadysmithProperties.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Renting> Rentings { get; set; }
        public DbSet<Tenant> Tenants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Accommodation>().ToTable("Accommodation");
            modelBuilder.Entity<Renting>().ToTable("Renting");
            modelBuilder.Entity<Tenant>().ToTable("Tenant");
        }
    }
}
