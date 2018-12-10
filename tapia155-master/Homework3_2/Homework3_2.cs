/// Chapter No. Week4	Exercise No. Homework3_2
/// File Name:          Homework3_2.cs
/// @author:            Angel Tapia
/// Date:               September 11, 2018
/// Problem Statement:  This program simulates a veding that
///                     calculate the changed to be given
///                     based on the item price.
/// Algorithm:
/// 1) Create constants for coins values in cents.
/// 2) Create locla variables:
///     int price and string result.
/// 3) Print initial message.
/// 4) Ask the user to enter the price of the item in cents (25-100).
/// 5) Parce input: use Int32.TryParse.
/// 6) Validate and calculate input:
///     if price < 25 || price > 100: print invalid input
///     else Calculate change:
///         change  = 100 - change;
///         result += change / QUATER_IN_CENTS
///         change  = change % QUATER_IN_CENTS
///         result += change / DIME_IN_CENTS
///         change  = change % DIME_IN_CENTS
///         result += change / NICKEL_IN_CENTS
///         change  = change % NICKEL_IN_CENTS
/// 7) Pause the screen.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_2
{
    class Homework3_2
    {
        // Constants for coins values
        public const int QUATER_IN_CENTS = 25;
        public const int DIME_IN_CENTS   = 10;
        public const int NICKEL_IN_CENTS =  5;

        static void Main(string[] args)
        {
            // Local variables
            int change = 0;
            String result = "";

            // Initial message
            Console.WriteLine("-------------------- Vending Machine --------------------");
            Console.WriteLine("Enter price of item (in cents from 25 to 100 cents, in 5-cent increments):");

            // Parse input
            Int32.TryParse(Console.ReadLine(), out change);

            // Validate and calculate input
            if (change < 25 || change > 100)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                change = 100 - change;
                result += "Your change is: ";
                result += (change / QUATER_IN_CENTS) + " quaters, ";
                change =   (change % QUATER_IN_CENTS);
                result += (change / DIME_IN_CENTS) + " dimes, and ";
                change =   (change % DIME_IN_CENTS);
                result += (change / NICKEL_IN_CENTS) + " nickels.";
                change =   (change % NICKEL_IN_CENTS);
                   
                Console.WriteLine(result);
                
            }

            // pause the screen
            Console.WriteLine("Press any key to continuo...");
            Console.ReadLine();
        }
    }
}
