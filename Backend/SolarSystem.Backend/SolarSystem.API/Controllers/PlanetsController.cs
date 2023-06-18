using Microsoft.AspNetCore.Mvc;
using SolarSystem.Domain.Interfaces;

namespace SolarSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetsController : ControllerBase
    {
        private readonly IPlanetService _planetService;

        public PlanetsController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var results = _planetService.GetAll();

            if (results == null)
                return NotFound();

            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _planetService.GetById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}