/// Chapter No. Week5	Exercise No. Homework4_2
/// File Name:          Homework4_2.cs
/// @author:            Angel Tapia
/// Date:               September 24, 2018
/// Problem Statement:  This program calculates the statistics
///                     for eight number of coin tosses.
/// Overall Plan:
/// 1) Declare Constant for number of tosses: int TOSS_COUNT = 8;
/// 2) Create local variables: int numHead, numTail to count the
///    number of heads and tails.
/// 3) Display initial message.
/// 4) Request input from the user(‘h’ for heads or ‘t’ for tails):
///     -Use a for loop to get 8 input values form the user.
///         if (toss.ElementAt(0) == 'h': increment numHead
///         else if (toss.ElementAt(0) == 't': increment numTail
///         else must be an input error: 
///              decrement iterator 
///              and request a valid input
/// 5) Display results for:
///     -Number of Heads
///     -Number of Tails
///     -Percent Heads: (numHead * 100/ (double) TOSS_COUNT)
///     -Percent Tails: (numTail * 100/ (double) TOSS_COUNT)
/// 6) Pause the screen: Display final message.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    class Homework4_2
    {
        //Constant for Number of tosses
        public const int TOSS_COUNT = 8;

        static void Main(string[] args)
        {
            //Create local variables.
            int numHead = 0;
            int numTail = 0;

            //Display initial message.
            Console.WriteLine("Statistics for " + TOSS_COUNT +" coin tosses...");
            Console.WriteLine("For each coin toss enter either ‘h’ for heads or ‘t’ for tails.");

            //Request input from the user.
            for (int i = 1; i <= TOSS_COUNT; i++)
            {
                Console.Write("Enter toss #{0}: ", i);
                String toss = Console.ReadLine().Trim().ToString().ToLower() + " ";
                if (toss.ElementAt(0) == 'h')
                {
                    numHead++;
                }
                else if (toss.ElementAt(0) == 't')
                {
                    numTail++;
                }
                else
                {
                    Console.WriteLine("Input error \"" + toss + "\". Please try again!");
                    i--;
                }
            }

            //Display results.
            Console.WriteLine("Number of Heads: {0}", numHead);
            Console.WriteLine("Number of Tails: {0}", numTail);
            Console.WriteLine("Percent Heads:   {0:0.0}", (numHead * 100/ (double) TOSS_COUNT));
            Console.WriteLine("Percent Tails:   {0:0.0}", (numTail * 100/ (double) TOSS_COUNT));

            //Pause the screen.
            Console.WriteLine("Press ENTER to continuous...");
            Console.ReadLine();
        }
    }
}
