using System.Data.Common;
using API.Persona5.Models;
using Dapper;
using System.Data.SqlClient;

namespace API.Persona5.DataLayer
{
    public class PersonaRepository
    {
        public ClassAnswer.Response GetP5RAnswer(ClassAnswer.Request request, string con)
        {
			var result = new ClassAnswer.Response();
			try
			{
				using (var db = new SqlConnection(con))
				{
                    var query = $"SELECT answer FROM dbo.class_answers WHERE data = @data and game = @game";

                    db.Open();

					var listResult = db.Query<ClassAnswer.Response>(query, request);

                    foreach (var item in listResult)
                    {
                        result.answer = item.answer;
                    }
                }
			}
			catch (Exception)
			{
				throw;
			}
			return result;
        }
    }
}
