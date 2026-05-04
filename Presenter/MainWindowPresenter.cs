using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pogodynka.Model;

namespace Pogodynka.Presenter
{
    public class MainWindowPresenter
    {
        private readonly MainWindow _view;
        private readonly WeatherService _weatherService;

        public MainWindowPresenter(MainWindow view)
        {
            _view = view;
            _weatherService = new WeatherService();

            // Zdarzenia pozostają takie same
            _view.CapitalChanged += SelectedCapitalChanged;
            _view.CityChanged += RefreshButtonClicked;
        }

        public async void SelectedCapitalChanged(object sender, EventArgs? e)
        {
            await UpdateWeather(_view.SelectedCity);
            
            
        }

        public async void RefreshButtonClicked(object sender, EventArgs? e)
        {
            await UpdateWeather(_view.City);
            
        }

        private async Task UpdateWeather(string city)
        {
            if (string.IsNullOrEmpty(city)) return;

            try
            {
                Forecast forecast = await _weatherService.GetWeatherAsync(city);

                if (forecast != null)
                {
                    _view.Temperature = $"{(int)forecast.Main.Temp} °C";
                    _view.Humidity = $"{forecast.Main.Humidity}%";
                    _view.Pressure = $"{forecast.Main.Pressure} hPa";
                    _view.Description = forecast.Weather[0].Description;
                    _view.CityLabel = city;
                    _view.IconUrl = $"https://openweathermap.org/img/wn/{forecast.Weather[0].Icon}@2x.png";
                    _view.SetCapitalIndex = -1;
                    _view.City = "";
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error occured while downloading data: " + ex.Message);
            }
        }
    }
}
