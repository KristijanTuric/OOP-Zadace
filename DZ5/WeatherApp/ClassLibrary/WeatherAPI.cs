using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ClassLibrary
{
    public class WeatherAPI
    {
        public static string final = "";
        public static string imgSc = "";
        private static readonly HttpClient client = new HttpClient();
        public static async Task GetWeather(string city)
        {
            var http = new HttpClient();
            var url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid=7c37d5d34768e0d00a57859861326938";
            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            WeatherStruct st = JsonConvert.DeserializeObject<WeatherStruct>(result);

            imgSc = Convert.ToString(st.weather.Rows[0]["icon"]);

        final = $"City: {st.name}" +
                $"\nTemperature: {st.main["temp"]}°C" +
                $"\nFeels like: {st.main["feels_like"]}°C" +
                $"\nMin Temperture: {st.main["temp_min"]}°C" +
                $"\nMax Temperature: {st.main["temp_max"]}°C" +
                $"\nPressure: {st.main["pressure"]}hPa" +
                $"\nHumidity: {st.main["humidity"]}%" +
                $"\nWind speed: {st.wind["speed"]}m/s" +
                $"\nWind degree direction: {st.wind["deg"]}°" +
                $"\nDescription: {st.weather.Rows[0]["main"]} - {st.weather.Rows[0]["description"]}";

            



        }
    }
}
