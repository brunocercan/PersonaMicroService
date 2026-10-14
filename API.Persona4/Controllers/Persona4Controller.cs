using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Persona4.Controllers
{
    [Route("class")]
    [ApiController]
    public class Persona4Controller : ControllerBase
    {
        [HttpGet, Route("p4g/{month}/{day}")]
        public Models.ClassAnswer.Response GetAnswerP4G(string month, int day)
        {
            var answer = new Models.ClassAnswer.Response();
            var bl = new BusinessLayer.PersonaBL();
            try
            {
                answer = bl.GetP4GAnswer(month, day);
            }
            catch (Exception e)
            {
                answer.error = e.Message;
            }
            return answer;
        }
    }
}
