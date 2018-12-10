/// Chapter No. Week2	Exercise No. Homework2_2
/// File Name:          Homework2_2.cs
/// @author:            Angel Tapia
/// Date:               September 9, 2018
///
/// Problem Statement:  This program converts degrees Fahrenheit 
///                     to degrees Celsius with an approximation
///                     of one decimal point.
/// Overall Plan:
/// 1) Declare local variables:
///     int degreesF, to store the input from the user 
///     as degrees Fahrenheit.
///     double degreesC, to store the result of the 
///     convertion form degrees Fahrenheit to degrees Celsius.
/// 2) Print initial message.
/// 3) Ask the user to enter a temperature in degrees Fahrenheit.
/// 4) Convert degrees Fahrenheit to degrees Celsius and 
///     store the in degreesC.
///     -Use the convertion formula: 5.0 * (degreesF - 32) / 9.0
///     -Round to the nearest first decimal place  using Math.Round.
/// 5) Display the reslt.
/// 6) Pause the screen.
/// 
using System;

namespace Homework2_2
{
    class Homework2_2
    {
        static void Main(string[] args)
        {
            // Declare local variables.
            int degreesF;
            double degreesC;

            // Print initial message.
            Console.WriteLine("Fahrenheit to Celsius Converter!");

            Console.WriteLine("Enter a temperature in degrees Fahrenheit: ");
            degreesF = Convert.ToInt32(Console.ReadLine());

            // Convert degrees Fahrenheit to degrees Celsius
            degreesC = Math.Round(5.0 * (degreesF - 32) / 9.0, 1);

            // Print results
            Console.WriteLine("{0} degrees Fahrenheit = {1} degrees Celsius.", degreesF, degreesC);

            // Pause the screen
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
