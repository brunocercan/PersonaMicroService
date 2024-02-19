namespace API.Persona4.BusinessLayer
{
    public class PersonaBL
    {
        public PersonaBL()
        {

        }

        public Models.ClassAnswer.Response GetP4GAnswer(string data)
        {
            var response = new Models.ClassAnswer.Response();
            try
            {
                var request = new Models.ClassAnswer.Request()
                {
                    data = data,
                    game = "p4g"
                };

                var con = Environment.GetEnvironmentVariable("CONNECTION_STRING");

                var repo = new DataLayer.PersonaRepository();
                response = repo.GetP4GAnswer(request, con);

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
