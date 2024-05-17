using DevEnglishTutor.Domain.Interface;
using DevEnglishTutor.Application.Interface;

namespace DevEnglishTutor.Application.Service
{
    /// <summary>
    /// The dev english tutor service.
    /// </summary>
    /// <param name="devEnglishTutorRepository">The dev english tutor repository.</param>
    public class DevEnglishTutorService(IDevEnglishTutorRepository devEnglishTutorRepository) : IDevEnglishTutorService
    {
        /// <summary>
        /// The dev english tutor repository.
        /// </summary>
        private readonly IDevEnglishTutorRepository _devEnglishTutorRepository = devEnglishTutorRepository;

        /// <summary>
        /// Get grammar correction.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><![CDATA[Task<string>]]></returns>
        public async Task<string> GetGrammarCorrection(string text)
        {
            try
            {
                return await _devEnglishTutorRepository.GetGrammarCorrection(text);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
