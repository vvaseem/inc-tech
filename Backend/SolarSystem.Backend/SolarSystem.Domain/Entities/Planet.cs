using SolarSystem.Domain.Interfaces;

namespace SolarSystem.Domain.Entities
{
    public class Planet : IPlanet
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Diameter { get; set; }
        public double DistanceFromSun { get; set; }
        public string Image { get; set; } = string.Empty;
        public double Mass { get; set; }
    }
}