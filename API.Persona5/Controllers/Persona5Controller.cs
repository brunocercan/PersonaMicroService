using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Persona5.Controllers
{
    [Route("class")]
    [ApiController]
    public class Persona5Controller : ControllerBase
    {
        [HttpGet, Route("p5r/{month}/{day}")]
        public Models.ClassAnswer.Response GetAnswerP5R(string month, int day)
        {
            var answer = new Models.ClassAnswer.Response();
            var bl = new BusinessLayer.PersonaBL();
            try
            {
                answer = bl.GetP5RAnswer(month, day);
            }
            catch (Exception e)
            {
                answer.error = e.Message;
            }
            return answer;
        }
    }
}
