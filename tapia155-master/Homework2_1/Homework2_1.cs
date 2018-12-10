/// Chapter No. Week2	Exercise No. Homework2_1
/// File Name:          Homework2_1.cs
/// @author:            Angel Tapia
/// Date:               September 9, 2018
///
/// Problem Statement:  This program translates your first and last
///                     name in pig Latin by moving the first letter
///                     to the end; capitalizing the second letter; and
///                     adding the suffix "ay" to your first and last name.
/// Overall Plan:
/// 1) Declare local variables:
///     string fName, to store the first name.
///     string lName, to store the last name.
///     string latinFname, to store the translated first name. 
///     string latinLname, to store the translated last name.
/// 2) Print initial message.
/// 3) Ask the user to enter his/her fist name; trim it; and store it in fName
/// 4) Ask the user to enter his/her last name; trim it; and store it in lName
/// 5) Translate the fName and store it in latinFName.
///     -add the second character of fName to latinFname as a upper case character.
///     -add the rest of the characters from subscript 2 from fName to latinFname.
///     -add the first letter of fName to the end of latinFname.
///     -add the prefix "ay" to the end of latinFname.
/// 6) Translate the lName and store it in latinLName.
///     -Use the same procedure as step 5 but using 
/// 7) print latinFname and latinLname.
/// 8) pause the screen.
/// 

using System;

namespace Homework2_1
{
    class Homework2_1
    {
        static void Main(string[] args)
        {
            //  declare local variables.
            string fName, lName, latinFname, latinLname;

            // Prints initial message.
            Console.WriteLine("This program translates your full name into Pig Latin!");

            // Ask the user to enter his/her first name.
            Console.WriteLine("Enter your first name: ");
            fName = Console.ReadLine().Trim();

            // Ask the user to enter his/her last name.
            Console.WriteLine("Enter your last name: ");
            lName = Console.ReadLine().Trim();

            // Translate first name.
            latinFname = fName.Substring(1, 1).ToUpper();
            latinFname += fName.Substring(2) + fName.Substring(0,1) + "ay";

            // Translate last name.
            latinLname = lName.Substring(1, 1).ToUpper();
            latinLname += lName.Substring(2) + lName.Substring(0, 1) + "ay";

            // Print result: first name and last name.
            Console.WriteLine(latinFname);
            Console.WriteLine(latinLname);

            // Pause the screen
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
