using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Weather
    {
        private double temperature;
        private double windSpeed;
        private double humidity;

        // argument constructor
        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.windSpeed = windSpeed;
            this.humidity = humidity;
        }
        // default constructor
        public Weather() { }

        // setter and getter for temperature
        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }
        public double GetTemperature() { return temperature; }

        // setter and getter for wind speed
        public void SetWindSpeed(double windSpeed)
        {
            this.windSpeed = windSpeed;
        }
        public double GetWindSpeed() { return windSpeed; }

        // setter and getter for humidity
        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }
        public double GetHumidity() { return humidity; }

        // calculating the heat index and wind chill index
        public double CalculateFeelsLikeTemperature()
        {

            double wci;
            wci = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16);
            if (wci > temperature)
            {
                double hi;
                hi = (-8.78469475556) + 1.61139411 * temperature + 2.33854883889 * humidity + (-0.14611605) * temperature * humidity +
                    (-0.012308094) * temperature * temperature + (-0.0164248277778) * humidity * humidity + 0.002211732 * temperature * temperature * humidity +
                    0.00072546 * temperature * humidity * humidity + (-0.000003582) * temperature * temperature * humidity * humidity;
                return hi;
            }

            return wci;

        }

        // calculating windchill
        public double CalculateWindChill()
        {
            double wci;
            wci = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16);
            if (wci > temperature)
            {
                return 0;
            }
            return wci;
        }

    }
}
