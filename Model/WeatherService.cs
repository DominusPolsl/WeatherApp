using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Pogodynka.Model
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "b12a2e9a8d278da44979345550098280";

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Forecast>? GetWeatherAsync(string city)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Forecast>(json);
            }

            return null;
        }
    }
}
