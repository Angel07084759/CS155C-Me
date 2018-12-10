/// Chapter No. Week2	Exercise No. Lab2
/// File Name:          MyFirstProgram.cs
/// @author:            Angel Tapia
/// Date:               August 27, 2018
///
/// Problem Statement:  This program calculates the number of 
///                     CandyBars and GumBalls that can be exchanged
///                     for a number of coupons gottten in a videogame store.
/// Overall Plan:
/// 1) Declare constants: 
///     COUPONTS_PER_CB which represents cuopons per Candy Bar.
///     COUPONTS_PER_GB which represents cuopons per Gum Ball
/// 2) Prints initial message/instruction.
/// 3) Declare local variables:
///     int  numberOfCoupons for current number of coupons.
///     int numberOfCandyBars to store the possible candy bars.
///     int numberOfGumBall to store the possible gum balls.
/// 4) Ask the user to enter the number of coupons to be redeemed.
/// 5) Calculate number of Candy Bars; number of Gum Balls; and number of coupons left
///     numberOfCandyBars = numberOfCoupons / COUPONTS_PER_CB;
///     numberOfCoupons %= COUPONTS_PER_CB;
///     numberOfGumBall = numberOfCoupons / COUPONTS_PER_GB;
///     numberOfCoupons %= COUPONTS_PER_GB;
/// 6) Print results.
/// 7) Pause the screen.
/// 

using System;

namespace Week2_Lab2
{
    class Week2_Lab2
    {
        // Declare constants
        public const int COUPONTS_PER_CB = 10;
        public const int COUPONTS_PER_GB = 3;

        static void Main(string[] args)
        {
            // Declare local variables
            int numberOfCoupons = 0;
            int numberOfCandyBars = 0;
            int numberOfGumBall = 0;

            // Prints initial message
            Console.WriteLine("I will calculate the number of Candy Bars and GumBalls for your coupons!");

            // Ask the user for number of coupons
            Console.WriteLine("Enter the number of coupons");
            numberOfCoupons =  Int32.Parse(Console.ReadLine());

            //calculate number of Candy Bars; number of Gum Balls; and number of coupons left
            numberOfCandyBars = numberOfCoupons / COUPONTS_PER_CB;
            numberOfCoupons %= COUPONTS_PER_CB;
            numberOfGumBall = numberOfCoupons / COUPONTS_PER_GB;
            numberOfCoupons %= COUPONTS_PER_GB;

            // Print results
            Console.WriteLine("Number of Candy Bars: {0, -10}", numberOfCandyBars);
            Console.WriteLine("Number of Gum Balls:  {0, -10}", numberOfGumBall);
            Console.WriteLine("Remaining Coupons:    {0, -10}", numberOfCoupons);

            // Pause the screen
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}