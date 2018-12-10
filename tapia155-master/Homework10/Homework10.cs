/// Chapter No. Week10	Exercise No. Homework10
/// File Name:          Homework10.cs
/// @author:            Angel Tapia
/// Date:               November 15, 2018
/// Problem Statement:  This is
///                     
/// Algorithm:
/// 1) Create a class Alien:
///     Create an int const DAMAGE to represent the amount of damage this Alien can inflict.
///     Create instance variable for health and name.
///     Default constructor set health = 0 and name = "UNKNOWN".
///     Create a full constructor that initializes an alien with the given health and name.
///     Create Setter and Getter for health and name
///     Create a virtual method etDamange() that returns the amount of damage an alien can inflict.
///     override Equal and ToString
/// 2) Create a class Snake:
///     Create an const int to represent the amount of damage this Alien can inflict = 10;
///     Create a default constructor set health = 0 and name = "UNKNOWN" by calling the base constructor.
///     Create a full constructor that initializes an alien with the given health and name, by calling the base constructor.
///     Override GetDamage to return the amount of damage this can inflict.
/// 3) Create a class Ogre:
///     Create an const int to represent the amount of damage this Alien can inflict = 10;
///     Create a default constructor set health = 0 and name = "UNKNOWN" by calling the base constructor.
///     Create a full constructor that initializes an alien with the given health and name, by calling the base constructor.
///     Override GetDamage to return the amount of damage this can inflict.
/// 4) Create a class Marshallow:
///     Create an const int to represent the amount of damage this Alien can inflict = 10;
///     Create a default constructor set health = 0 and name = "UNKNOWN" by calling the base constructor.
///     Create a full constructor that initializes an alien with the given health and name, by calling the base constructor.
///     Override GetDamage to return the amount of damage this can inflict.
/// 5) Create a class AlienPack:
///     Create an instance variable array of Alien.
///     Create a constructor that receives the number of aliens to be store in the array of aliens.
///     Create a method AddAlein to add an alien to the array in the given index:
///         Add only if index id in side of bounds.
///     Create a method GetAliens to return the content of the array of alien.
///     Create a method CalculateDamange that returns the total damage this alien pack contains:
///         Use a foreach loop to get the amount of damage each alien can inflict.
///         Add them all together.
///         Return results.
/// 6) Create a Tester class:
///     Create an instance of AlienPack of size 5;
///     Call the method AddAliens to add 5 different aliens.
///     Use a for each to cal the ToString method for each alien in the
///     alien pack.
///     Call the method CalculateDamage to display the total damage this
///     pack of alien can inflict.
///     Pause the screen.
///     
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class Homework10
    {
        static void Main(string[] args)
        {
            int numAliens = 5;
            AlienPack aliens = new AlienPack(numAliens);

            aliens.AddAlien(new Snake(50, "Rattles"), 0);
            aliens.AddAlien(new Ogre(100, "Shrek"), 1);
            aliens.AddAlien(new Marshallow(25, "Sponge"), 2);
            aliens.AddAlien(new Snake(80, "Anaconda"), 3);
            aliens.AddAlien(new Ogre(90, "Phiona"), 4);


            foreach (Alien alien in aliens.GetAliens())
            {
                Console.WriteLine(alien);
            }

            Console.WriteLine("\nTotal damage in the alien pack: " + aliens.CalculateDamage());
            Console.ReadLine();
        }
    }
}
