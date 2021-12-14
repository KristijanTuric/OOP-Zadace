using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Class_Library
{
    public interface IPrinter
    {
        public void PrintWeather(Weather weather);
    }

    public class ConsolePrinter : IPrinter
    {
        private ConsoleColor consoleColor;
        public ConsolePrinter(ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
            
        }

        public void PrintWeather(Weather weather)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(weather.ToString());
        }
    }

    public class FilePrinter : IPrinter
    {
        private string path;
        public FilePrinter(string path)
        {
            this.path = path;
        }

        public void PrintWeather(Weather weather)
        {
            File.WriteAllText(path, weather.ToString());
        }

    }
}
