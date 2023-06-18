using SolarSystem.Domain.Interfaces;

namespace SolarSystem.Infrastructure.Data
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly SolarSystemContext _context;

        public PlanetRepository(SolarSystemContext context)
        {
            _context = context;
        }

        public IEnumerable<IPlanet> GetAll()
        {
            return _context.Planets.ToList();
        }

        public IPlanet GetById(int id)
        {
            return _context.Planets.Find(id);
        }
    }
}