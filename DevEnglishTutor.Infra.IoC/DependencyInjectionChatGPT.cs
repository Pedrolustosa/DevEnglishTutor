using OpenAI_API;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevEnglishTutor.Infra.IoC
{
    /// <summary>
    /// The dependency injection chat GPT.
    /// </summary>
    public static class DependencyInjectionChatGPT
    {
        /// <summary>
        /// Add infrastructure chat GPT.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns>An IServiceCollection</returns>
        public static IServiceCollection AddInfrastructureChatGPT(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            var key = configuration["ChatGPT:Token"];
            var chat = new OpenAIAPI(key);
            services.AddSingleton(chat);
            return services;
        }
    }
}
