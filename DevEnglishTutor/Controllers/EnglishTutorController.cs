using Microsoft.AspNetCore.Mvc;
using DevEnglishTutor.Application.Interface;

namespace DevEnglishTutor.API.Controllers
{
    /// <summary>
    /// The english tutor controller.
    /// </summary>
    [ApiController]
    [Route("api/english-tutor")]
    public class EnglishTutorController : ControllerBase
    {
        /// <summary>
        /// The dev english tutor service.
        /// </summary>
        private readonly IDevEnglishTutorService _devEnglishTutorService;
        /// <summary>
        /// Initializes a new instance of the <see cref="EnglishTutorController"/> class.
        /// </summary>
        /// <param name="devEnglishTutorService">The dev english tutor service.</param>
        public EnglishTutorController(IDevEnglishTutorService devEnglishTutorService)
        {
            _devEnglishTutorService = devEnglishTutorService;
        }

        /// <summary>
        /// Get and return a task of type iactionresult.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns><![CDATA[Task<IActionResult>]]></returns>
        [HttpGet]
        public async Task<IActionResult> Get(string text)
        {
            try
            {
                var promptResponse = await _devEnglishTutorService.PromptResponse(text);
                return Ok(promptResponse);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
