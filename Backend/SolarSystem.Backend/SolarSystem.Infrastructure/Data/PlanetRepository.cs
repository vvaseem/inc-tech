using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<IPlanet>> GetAll()
        {
            return await _context.Planets.ToListAsync();
        }

        public async Task<IPlanet> GetById(int id)
        {
            return await _context.Planets.FindAsync(id);
        }
    }
}