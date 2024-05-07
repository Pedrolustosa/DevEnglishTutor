using Microsoft.AspNetCore.Mvc;
using DevEnglishTutor.Application.Interface;

namespace DevEnglishTutor.API.Controllers
{
    [ApiController]
    [Route("api/english-tutor")]
    public class EnglishTutorController : ControllerBase
    {
        private readonly IDevEnglishTutorService _devEnglishTutorService;
        public EnglishTutorController(IDevEnglishTutorService devEnglishTutorService)
        {
            _devEnglishTutorService = devEnglishTutorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string text)
        {
            var promptResponse = await _devEnglishTutorService.PromptResponse(text);
            return Ok(promptResponse);
        }
    }
}
