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

        public async Task<IEnumerable<IPlanet>> GetAll()
        {
            var results = await _planetRepository.GetAll();
            return results;
        }

        public async Task<IPlanet?> GetById(int id)
        {
            var result = await _planetRepository.GetById(id);
            return result;
        }
    }
}