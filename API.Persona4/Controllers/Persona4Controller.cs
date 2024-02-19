using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Persona4.Controllers
{
    [Route("class")]
    [ApiController]
    public class Persona4Controller : ControllerBase
    {
        [HttpGet, Route("p4g/{data}")]
        public Models.ClassAnswer.Response GetAnswerP3R(string data)
        {
            var answer = new Models.ClassAnswer.Response();
            var bl = new BusinessLayer.PersonaBL();
            try
            {
                answer = bl.GetP4GAnswer(data);
            }
            catch (Exception)
            {
                throw;
            }
            return answer;
        }
    }
}
