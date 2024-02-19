using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Persona5.Controllers
{
    [Route("class")]
    [ApiController]
    public class Persona3Controller : ControllerBase
    {
        [HttpGet, Route("p5r/{data}")]
        public Models.ClassAnswer.Response GetAnswerP3R(string data)
        {
            var answer = new Models.ClassAnswer.Response();
            var bl = new BusinessLayer.PersonaBL();
            try
            {
                answer = bl.GetP5RAnswer(data);
            }
            catch (Exception)
            {
                throw;
            }
            return answer;
        }
    }
}
