using FluentAssertions;
using SolarSystem.Domain.Entities;

namespace SolarSystem.Domain.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateSurfaceArea_WithEarthLikeProperties_ReturnsCorrectSurfaceArea()
        {
            // Arrange
            var planet = new Planet
            {
                Id = 1,
                Name = "Earth",
                Diameter = 12756
            };
            var expectedSurfaceArea = 510072000; // Earth's surface area in km²

            // Act
            var result = planet.CalculateSurfaceArea();

            // Assert
            result.Should().BeApproximately(expectedSurfaceArea, 1.2e7); // Allow a margin of 1,200,000 km²
        }
    }
}