using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevEnglishTutor.Infra.IoC
{
    /// <summary>
    /// The dependency injection swagger.
    /// </summary>
    public static class DependencyInjectionSwagger
    {
        /// <summary>
        /// Add infrastructure swagger.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns>An IServiceCollection</returns>
        public static IServiceCollection AddInfrastructureSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);
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

        /// <summary>
        /// Add infrastructure swagger UI.
        /// </summary>
        /// <param name="app">The app.</param>
        /// <param name="appName">The app name.</param>
        public static void AddInfrastructureSwaggerUI(this IApplicationBuilder app, string appName)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", appName));
        }
    }
}
