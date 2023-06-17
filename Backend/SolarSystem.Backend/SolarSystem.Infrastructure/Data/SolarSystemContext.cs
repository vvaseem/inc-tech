using Microsoft.EntityFrameworkCore;
using SolarSystem.Domain.Entities;

namespace SolarSystem.Infrastructure.Data
{
    public class SolarSystemContext : DbContext
    {
        public SolarSystemContext(DbContextOptions<SolarSystemContext> options) : base(options)
        {
        }

        public DbSet<Planet> Planets { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>().HasData(
                new Planet { Id = 1, Name = "Mercury" },
                new Planet { Id = 2, Name = "Venus" });
        }
    }
}