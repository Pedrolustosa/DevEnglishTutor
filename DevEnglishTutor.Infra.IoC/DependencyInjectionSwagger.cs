using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevEnglishTutor.Infra.IoC
{
    public static class DependencyInjectionSwagger
    {
        public static IServiceCollection AddInfrastructureSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "DevEnglishTutor.API",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Pedro Lustosa",
                        Email = "pedroeternalss@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/pedrolustosaengineer/")
                    }
                });
            });
            return services;
        }
    }
}
