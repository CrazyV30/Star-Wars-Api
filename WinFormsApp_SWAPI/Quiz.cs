using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_SWAPI
{
    public class Quiz
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("correctAnswer")]
        public string CorrectAnswer { get; set; }

    }
}
