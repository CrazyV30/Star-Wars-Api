using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp_SWAPI
{
    internal class JsonHelper
    {
        public static T Deserialize<T>(string jsonData) => JsonConvert.DeserializeObject<T>(jsonData);
    }
}
