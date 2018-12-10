/// Chapter No. Week6	Exercise No. Homework5_1
/// File Name:          Homework5_1.cs
/// @author:            Angel Tapia
/// Date:               September 30, 2018
/// Problem Statement:  This program Prints out a triangle of a size 
///                     given by the users.
/// Algorithm:
/// 1) Create local variable: int triangleSize = 0;
/// 2) Print initial message.
/// 3) Get input from the user and store it in triangleSize.
/// 4) Create a nested for loop to print out the first half of the triangle.
///     for int i = 0; i < triangleSize; i++
///         for int j = 0; j <= i; j++
///             Console.Write("*");
/// 5) Create another nested loop to print out the second half of the triangle.
///     for int i = (triangleSize - 1); i > 0; i--
///         for int j = i; j > 0; j--
///             Console.Write("*");
/// 6) Pause the screen.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    class Homework5_1
    {
        static void Main(string[] args)
        {
            //Represents the size of the triangle to be printed out. 
            int triangleSize = 0;
            Console.Write("Enter the size of a triangle to print out (an integer from 1 to 50): ");

            //Parser user's input and stores the result in triangleSize.
            Int32.TryParse(Console.ReadLine(), out triangleSize);

            //Prints out the first half of the triangle.
            for (int i = 0; i < triangleSize; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            //Prints out the next half of the triangle.
            for (int i = (triangleSize - 1); i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
