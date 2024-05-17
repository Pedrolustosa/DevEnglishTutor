using Microsoft.AspNetCore.Mvc;
using DevEnglishTutor.Application.Interface;

namespace DevEnglishTutor.API.Controllers
{
    /// <summary>
    /// The english tutor controller.
    /// </summary>
    /// <param name="devEnglishTutorService">The dev english tutor service.</param>
    [ApiController]
    [Route("api/english-tutor")]
    public class EnglishTutorController(IDevEnglishTutorService devEnglishTutorService) : ControllerBase
    {
        /// <summary>
        /// The dev english tutor service.
        /// </summary>
        private readonly IDevEnglishTutorService _devEnglishTutorService = devEnglishTutorService;

        /// <summary>
        /// Get grammar correction.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><![CDATA[Task<IActionResult>]]></returns>
        [HttpGet]
        [Route("GetGrammarCorrection")]
        public async Task<IActionResult> GetGrammarCorrection([FromQuery(Name = "text")] string text)
        {
            try
            {
                var promptResponse = await _devEnglishTutorService.GetGrammarCorrection(text);
                return Ok(promptResponse);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
