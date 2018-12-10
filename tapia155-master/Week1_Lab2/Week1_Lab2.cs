/// Chapter No. Week1	Exercise No. Lab2
/// File Name:          Week1_Lab2.cs
/// @author:            Angel Tapia
/// Date:               August 21, 2018
///
/// Problem Statement:  Print out a 3 x 3 square
/// Overall Plan:
/// 1) Use a sequence of WriteLine to print a 3 x 3 quare
/// 2) Pause the screen.
/// 

using System;

namespace Week1_Lab2
{
    class Week1_Lab2
    {
        static void Main(string[] args)
        {
            //Using a sequence of WriteLine to print a 3 x 3 quare
            Console.WriteLine("3 x 3 square!");
            Console.WriteLine(" --- --- --- ");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine(" --- --- --- ");

            //Pause the screen.
            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}