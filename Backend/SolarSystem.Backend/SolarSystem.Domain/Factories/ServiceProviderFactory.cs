using Microsoft.Extensions.DependencyInjection;

namespace SolarSystem.Domain.Factories
{
    public static class ServiceProviderFactory
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static IServiceProvider CreateServiceProvider(IServiceCollection? serviceCollection)
        {
            return serviceCollection.BuildServiceProvider();
        }
    }
}