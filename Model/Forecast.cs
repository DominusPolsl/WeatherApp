using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pogodynka.Model
{
    public class Forecast
    {
        [JsonProperty("main")]
        public Main? Main { get; set; }
        [JsonProperty("weather")]
        public List<Weather>? Weather { get; set; }
    }
    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
        [JsonProperty("pressure")]
        public int Pressure { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
    public class Weather
    {
        [JsonProperty("icon")]
        public string? Icon { get; set; }
        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}