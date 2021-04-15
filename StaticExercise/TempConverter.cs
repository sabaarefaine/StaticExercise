using System;
namespace StaticExercise
{
    public static class TempConverter
    {
     //Create 2 methods inside the TempConverter class:
     //Name the first method - FahrenheitToCelsius
        public static double FahrenheitToCelsius (double f)
        {
            return (f - 32) / 1.8;
        }

     //Name the second method - CelsiusToFahrenheit
        public static double CelsiusToFahrenheit (double c)
        {
            return (c * 1.8) + 32;
        }


        //Both methods will have a single parameter of type double
        //Complete the logic so that they properly convert the temperatures
        //Call both methods in your Main() method

    }
}
