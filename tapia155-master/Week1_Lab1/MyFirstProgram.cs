/// Chapter No. Week1	Exercise No. Lab1 
/// File Name:          MyFirstProgram.cs
/// @author:            Angel Tapia
/// Date:               August 21, 2018
///
/// Problem Statement:  Ask the user to enter two numbers, 
///                     calculate the sum these two numbers, 
///                     and display the sum
/// Overall Plan:
/// 1) Declare variables: n1, n2, sum
/// 2) Print initial message
/// 3) Request value for the first number
/// 4) Request value for the second number
/// 5) Calculate the sum of n1 + n2 and store it in sum
/// 6) Print a message along with the sum of the two numbers
/// 7) Pause the screen
/// 

using System;

namespace Week1_Lab1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // Declare variables to be used
            int n1, n2, sum;

            // Print initial message
            Console.WriteLine("Adding two number!");

            // Request value for the first number
            Console.WriteLine("Enter first number:");
            n1 = Int32.Parse(Console.ReadLine());

            // Request value for the second number
            Console.WriteLine("Enter second number:");
            n2 = Int32.Parse(Console.ReadLine());

            // Calculate the sum of n1 + n2 and store it in sum
            sum = n1 + n2;

            // Print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those two numbers is");
            Console.WriteLine(sum);

            //Pause the screen.
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}