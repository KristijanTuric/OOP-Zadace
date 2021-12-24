using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public interface IRandomGenerator
    {
        double GenerateRandomValue(double a, double b);
    }

    public class UniformGenerator : IRandomGenerator
    {
        private Random generator;
        public UniformGenerator(Random generator)
        {
            this.generator = generator;
        }
        public double GenerateRandomValue(double a, double b)
        {
            return generator.NextDouble() * (b - a) + a;
        }

    }

    public class BiasedGenerator : IRandomGenerator
    {
        private Random generator;
        public BiasedGenerator(Random generator)
        {
            this.generator = generator;
        }
        public double GenerateRandomValue(double a, double b)
        {
            double temp = generator.NextDouble();
            int flag = -1;
            while (flag == -1)
            {
                if (temp >= 0 && temp < 0.5) flag = 1;
                else if (temp >= 0.5 && temp < 0.75) flag = 2;
                else temp = generator.NextDouble();
            }
            if (flag == 1) return generator.NextDouble() * (a + (a + b) / 2) - a;
            else return generator.NextDouble() * ((a + b) / 2 + b) - (a + b) / 2;
        }
    }

    public class WeatherGenerator
    {
        private double minTemperature, maxTemperature, minHumidity, maxHumidity, minWindSpeed, maxWindSpeed;
        private IRandomGenerator generator;
        public WeatherGenerator(double minTemperature, double maxTemperature, double minHumidity, double maxHumidity, double minWindSpeed,
            double maxWindSpeed, IRandomGenerator generator)
        {
            this.generator = generator;
            this.minTemperature = minTemperature;
            this.maxTemperature = maxTemperature;
            this.minHumidity = minHumidity;
            this.maxHumidity = maxHumidity;
            this.minWindSpeed = minWindSpeed;
            this.maxWindSpeed = maxWindSpeed;
        }

        public void SetGenerator(IRandomGenerator generator)
        {
            this.generator = generator;
        }

        public Weather Generate()
        {
            // temp, ws, hum
            return new Weather(generator.GenerateRandomValue(minTemperature, maxTemperature), generator.GenerateRandomValue(minWindSpeed, maxWindSpeed),
                generator.GenerateRandomValue(minHumidity, maxHumidity));
        }
    }
}
