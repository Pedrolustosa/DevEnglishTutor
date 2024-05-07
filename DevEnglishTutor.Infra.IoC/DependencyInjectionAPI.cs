using DevEnglishTutor.Domain.Interface;
using DevEnglishTutor.Infra.Repositories;
using Microsoft.Extensions.Configuration;
using DevEnglishTutor.Application.Service;
using DevEnglishTutor.Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DevEnglishTutor.Infra.IoC
{
    public static class DependencyInjectionAPI
    {
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
