using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Helper
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double celsius = Double.Parse(temperatureCelsius);

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }
    }
}
