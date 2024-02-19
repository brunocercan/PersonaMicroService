namespace API.Persona3.BusinessLayer
{
    public class PersonaBL
    {
        public PersonaBL()
        {

        }

        public Models.ClassAnswer.Response GetP3RAnswer(string data)
        {
            var response = new Models.ClassAnswer.Response();
            try
            {
                var request = new Models.ClassAnswer.Request()
                {
                    data = data,
                    game = "p3r"
                };

                var con = Environment.GetEnvironmentVariable("CONNECTION_STRING");

                var repo = new DataLayer.PersonaRepository();
                response = repo.GetP3RAnswer(request, con);

                if (response.answer == "" || response.answer == null)
                {
                    response.error = "Answer not found this day";
                }
            }
            catch (Exception e)
            {
                response.error = e.Message;
                throw;
            }
            return response;
        }
    }
}
