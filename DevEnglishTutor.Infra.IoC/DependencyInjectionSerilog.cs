using Serilog;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevEnglishTutor.Infra.IoC
{
    /// <summary>
    /// The dependency injection serilog.
    /// </summary>
    public static class DependencyInjectionSerilog
    {
        /// <summary>
        /// Add infrastructure serilog.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <param name="appName">The app name.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns>An IServiceCollection</returns>
        public static IServiceCollection AddInfrastructureSerilog(this IServiceCollection services, IConfiguration configuration, string appName)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            return services;
        }
    }
}
