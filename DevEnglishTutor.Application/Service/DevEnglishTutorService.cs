using DevEnglishTutor.Domain.Interface;
using Microsoft.Extensions.Configuration;
using DevEnglishTutor.Application.Interface;

namespace DevEnglishTutor.Application.Service
{
    /// <summary>
    /// The dev english tutor service.
    /// </summary>
    public class DevEnglishTutorService : IDevEnglishTutorService
    {
        /// <summary>
        /// The configuration.
        /// </summary>
        public readonly IConfiguration _configuration;

        /// <summary>
        /// The dev english tutor repository.
        /// </summary>
        public readonly IDevEnglishTutorRepository _devEnglishTutorRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DevEnglishTutorService"/> class.
        /// </summary>
        /// <param name="httpClient">The http client.</param>
        /// <param name="devEnglishTutorRepository">The dev english tutor repository.</param>
        public DevEnglishTutorService(IDevEnglishTutorRepository devEnglishTutorRepository, 
                                      IConfiguration configuration)
        {
            _configuration = configuration;
            _devEnglishTutorRepository = devEnglishTutorRepository;
        }

        /// <summary>
        /// Prompts the response.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><![CDATA[Task<string>]]></returns>
        public async Task<string> PromptResponse(string text)
        {
            return await _devEnglishTutorRepository.PromptResponse(text);
        }
    }
}
