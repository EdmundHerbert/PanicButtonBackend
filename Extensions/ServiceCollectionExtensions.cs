using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PanicButtonBackend.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration, string migrationsAssembly)
        {

            services.AddApplicationDataContext(configuration, migrationsAssembly);

            return services;
        }

        public static void RegisterAllTypes<T>(this IServiceCollection services, Assembly[] assemblies,
       ServiceLifetime lifetime = ServiceLifetime.Transient)
        {
            var typesFromAssemblies = assemblies.SelectMany(a => a.DefinedTypes.Where(x => x.GetInterfaces().Contains(typeof(T))));
            foreach (var type in typesFromAssemblies)
                services.Add(new ServiceDescriptor(typeof(T), type, lifetime));
        }
    }
}
