using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp1.Models;

namespace WeatherApp1.Services
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latidute, double longitude ) { 
           var httpClient = new HttpClient();
           var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&appid=91d3467e7d6a21edb46e31643c4a08ce", latidute, longitude));
            return JsonConvert.DeserializeObject<Root>(response);
        }

        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&appid=91d3467e7d6a21edb46e31643c4a08ce", city));
            return JsonConvert.DeserializeObject<Root>(response);
        }

    }
}
