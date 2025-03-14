using System.ComponentModel.DataAnnotations;

namespace API.Persona3.Models
{
    public class ClassAnswer
    {
        public class Request
        {
            /// <summary>
            /// Mês da pergunta desejada Abril até Janeiro
            /// </summary>
            [Required]
            public string mes { get; set; }
            /// <summary>
            /// Dia da pergunta desejada
            /// </summary>
            [Required]
            public int dia { get; set; }
        }
        public class Response
        {
            /// <summary>
            /// Pergunta é devolvida para confirmação do usuário se é realmente a que estava buscando
            /// </summary>
            public string? question { get; set; }
            /// <summary>
            /// Answer of the class day
            /// </summary>
            public string? answer { get; set; }
            /// <summary>
            /// Variável de retorno caso ocorra algum erro
            /// </summary>
            public string? error { get; set; }
        }
        public class ConteudoJson
        {
            public List<Question> Questions { get; set; }
            public class Question
            {
                public string Month { get; set; }
                public int Day { get; set; }
                public string Query { get; set; }
                public string Answer { get; set; }
            }
        }
    }
}
