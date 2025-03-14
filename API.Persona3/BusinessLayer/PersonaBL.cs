using System.Text.Json.Serialization;
using API.Persona3.Models;
using Newtonsoft.Json;

namespace API.Persona3.BusinessLayer
{
    public class PersonaBL
    {
        public PersonaBL()
        {

        }

        public Models.ClassAnswer.Response GetP3RAnswer(string mes, int dia)
        {
            var response = new Models.ClassAnswer.Response();
            try
            {
                var lista = LoadJson("Persona3.Questions.json");
                response = SearchQuestion(lista, mes, dia);
            }
            catch (Exception e)
            {
                response.error = e.Message;
                throw;
            }
            return response;
        }

        private Models.ClassAnswer.Response SearchQuestion(Models.ClassAnswer.ConteudoJson lista, string mes, int dia)
        {
            var response = new Models.ClassAnswer.Response();
            try
            {
                var questao = lista.Questions.Where(x => x.Month.ToLower() == mes.ToLower() && x.Day == dia).First();

                response = new Models.ClassAnswer.Response()
                {
                    question = questao.Query,
                    answer = questao.Answer,
                    error = null,
                };
            }
            catch (System.Exception)
            {
                response.error = "Date not found!";
                return response;
            }
            return response;
        }

        private Models.ClassAnswer.ConteudoJson LoadJson(string v)
        {
            try
            {
                using (StreamReader r = new StreamReader(v))
                {
                    string json = r.ReadToEnd();
                    Models.ClassAnswer.ConteudoJson questions = JsonConvert.DeserializeObject<Models.ClassAnswer.ConteudoJson>(json);
                    return questions;
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
