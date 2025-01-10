using Microsoft.AspNetCore.Mvc;
using EightToTen_Endpoints.Services;

namespace EightToTen_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _guessItService;
        public GuessItController(GuessItService guessItService)
        {
            _guessItService = guessItService;
        }
        [HttpGet("easy/{guess}")]
        public string GuessEasy(int guess)
        {

            if (guess < 1 || guess > 10)
            {
                return "Error: Guess must be between 1 and 10.";
            }

            var result = _guessItService.CheckGuess(guess, 1, 10);
            return result;
        }

        [HttpGet("medium/{guess}")]
        public string GuessMedium(int guess)
        {

            if (guess < 1 || guess > 50)
            {
                return "Error: Guess must be between 1 and 50.";
            }

            var result = _guessItService.CheckGuess(guess, 1, 50);
            return result;
        }


        [HttpGet("hard/{guess}")]
        public string GuessHard(int guess)
        {

            if (guess < 1 || guess > 100)
            {
                return "Error: Guess must be between 1 and 100.";
            }

            var result = _guessItService.CheckGuess(guess, 1, 100);
            return result;
        }
    }
}
