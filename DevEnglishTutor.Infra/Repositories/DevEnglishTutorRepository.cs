using OpenAI_API;
using OpenAI_API.Models;
using OpenAI_API.Completions;
using DevEnglishTutor.Domain.Interface;

namespace DevEnglishTutor.Infra.Repositories
{
    /// <summary>
    /// The dev english tutor repository.
    /// </summary>
    /// <param name="openAIAPI">The open AIAPI.</param>
    public class DevEnglishTutorRepository(OpenAIAPI openAIAPI) : IDevEnglishTutorRepository
    {
        /// <summary>
        /// Open AIAPI.
        /// </summary>
        private readonly OpenAIAPI _openAIAPI = openAIAPI;

        /// <summary>
        /// Get grammar correction.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><![CDATA[Task<string>]]></returns>
        public async Task<string> GetGrammarCorrection(string text)
        {
            try
            {
                var response = string.Empty;
                var completion = new CompletionRequest { Prompt = text, Model = Model.ChatGPTTurbo, MaxTokens = 200 };
                var result = await _openAIAPI.Completions.CreateCompletionAsync(completion);
                result.Completions.ForEach(resultText => response = resultText.Text);
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
