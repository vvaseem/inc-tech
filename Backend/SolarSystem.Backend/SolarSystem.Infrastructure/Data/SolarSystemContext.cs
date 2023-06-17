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
                new Planet
                {
                    Id = 1,
                    Name = "Mercury",
                    Diameter = 4879,
                    DistanceFromSun = 57.9,
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Mercury_in_color_-_Prockter07-edit1.jpg/220px-Mercury_in_color_-_Prockter07-edit1.jpg",
                    Mass = 0.330
                },
                new Planet
                {
                    Id = 2,
                    Name = "Venus",
                    Diameter = 12104,
                    DistanceFromSun = 108.2,
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Venus-real_color.jpg/220px-Venus-real_color.jpg",
                    Mass = 4.87
                },
                new Planet
                {
                    Id = 3,
                    Name = "Earth",
                    Diameter = 12756,
                    DistanceFromSun = 149.6,
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/220px-The_Earth_seen_from_Apollo_17.jpg",
                    Mass = 5.97
                },
                new Planet
                {
                    Id = 4,
                    Name = "Mars",
                    Diameter = 6792,
                    DistanceFromSun = 227.9,
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/OSIRIS_Mars_true_color.jpg/220px-OSIRIS_Mars_true_color.jpg",
                    Mass = 0.642
                },
                new Planet
                {
                    Id = 5,
                    Name = "Jupiter",
                    Diameter = 142984,
                    DistanceFromSun = 778.6,
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg/220px-Jupiter_and_its_shrunken_Great_Red_Spot.jpg",
                    Mass = 1898
                },
                new Planet
                {
                    Id = 6,
                    Name = "Saturn",
                    Diameter = 120536,
                    DistanceFromSun = 1433.5,
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Saturn_during_Equinox.jpg/220px-Saturn_during_Equinox.jpg",
                    Mass = 568
                },
                new Planet
                {
                    Id = 7,
                    Name = "Uranus",
                    Diameter = 51118,
                    DistanceFromSun = 2872.5,
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/Uranus2.jpg/220px-Uranus2.jpg",
                    Mass = 86.8
                },
                new Planet
                {
                    Id = 8,
                    Name = "Neptune",
                    Diameter = 49528,
                    DistanceFromSun = 4495.1,
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Neptune_Full.jpg/220px-Neptune_Full.jpg",
                    Mass = 102
                }
                );
        }
    }
}