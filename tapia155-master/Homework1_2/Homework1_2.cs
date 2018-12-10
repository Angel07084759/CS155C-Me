/// Chapter No. Week1	Exercise No. Lab1 
/// File Name:          Homework1_2.cs
/// @author:            Angel Tapia
/// Date:               August 21, 2018
///
/// Problem Statement:  Print a pucture of your choice using WriteLine
/// Overall Plan:
/// 1) Using a sequence of WriteLine displays a simple picture of your choice
/// 2) Pause the screen
///

using System;

namespace Homework1_2
{
    class Homework1_2
    {
        static void Main(string[] args)
        {
            //Using a sequence of WriteLine displays a simple picture of your choice.
            Console.WriteLine("                           c#                          ");
            Console.WriteLine("                      +----+----+                      ");
            Console.WriteLine("             +-------------+-------------+             ");
            Console.WriteLine("       +----------------+  |  +----------------+       ");
            Console.WriteLine("   +-----------------+  |  |  |  +-----------------+   ");
            Console.WriteLine("   |     * * * *     |  |  |  |  |     *     *     |   ");
            Console.WriteLine("   |    *            |  |  |  |  |     *     *     |   ");
            Console.WriteLine("   |    *            |  |  |  |  | * * * * * * * * |   ");
            Console.WriteLine("   |    *            |  |  |  |  |     *     *     |   ");
            Console.WriteLine("   |    *            |  |  |  |  |     *     *     |   ");
            Console.WriteLine("   |    *            |  |  |  |  | * * * * * * * * |   ");
            Console.WriteLine("   |    *            |  |--+--|  |     *     *     |   ");
            Console.WriteLine("   |     * * * *     |--+     +--|     *     *     |   ");
            Console.WriteLine("   +-----------------+           +-----------------+   ");

            //Pause the screen.
            Console.WriteLine("               Press enter to exit...");
            Console.ReadLine();
        }

    }
}

