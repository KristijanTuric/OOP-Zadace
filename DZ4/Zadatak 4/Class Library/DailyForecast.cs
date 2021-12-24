using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Class_Library
{
    public class DailyForecast
    {
        private DateTime day = new DateTime();
        private Weather weather = new Weather();

        public DailyForecast(DateTime day, Weather weather)
        {
            this.day = day;
            this.weather = weather;
        }

        CultureInfo culture = new CultureInfo("pt-BR");

        public Weather Weather => weather;
        public DateTime Day => day;

        public override string ToString()
        {
            return $"{day.ToString(culture)}: T={weather.GetTemperature()}°C, w={weather.GetWindSpeed()}km/h, h={weather.GetHumidity()}%";
        }
    }
}
