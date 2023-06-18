namespace SolarSystem.Domain.Interfaces
{
    public interface IPlanetRepository
    {
        Task<IEnumerable<IPlanet>> GetAll();
        Task<IPlanet> GetById(int id);
    }
}