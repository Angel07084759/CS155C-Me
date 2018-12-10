/// Chapter No. Week6	Exercise No. Homework5_2
/// File Name:          Homework5_2.cs
/// @author:            Angel Tapia
/// Date:               September 30, 2018
/// Problem Statement:  This program Prints out a triangle of a size 
///                     given by the users.
/// Algorithm:
/// 1) Create an array (array1) and put some value in it.
///     int[] array1 = new int[] { 4, 51, -7, 13, -99, 100, 15, -8, 45, 90 };
/// 2) Create a second array with size array1.Lenght
///     int[] array2 = new int[array1.Length];
/// 3) Copy the content of the first array to the second array:
///     for (int i = 0; i < array2.Length; i++)
///         array2[i] = array1[i];
/// 4) Print the two array (the original and the copy):
///     for (int i = 0; i < array2.Length; i++)
///         Console.WriteLine("{0, 4}{0, 11}", array1[i], array2[i]);
/// 5) pause the screen.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_2
{
    class Homework5_2
    {
        static void Main(string[] args)
        {
            //Create an array.
            int[] array1 = new int[] { 4, 51, -7, 13, -99, 100, 15, -8, 45, 90 };

            //Create another array with size array1.Lenght.
            int[] array2 = new int[array1.Length];

            //Copy the content of the first array to the second array.
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
            }

            //Print the two array (the original and the copy).
            Console.WriteLine("{0, -11}{1}", "array1", "array2");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("{0, 4}{1, 11}", array1[i], array2[i]);
            }
            
            //Pause the screen.
            Console.ReadLine();
        }
    }
}
