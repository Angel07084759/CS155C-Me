/// Chapter No. Week2	Exercise No. Lab1 
/// File Name:          MyFirstProgram.cs
/// @author:            Angel Tapia
/// Date:               August 27, 2018
///
/// Problem Statement:  Ask the user to enter three numbers, 
///                     calculate the sum, multiplication,
///                     and the divition these three numbers 
///                     and display the results
/// Overall Plan:
/// 1) Declare variables: n1, n2, sum
/// 2) Print initial message
/// 3) Create variables int n1, n2, n3; double product, quotient;
/// 4) Request value for the first number
/// 5) Request value for the second number
/// 6) Request value for the third number
/// 7) Calculate the sum of n1 + n2 + n3 and store it in sum
/// 8) Calculate the multiplication on n1, n2, n3
/// 9) Calculate the divition of sum by multiplication (type cast product)
/// 10) Didplay the results
/// 

using System;

namespace Week2_Lab1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // Declare variables to be used
            int n1, n2, n3, sum;
            double product, quotient;

            // Print initial message
            Console.WriteLine("Adding three number!");

            // Request value for the first number
            Console.WriteLine("Enter first number:");
            n1 = Int32.Parse(Console.ReadLine());

            // Request value for the second number
            Console.WriteLine("Enter second number:");
            n2 = Int32.Parse(Console.ReadLine());

            // Request value for the third number
            Console.WriteLine("Enter third number:");
            n3 = Int32.Parse(Console.ReadLine());

            // Calculate the sum, mult
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;
            quotient = sum / (double) product;

            // Print results
            Console.WriteLine("The sum of those three numbers is");
            Console.WriteLine(sum);
            Console.WriteLine("The product of those three numbers is");
            Console.WriteLine(product);
            Console.WriteLine("The result of the sum divided by the product is ");
            Console.WriteLine(quotient);

            //Pause the screen.
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}