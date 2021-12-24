using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class NoSuchDailyWeatherException : Exception
    {
        public NoSuchDailyWeatherException() { }
        public NoSuchDailyWeatherException(string message) : base(message) { }
        public NoSuchDailyWeatherException(string message, Exception innerException) : base(message, innerException) { }
    }
}
