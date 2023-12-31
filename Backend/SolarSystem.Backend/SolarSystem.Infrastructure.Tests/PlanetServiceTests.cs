using FluentAssertions;
using Moq;
using SolarSystem.Domain.Entities;
using SolarSystem.Domain.Interfaces;
using SolarSystem.Infrastructure.Services;

namespace SolarSystem.Infrastructure.Tests
{
    public class Tests
    {
        private Mock<IPlanetRepository> _planetRepositoryMock;
        private PlanetService _planetService;

        [SetUp]
        public void SetUp()
        {
            _planetRepositoryMock = new Mock<IPlanetRepository>();
            _planetService = new PlanetService(_planetRepositoryMock.Object);
        }

        [Test]
        public async Task GetById_WhenPlanetExists_ReturnsCorrectPlanet()
        {
            // Arrange
            var expectedPlanet = new Planet { Id = 1, Name = "Mercury" };

            _planetRepositoryMock.Setup(x => x.GetById(It.IsAny<int>())).ReturnsAsync(expectedPlanet);

            // Act
            var result = await _planetService.GetById(1);

            // Assert
            result.Name.Should().Be(expectedPlanet.Name);
            _planetRepositoryMock.Verify(x => x.GetById(1), Times.Once);
        }

        [Test]
        public async Task GetById_WhenPlanetDoesNotExist_ReturnsNull()
        {
            // Arrange
            _planetRepositoryMock.Setup(x => x.GetById(It.IsAny<int>())).ReturnsAsync((Planet)null);

            // Act
            var result = await _planetService.GetById(2);

            // Assert
            result.Should().BeNull();
            _planetRepositoryMock.Verify(x => x.GetById(2), Times.Once);
        }

        [Test]
        public async Task GetAll_WhenPlanetsExist_ReturnsAllPlanets()
        {
            // Arrange
            var expectedPlanets = new List<Planet>
            {
                new Planet { Id = 1, Name = "Mercury" },
                new Planet { Id = 2, Name = "Venus" },
                new Planet { Id = 3, Name = "Earth" },
                new Planet { Id = 4, Name = "Mars" },
                new Planet { Id = 5, Name = "Jupiter" },
                new Planet { Id = 6, Name = "Saturn" },
                new Planet { Id = 7, Name = "Uranus" },
                new Planet { Id = 8, Name = "Neptune" }
            };

            _planetRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(expectedPlanets);

            // Act
            var result = await _planetService.GetAll();

            // Assert
            result.Should().BeEquivalentTo(expectedPlanets);
            _planetRepositoryMock.Verify(x => x.GetAll(), Times.Once);
        }
    }
}