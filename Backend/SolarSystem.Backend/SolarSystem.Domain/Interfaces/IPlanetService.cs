using SolarSystem.Domain.Entities;

namespace SolarSystem.Domain.Interfaces
{
    public interface IPlanetService
    {
        Task<IEnumerable<IPlanet>> GetAll();

        Task<IPlanet?> GetById(int id);
    }
}