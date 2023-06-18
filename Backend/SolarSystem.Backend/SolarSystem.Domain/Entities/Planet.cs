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

        public double CalculateSurfaceArea()
        {
            double radius = Diameter / 2.0;
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }
}