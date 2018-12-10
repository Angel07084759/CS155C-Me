/// Chapter No. Week4	Exercise No. Week4_Lab2
/// File Name:          Week4_Lab2.cs
/// @author:            Angel Tapia, shaun Goebel
/// Date:               September 10, 2018


using System;

namespace Week4_Lab2
{
    class Week4_Lab2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            String input = "";
            Console.WriteLine("Lamp Troubleshooting");
            Console.WriteLine("Is the Lamp Plugged In? (y/n): ");
            input = Console.ReadLine();
            input.ToLower();
            if( input.Equals("n") || input.Equals("no"))
            {
                Console.WriteLine("Plug in Lamp!!");
            }
            else if (input.Equals("y") || input.Equals("yes"))
            {
                Console.WriteLine("Is Bulb burned out? (y/n): ");
                input = Console.ReadLine();
                input.ToLower();
                if (input.Equals("y") || input.Equals("yes"))
                {
                    Console.WriteLine("Replace bulb!");
                }
                else
                {
                    Console.WriteLine("Repair Lamp!");
                }
            }
            // Pause the screen
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
