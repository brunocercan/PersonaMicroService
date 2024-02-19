using System.ComponentModel.DataAnnotations;

namespace API.Persona3.Models
{
    public class ClassAnswer
    {
        public class Request
        {
            /// <summary>
            /// Game name p3r = Persona 3 Reload, p4g = Persona 4 Golden, p5r = Persona 5 Royal
            /// </summary>
            public string game { get; set; }
            /// <summary>
            /// Class Date Example: 0408 - mmdd - monthday
            /// </summary>
            [Required]
            public string data { get; set; }
        }
        public class Response
        {
            /// <summary>
            /// Answer of the class day
            /// </summary>
            public string? answer { get; set; }
            public string? error { get; set; }
        }
    }
}
