using SolarSystem.Domain.Interfaces;
using SolarSystem.Infrastructure.Data;

namespace SolarSystem.Infrastructure.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly SolarSystemContext _context;

        public PlanetService(SolarSystemContext context)
        {
            _context = context;
        }

        public IEnumerable<IPlanet> GetAll()
        {
            var results = _context.Planets;
            return results;
        }

        public IPlanet? GetById(int id)
        {
            var result = _context.Planets.Find(id);
            return result;
        }
    }
}