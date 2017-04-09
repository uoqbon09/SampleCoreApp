using Microsoft.EntityFrameworkCore;
using SampleCoreApp.Domain.Entities;

namespace SampleCoreApp.Domain
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        public SamuraiContext(DbContextOptions<SamuraiContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samurai>().ToTable("Samurai");
            modelBuilder.Entity<Battle>().ToTable("Battle");
            modelBuilder.Entity<Quote>().ToTable("Quote");
        }
    }


}