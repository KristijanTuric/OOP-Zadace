using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class ForecastWeek
    {
        private ForecastDay[] days = new ForecastDay[7];

        public ForecastWeek(ForecastDay[] days)
        {
            this.days = days;
        }

        /*  
            08/11/2021 00:00:00: T=6.17°C, w=46.5km/h, h=4.9%
            09/11/2021 00:00:00: T=4.37°C, w=58km/h, h=4.1%
            10/11/2021 00:00:00: T=8.45°C, w=56.03km/h, h=1.9%
            11/11/2021 00:00:00: T=9.03°C, w=53.55km/h, h=0.8%
            12/11/2021 00:00:00: T=3.14°C, w=42.33km/h, h=6.1%
            13/11/2021 00:00:00: T=3.78°C, w=43.11km/h, h=0.2%
            14/11/2021 00:00:00: T=5.22°C, w=42.22km/h, h=0.3%
        */

        public ForecastDay this[int index]
        {
            get { return days[index]; }
            set { days[index] = value; }
        }

        public string GetAsString()
        {
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i].GetAsString());
            }
            return "";
        }

        public string GetMaxTemperature()
        {
            double max = days[0].Weather.GetTemperature();
            for(int i = 0; i < days.Length; i++)
            {
                if (days[i].Weather.GetTemperature() > max)
                    max = days[i].Weather.GetTemperature();
            }

            return $"{max}";
        }
    }
}
