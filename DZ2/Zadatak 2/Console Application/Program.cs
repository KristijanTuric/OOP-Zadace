using System;
using Class_Library;
using System.IO;
using System.Globalization;

namespace Console_Application
{
    
    class Program
    {
        private static void RunDemoForHW2()
        {
            DateTime monday = new DateTime(2021, 11, 8);
            Weather mondayWeather = new Weather(6.17, 4.9, 56.13);
            ForecastDay mondayForecast = new ForecastDay(monday, mondayWeather);
            Console.WriteLine(monday.ToString(new CultureInfo("pt-BR")));
            Console.WriteLine(mondayWeather.GetAsString());
            Console.WriteLine(mondayForecast.GetAsString());

            // Assume a valid input file (correct format).
            // Assume that the number of rows in the text file is always 7. 
            string fileName = "C:\\Users\\Kiki\\Desktop\\Code\\test.txt";
            if (File.Exists(fileName) == false)
            {
                Console.WriteLine("The required file does not exist. Please create it, or change the path.");
                return;
            }

            string[] dailyWeatherInputs = File.ReadAllLines(fileName);
            ForecastDay[] dailyForecasts = new ForecastDay[dailyWeatherInputs.Length];
            for (int i = 0; i < dailyForecasts.Length; i++)
            {
                dailyForecasts[i] = ForecastUtilities.Parse(dailyWeatherInputs[i]);
            }
            ForecastWeek weeklyForecast = new ForecastWeek(dailyForecasts);
            Console.WriteLine(weeklyForecast.GetAsString());
            Console.WriteLine("Maximal weekly temperature:");
            Console.WriteLine(weeklyForecast.GetMaxTemperature());
            Console.WriteLine(weeklyForecast[0].GetAsString());
        }

        static void Main()
        {
            RunDemoForHW2();
        }

    }
}
