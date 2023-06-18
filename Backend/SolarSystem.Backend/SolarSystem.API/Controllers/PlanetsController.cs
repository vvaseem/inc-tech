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
        public async Task<IActionResult> Get()
        {
            var results = await _planetService.GetAll();
            if (results == null)
                return NotFound();

            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("Id must be a positive number");

            var result = await _planetService.GetById(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}