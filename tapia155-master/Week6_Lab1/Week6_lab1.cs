/// Chapter No. Week6	Exercise No. Lab1
/// File Name:          Week6_Lab1.cs
/// @author:            Angel Tapia
/// Date:               September 24, 2018
/// Problem Statement:  This Program is a simple game that 
///                     let the user guess a number which is generated
///                     by an object of the Random class.
/// Algorithm:
/// 1) Create an object of the Random class: Random generator = new Random();
/// 2) Create a local variables int random to store a generated value from 0 to 100: int random = generator.Next(101);
/// 3) Create a local variable int attempCount to count the number of attempts taken to guess the generated number.
/// 4) Create a local variable int currentAttempt = 0; to store the current attempt from the user.
/// 5) Print an initial message/instructions.
/// 6) Create a do-while loop to run the game [do-while (currentAttempt != random)]:
///     -Get a value from the user and store it in currentAttempt.
///     -If currentAttempt < random: Print "The number is more than " + currentAttempt".
///     -Else if currentAttempt > random: Print The number is less than " + currentAttempt".
///     -Else 
///         Print the number of attempts taken to guess the generated number.
///         Pause the screen.
/// 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Lab1
{
    class Week6_lab1
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int random = generator.Next(101);
            int attempCount = 0;
            int currentAttempt = 0;

            Console.WriteLine("Guess the generated number....");

            do
            {
                attempCount++;

                Console.Write("Enter a Guess: ");
                Int32.TryParse(Console.ReadLine(), out currentAttempt);

                if (currentAttempt < random)
                {
                    Console.WriteLine("The number is more than " + currentAttempt);
                }
                else if (currentAttempt > random)
                {
                    Console.WriteLine("The number is less than " + currentAttempt);
                }
                else
                {
                    Console.WriteLine("The number is more equal " + currentAttempt);
                    Console.WriteLine("Total Attempts: {0}", attempCount);
                    Console.WriteLine("Press ENTER to continue..");
                    Console.ReadLine();
                }

            } while (currentAttempt != random);



            Console.WriteLine("");

        }
    }
}
