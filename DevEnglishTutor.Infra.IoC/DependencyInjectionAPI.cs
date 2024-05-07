using DevEnglishTutor.Domain.Interface;
using DevEnglishTutor.Infra.Repositories;
using Microsoft.Extensions.Configuration;
using DevEnglishTutor.Application.Service;
using DevEnglishTutor.Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DevEnglishTutor.Infra.IoC
{
    /// <summary>
    /// The dependency injection API.
    /// </summary>
    public static class DependencyInjectionAPI
    {
        /// <summary>
        /// Add infrastructure API.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>An IServiceCollection</returns>
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)
        {
            //Repositories
            services.AddScoped<IDevEnglishTutorRepository, DevEnglishTutorRepository>();

            //Serices
            services.AddScoped<IDevEnglishTutorService, DevEnglishTutorService>();
            return services;
        }
    }
}
