using System.Text;
using DevEnglishTutor.Models;
using DevEnglishTutor.Domain.Interface;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text.Json;

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
        /// The http client.
        /// </summary>
        private readonly IHttpClientFactory _httpClientFactory;

        /// <summary>
        /// The configuration.
        /// </summary>
        public readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="DevEnglishTutorRepository"/> class.
        /// </summary>
        /// <param name="httpClient">The http client.</param>
        /// <param name="configuration">The configuration.</param>
        public DevEnglishTutorRepository(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
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
                var httpClient = _httpClientFactory.CreateClient("ChtpGPT");

                ChatCompletionRequest completionRequest = new()
                {
                    Model = "gpt-3.5-turbo",
                    MaxTokens = 1000,
                    Messages = [new Message() { Role = "user", Content = text }]
                };


                using var httpReq = new HttpRequestMessage(HttpMethod.Post, "https://api.openai.com/v1/chat/completions");
                httpReq.Headers.Add("Authorization", $"Bearer {_configuration["ChatGPT:Token"]}");

                string requestString = JsonSerializer.Serialize(completionRequest);
                httpReq.Content = new StringContent(requestString, Encoding.UTF8, "application/json");

                using HttpResponseMessage? httpResponse = await httpClient.SendAsync(httpReq);
                httpResponse.EnsureSuccessStatusCode();

                var completionResponse = httpResponse.IsSuccessStatusCode ? JsonSerializer.Deserialize<ChatCompletionResponse>(await httpResponse.Content.ReadAsStringAsync()) : null;

                return completionResponse.Choices?[0]?.Message?.Content;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
