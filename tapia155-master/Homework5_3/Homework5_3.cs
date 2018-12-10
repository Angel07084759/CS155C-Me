/// Chapter No. Week6	Exercise No. Homework5_3
/// File Name:          Homework5_3.cs
/// @author:            Angel Tapia
/// Date:               September 30, 2018
/// Problem Statement:  This program Generates, Prints, and reverses an array of integers.
///                     
/// Algorithm:
/// 1) Create a method int[] GenerateNumbers(int length) that
///    generates numbers from 1 to the given length 
///    and returns them as an array of integers:
///     Create a temp array of integers of size = length
///     for int i = 0; i < length; i++
///         temp[i] = i + 1
///     return temp
/// 2) Create a method Reverse that receives an array of integers and reverses its content:
///     Get the length of the array.
///     Use a for loop to swap each value:
///         for int i = 0, j = (length - 1); i < (length / 2); i++, j--
///             swap numbers[i] and numbers[j]: temp = a; a = b; b = temp
/// 3) Create a method PrintNumbers that receives an array of integers and prints out its constent:
///     Use a foreach to print out each content in the given array.
/// 4) Implement Main:
///     Generate an array (call the the method  GenerateNumbers) and store it in a new array.
///     Call the PrintNumbers method to print out the new gegerated array.
///     Call the Reverse method to reverse the content of the generated array.
///     Call the PrintNumbers method the print out the reversed array.
///     Pause the screen.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_3
{
    class Homework5_3
    {   
        //Generates numbers from 1 to the given length
        //and returns them as an array of integers.
        public static int[] GenerateNumbers(int length)
        {
            int[] temp = new int[length];
            for (int i = 0; i < length; i++)
            {
                temp[i] = i + 1;
            }
            return temp; 
        }

        //Reverses the given array of integers.
        public static void Reverse(int[] numbers)
        {
            int length = numbers.Length;

            for (int i = 0, j = (length - 1); i < (length / 2); i++, j--)
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }

        //Prints the content in the given array of integers.
        public static void PrintNumbers(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        //Generates, Prints, and reverses an array.
        static void Main(string[] args)
        {
            //Generate an array
            int[] numbers = GenerateNumbers(6);

            //Print the array
            PrintNumbers(numbers);
            Console.WriteLine();

            //Reverse the array
            Reverse(numbers);

            //Print the reversed array
            PrintNumbers(numbers);

            //Pause the screen
            Console.ReadLine();
        }
    }
}
