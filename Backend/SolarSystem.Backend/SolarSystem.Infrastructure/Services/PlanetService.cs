using SolarSystem.Domain.Interfaces;

namespace SolarSystem.Infrastructure.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public IEnumerable<IPlanet> GetAll()
        {
            var results = _planetRepository.GetAll();
            return results;
        }

        public IPlanet? GetById(int id)
        {
            var result = _planetRepository.GetById(id);
            return result;
        }
    }
}