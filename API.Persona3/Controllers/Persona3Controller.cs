using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Persona3.Controllers
{
    [Route("class")]
    [ApiController]
    public class Persona3Controller : ControllerBase
    {
        [HttpGet, Route("p3r/{data}")]
        public Models.ClassAnswer.Response GetAnswerP3R(string data)
        {
            var answer = new Models.ClassAnswer.Response();
            var bl = new BusinessLayer.PersonaBL();
            try
            {
                answer = bl.GetP3RAnswer(data);
            }
            catch (Exception)
            {
                throw;
            }
            return answer;
        }
    }
}
