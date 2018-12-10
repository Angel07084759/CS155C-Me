/// Chapter No. Week5	Exercise No. Week5_Lab1
/// File Name:          Week5_Lab1.cs
/// @author:            Angel Tapia, shaun Goebel
/// Date:               September 17, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Lab1
{
    class Program
    {
        //Constants
        public const int FINE = 60;
        public const int PENALTY = 250;
        public const int ADDITIONAL = 7;
        public const int OVER_TWENTY_FIVE = 25;

        static void Main(string[] args)
        {
            //Create locals variables
            int speedLimit = 0;
            int clockedSpeed = 0;
            int fineAmount = 0;
            
            //Get inputs from the user
            Console.WriteLine("Enter your speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Enter your clocked spped:");
            clockedSpeed = Convert.ToInt32(Console.ReadLine().Trim());

            //Check for legal speed
            if (clockedSpeed <= speedLimit)
            {
                Console.WriteLine("Your speed is legal!");
            }
            else//Calculate Fine
            {
                
                int temp = ((clockedSpeed - speedLimit) / OVER_TWENTY_FIVE);

                if (temp > 0)
                {
                    //Penalty for 25 mph
                    fineAmount += (PENALTY * temp);
                }

                //penalty for each mile over limit
                fineAmount += (clockedSpeed - speedLimit) * ADDITIONAL;
                fineAmount += FINE;
                //Print fine amount
                Console.WriteLine(fineAmount);
            }
            //pause the screen
            Console.ReadLine();
        }
    }
}
