/// Chapter No. Week6	Exercise No. Lab2
/// File Name:          Week6_Lab2.cs
/// @author:            Angel Tapia
/// Date:               September 24, 2018
/// Problem Statement:  This program calculates the statistics
///                     for 10000 number of randomly generated coin tosses.
/// Algorithm:
/// 1) Create a constant: 
///     int COIN_FLIPS = 10000;// number of flips
///     enum Flips {Heads, Tails};//Represents heads and tails
/// 2) Create a method CoinFlip(Random generator) that returns a Flips value:
///     if the random object generates a '0': return Flips.Heads; else return Flips.Tails
/// 3) Create a method PrintOutPut(Flips[] flips, int heads, int tails) that prints the statics of the given values:
///     foreach (Flips flip in flips): print Heads if flip == Flips.Heads; else print Tails
///     Display statistics for each given value:    
///         Print Number of flips.
///         Print number of heads and percentage of heads.
///         Print number of tails and percentage of tails.
/// 4) Implement Main:
///     -Create Local variables for:
///         Flips[] flips = new Flips[COIN_FLIPS];//to stores the history of all of the tosses
///         Random generator = new Random();// Generates random number values
///         int heads = 0;//counts the number of heads
///         int tails = 0;//counts the number of tails
///     -Create a for loop to simulate COIN_FLIPS numbers of flips and count each heads and tails
///      (call the method CoinFlip to simulate each flip)
///     -Call the method PrintOutPut to print the statistic of all of the flips
///     -Pause the screen.
///     

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Lab2
{
    class Week6_Lab2
    {
        //Constant for number of flips and enumeration for heads and tails
        public const int COIN_FLIPS = 10000;
        public enum Flips {Heads, Tails};//Represents heads and tails

        ///generates a number form 0 to 1 and returns Flips.Heads for 0 and Flips.Tails for 1
        static Flips CoinFlip(Random generator)
        {
            if (generator.Next(2) == 0)//generates 0 
            {
                return Flips.Heads;
            }
            return Flips.Tails;
        }

        //prints the content in the array flips and the number of heads and tails and percentage
        static void PrintOutPut(Flips[] flips, int heads, int tails)
        {
           //Iterates through the history of flips
            foreach (Flips flip in flips)
            {
                Console.WriteLine((flip == Flips.Heads ? Flips.Heads : Flips.Tails));
            }

            //Display results.
            Console.WriteLine("Total Flips: {0}", flips.Length);
            Console.WriteLine("Heads: {0} percentage, :{1:p2}.", heads, heads / (double) flips.Length);
            Console.WriteLine("Tails: {0} percentage, :{1:p2}.", tails, tails / (double) flips.Length);
        }

        //Simulates coin flips and prints statistics
        static void Main(string[] args)
        {
            //Local variables 
            Flips[] flips = new Flips[COIN_FLIPS];//Stores the history of all of the tosses
            Random generator = new Random();// Generates random number values

            int heads = 0;//counts the number of heads
            int tails = 0;//counts the number of tails

            //Generates coin flips and counts heads and tails
            for (int i = 0; i < COIN_FLIPS; i++)
            {
                if (CoinFlip(generator) == Flips.Heads)
                {
                    heads++;
                    flips[i] = Flips.Heads;
                }
                else
                {
                    tails++;
                    flips[i] = Flips.Tails;
                }
            }

            //Print statistics
            PrintOutPut(flips, heads, tails);

            //Pause the screen
            Console.ReadLine();
        }
    }
}
