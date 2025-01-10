using Microsoft.AspNetCore.Mvc;
using EightToTen_Endpoints.Services;


namespace EightToTen_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService _magic8BallService;

        public Magic8BallController(Magic8BallService magic8BallService)
        {
            _magic8BallService = magic8BallService;
        }
        [HttpGet("question")]
        public string GetResponse(string question)
        {
              if (string.IsNullOrEmpty(question))
            {
                return "Error: Please enter a question.";
            }

            foreach (char c in question)
            {
                if (!char.IsLetter(c) && c != ' ') 
                {
                    return "Error: Question must contain only letters and spaces.";
                }
            }
              var response = _magic8BallService.GetRandomResponse();
            return response;
        }
    }
}