using System.Text;
using System.Text.Json;
using DevEnglishTutor.Models;
using System.Net.Http.Headers;
using DevEnglishTutor.Domain.Interface;
using Microsoft.Extensions.Configuration;

namespace DevEnglishTutor.Infra.Repositories
{
    /// <summary>
    /// The dev english tutor repository.
    /// </summary>
    public class DevEnglishTutorRepository : IDevEnglishTutorRepository
    {
        /// <summary>
        /// The http client.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// The configuration.
        /// </summary>
        public readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="DevEnglishTutorRepository"/> class.
        /// </summary>
        /// <param name="httpClient">The http client.</param>
        public DevEnglishTutorRepository(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        /// <summary>
        /// Prompts the response.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><![CDATA[Task<string>]]></returns>
        public async Task<string> PromptResponse(string text)
        {
            var model = new ChatGPTInputModel(text);
            var requestBody = JsonSerializer.Serialize(model);
            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            var token = _configuration.GetSection("ChatGPT:Token").Value;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.PostAsync("https://api.openai.com/v1/completions", content);
            var result = await response.Content.ReadAsStringAsync();
            var promptResponse = result;
            return promptResponse?.ToString() ?? string.Empty;
        }
    }
}
