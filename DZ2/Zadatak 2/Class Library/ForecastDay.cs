using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Class_Library
{
    public class ForecastDay
    {
        private DateTime day = new DateTime();
        private Weather weather = new Weather();

        public ForecastDay(DateTime day, Weather weather)
        {
            this.day = day;
            this.weather = weather;
        }

        CultureInfo culture = new CultureInfo("pt-BR");

        public Weather Weather => weather;

        // 08/11/2021 00:00:00: T=6.17°C, w=4.9km/h, h=56.13%
        public string GetAsString()
        {
            return $"{day.ToString(culture)}: T={weather.GetTemperature()}°C, w={weather.GetWindSpeed()}km/h, h={weather.GetHumidity()}%";
        }
    }
}
