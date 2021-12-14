using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class ForecastUtilities
    {
        public static void PrintWeathers(IPrinter[] printers, Weather[] weathers)
        {
            for(int i = 0; i < weathers.Length; i++)
            {
                printers[0].PrintWeather(weathers[i]);
                printers[1].PrintWeather(weathers[i]);
            }
        }
    }
}
