using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Class_Library
{
    public static class ForecastUtilities
    {
        // 08/11/2021 00:00:00,6.17,46.50,4.9
        public static ForecastDay Parse(string text)
        {
            string[] parts = text.Split(',');
            DateTime date = new DateTime();
            date = DateTime.Parse(parts[0], new CultureInfo("pt-BR"));

            Weather weather = new Weather(Convert.ToDouble(parts[1]), Convert.ToDouble(parts[2]), Convert.ToDouble(parts[3]));

            ForecastDay day = new ForecastDay(date, weather);
            return day;
        }

        public static double CalculateWindChill(Weather weather)
        {
            double wci;
            wci = 13.12 + 0.6215 * weather.GetTemperature() - 11.37 * Math.Pow(weather.GetWindSpeed(), 0.16) + 0.3965 * weather.GetTemperature() * Math.Pow(weather.GetWindSpeed(), 0.16);
            if (wci > weather.GetTemperature())
            {
                return 0;
            }
            return wci;
        }
    }
}
