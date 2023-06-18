namespace SolarSystem.Domain.Interfaces
{
    public interface IPlanet
    {
        int Id { get; set; }
        string Name { get; set; }
        double Diameter { get; set; }
        double DistanceFromSun { get; set; }
        string Image { get; set; }
        double Mass { get; set; }

        double CalculateSurfaceArea();
    }
}