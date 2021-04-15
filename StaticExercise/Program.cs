using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("After Conversion:");
            var f = TempConverter.CelsiusToFahrenheit(28);
            var c = TempConverter.FahrenheitToCelsius(68);
            
           
            Console.WriteLine($"28 degrees in Celsius is {f} degrees in Farenheit.");
            Console.WriteLine($"68 degrees in Fahrenheit is {c} degrees in Celsius.");
        }
    }
}
