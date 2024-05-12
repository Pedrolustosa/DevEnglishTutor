using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DevEnglishTutor.Models;
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
        /// The choices.
        /// </summary>
        private const string Choices = "choices";
        /// <summary>
        /// The message.
        /// </summary>
        private const string Message = "message";
        /// <summary>
        /// The content.
        /// </summary>
        private const string Content = "content";
        /// <summary>
        /// Open API.
        /// </summary>
        private const string OpenAPI = "https://api.openai.com/v1/chat/completions";

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
        /// <param name="configuration">The configuration.</param>
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
        public async Task<string> GetGrammarCorrection(string text)
        {
            try
            {
                var token = _configuration.GetSection("ChatGPT:Token").Value;
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                var systemPrompt = new Prompt("system", "You are the best foreign language translator.");
                var userPrompt = new Prompt("user", $"Correct this English phrase: {text}");
                var model = new ConversationModel
                {
                    Model = "gpt-3.5-turbo-0125",
                    Prompt = new[] { systemPrompt, userPrompt }
                };
                var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(OpenAPI, content);
                var result = await response.Content.ReadAsStringAsync();
                var responseObject = JObject.Parse(result);
                string? assistantMessage = responseObject?[Choices]?[0]?[Message]?[Content]?.ToString();
                return $"ChatGPT: {assistantMessage}";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
