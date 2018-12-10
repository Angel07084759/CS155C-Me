/// Chapter No. Week7	Exercise No. Homework6_1
/// File Name:          Homework6_1.cs
/// @author:            Angel Tapia
/// Date:               October 8, 2018
/// Problem Statement:  This program tests a class Counter by
///                     using a menu to call each of its method.
/// Algorithm:
/// 1) Create a class Counter:
///     =>Create an instance variable count to keep track of the current count.
///     =>Create a getter for count.
///     =>Create a reset method that sets count = 0.
///     =>Create an increment method that increments count by one:
///         if (count + 1) < 0 return false;
///         else increment count by one and return true.
///     =>Create an decrement method that decrements count by one:
///         if (count - 1) < 0 return false;
///         else decrement count by one and return true.
///     =>Create a method printCount that prints to the screen the current value of count.
///     =>Overrider ToString: Return the value of count as a string.
///     =>Override Equals: return true if count == other.count; false otherwise.
/// 2)Create a tester class (Implement Main):
///     =>Create an object of the class Counter.
///     =>Create a variable to store the user's current choice.
///     =>Create a while loop that loops while choice != 0:
///         =>Display a menu for [1] show count; [2] increment;
///           [3] decrement; [3] reset; and [0] exit.
///         =>Parse the use's choice to int.
///         =>Test for valid input.
///         =>Create a switch to perform operation (Call each method in each menu choice).
///     =>Pause the screen.
///         

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_1
{
    class Homework6_1
    {
        static void Main(string[] args)
        {
            //counter
            Counter counter = new Counter();
            int choice = -1;//user's choice

            while (choice != 0)
            {
                //Display menu
                Console.WriteLine("[1] Show count");
                Console.WriteLine("[2] Increment");
                Console.WriteLine("[3] Decrement");
                Console.WriteLine("[4] Reset");
                Console.WriteLine("[0] Exit");

                //Parse choice
                bool isValidInput = Int32.TryParse(Console.ReadLine(), out choice);
                choice = isValidInput ? choice : -1;//Test for valid inputs

                switch (choice)
                {
                    case 0://Exit
                        Console.WriteLine("Good Bye!!!");
                        break;
                    case 1://Show count
                        Console.Write("COUNRTER : ");
                        counter.printCount();
                        break;
                    case 2://Increment
                        counter.increment();
                        Console.Write("COUNRTER : ");
                        counter.printCount();
                        break;
                    case 3://Decrement
                        counter.decrement();
                        Console.Write("COUNRTER : ");
                        counter.printCount();
                        break;
                    case 4://Reset
                        counter.reset();
                        Console.Write("COUNRTER : ");
                        counter.printCount();
                        break;
                    default://Invalid input
                        Console.WriteLine("Please select 1, 2, 3, 4, or 0.");
                        break;
                }
            }
            //Pause the screen
            Console.ReadLine();
        }
    }
}
