using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Persona3.Controllers
{
    [Route("class")]
    [ApiController]
    public class Persona3Controller : ControllerBase
    {
        [HttpGet, Route("p3r/{month}/{day}")]
        public Models.ClassAnswer.Response GetAnswerP3R(string month, int day)
        {
            var answer = new Models.ClassAnswer.Response();
            var bl = new BusinessLayer.PersonaBL();
            try
            {
                answer = bl.GetP3RAnswer(month, day);
            }
            catch (Exception e)
            {
                answer.error = e.Message;
            }
            return answer;
        }
    }
}
