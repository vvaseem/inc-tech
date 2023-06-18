namespace SolarSystem.Domain.Interfaces
{
    public interface IPlanetRepository
    {
        IEnumerable<IPlanet> GetAll();

        IPlanet GetById(int id);
    }
}