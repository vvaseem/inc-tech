using SolarSystem.Domain.Entities;

namespace SolarSystem.Domain.Interfaces
{
    public interface IPlanetService
    {
        IEnumerable<IPlanet> GetAll();

        IPlanet? GetById(int id);
    }
}