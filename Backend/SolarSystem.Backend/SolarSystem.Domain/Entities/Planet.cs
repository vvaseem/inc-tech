using SolarSystem.Domain.Interfaces;

namespace SolarSystem.Domain.Entities
{
    public class Planet : IPlanet
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DistanceFromSun { get; set; }
        public int Diameter { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public int Mass { get; set; }
    }
}