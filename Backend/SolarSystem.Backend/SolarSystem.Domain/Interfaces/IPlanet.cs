namespace SolarSystem.Domain.Interfaces
{
    public interface IPlanet
    {
        int Diameter { get; set; }
        int DistanceFromSun { get; set; }
        int Id { get; set; }
        string ImageURL { get; set; }
        int Mass { get; set; }
        string Name { get; set; }
    }
}