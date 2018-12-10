/// Lecture8	        Exercise No. Homework8
/// File Name:          Duelist.cs
/// @author:            Angel Tapia
/// Date:               October 29, 2018
/// Problem Statement:  This program simulates a contest with three 
///                     duelist, Aaron, Bob, and Charlie. these duelers
///                     take turn starting with the least deadly to the
///                     most deadly shooter. Each one uses the strategy
///                     targeting the most deadly shooter that is currently 
///                     alive. As an alternative for Aaron is missing his 
///                     first shot to increment his chance to wining the contest.
/// Algorithm:
/// 1) Create a class Duelist:
///     *Create a static readonly Random randomGenerator to 
///      simulate each shooting at target
///     *Create instance variable for 
///         String name to represent the duelist's name
///         double accuracy to represent the duelist's accuracy
///         bool isAlive to check if duelist is alive.
///     *Create Constructors:
///         Default constructor  that initializes name = "UNKBOW", accuracy = 0.0, isAlive = false.
///         Full constructor that initializes name, accuracy, and isAlive with the given values.
///     *Properties for name.
///     *Properties for accuracy.
///     *Properties for isAlive.
///     *Crete a ShootAtTarget(Duelist target) that simulates this dueler shooting at target (another dueler):
///         if randomGenerator.NextDouble() <= accuracy set target.IsAlive = false and 
///         return true; else return false.
///     *Override ToString by building and returning a string representation of this duelist.
///     *Override Equals by Comparing all of the instance variable to be equal by values.
/// 2) Write a Tester class:
///     *Create a method bool CurrentShooter(Duelist[] duelers, int current):
///         if current is an index value that is in bound of duelers: 
///             Use a for looop to find and shoot at target that is the dueler that is 
///             still alive and that is the most deadly of all of the current duelers
///             Return true is successfully shot at target; false otherwise;
///     *Create a method Duelist SingleDuel(Duelist[] duelers, bool missFirst):
///         If Duelist[] == null return null;
///         Else: Create a for-loop to Select dueler by turn:
///         If missFirst == true: start the loop i = 1: else i = 0:
///             for (int i = missFirst ? 1 : 0; countAlive > 1; i++)
///                 Find and shoot the most deadly shooter that is currently alive:
///                 Select dueler by turn: int index = i % duelers.Length;
///                 If Current shooter hits the target:
///                     winner = duelers[index];
///                     countAlive--;
///                 Else: Next shooter takes turn.
///             Return the winner Duelist.
///     *Create a method void ConstestAaronBobCharlie(int testQuantity, bool missFirst).
///      This method simulates and prints result for a contest with three duelers Aaron, Bob, and Charlie, 
///      with the given number of test and missFirst = true if Aaron intentionally misses his first shot.
///         Create a string array to store the names of the duelists.
///         Create a double array to store the duelists' accuracy.
///         Create an int array t store the number of time winning for each contestant.
///         Create a for loop to perform the given number of tests:
///             Create three objects of the type Duelist using the created 
///             names and accuracy and Store them in an Duelist array.
///             Call the method SingleDuel(duelers, missFirst) and
///             get the name of the winner given by its return value:
///                 String winnerName = SingleDuel(duelers, missFirst).Name;
///             counting number of time winning for each contestant:
///                 winningCount[Array.IndexOf(names, winnerName)]++; 
///         Create a for loop to display results.
///     *Implement Main:
///         Test#1 Intentionally Missing first shot....
///         ConstestAaronBobCharlie(testQuantity, true);
///         Test#2 Intentionally Missing first shot....
///         ConstestAaronBobCharlie(testQuantity, true);
///         Test#3 (every one shooting at target)....
///         ConstestAaronBobCharlie(testQuantity, false);
///         Test#4 (every one shooting at target)....
///         ConstestAaronBobCharlie(testQuantity, false);
///         pause screen
///         
/// QUESTIONS:
/// Which strategy is better for Aaron: 
/// to intentionally miss on the first shot 
/// or to try and hit the best shooter? 
///     *Aaron has better chances if he intentionally misses his first shot.
///     
/// Who has the best chance or winning, the best shooter or the worst shooter? 
///     *By taking turn starting with the worst shooter first, THE BEST SHOOTER HAS LESS CHANCE TO WIN.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Homework8
    {
        //Current dueler finds and shoots at target which is 
        //the dueler that is still alive and that is the most 
        //deadly of all of the current duelers.
        //
        //Precondition: For accurate results, Dueler array must be ordered by the least to 
        //              most deadly; current should be a valid index value in the Duelist array.
        //
        //Returns true if the current shooter shoots at target successfully; false otherwise.
        public static bool CurrentShooter(Duelist[] duelers, int current)
        {
            //Checks for current inside bounds
            if (current >= 0 && current < duelers.Length)
            {
                for (int i = duelers.Length - 1; i >= 0; i--)
                {
                    //Finds the most deadly first and shoots.
                    if (i != current && null != duelers[i] && duelers[i].IsAlive)
                    {
                        //returns true if shooter shoots at target successfully; false otherwise.
                        return duelers[current].ShootAtTarget(duelers[i]);
                    }
                }
            }
            return false;
        }

        //Contest simulates a contest where duelers take turn starting from the least deadly.
        //Each contestant uses will target the most deadly that is still alive
        //
        //Precondition: For accurate results, Dueler array must be ordered by the least to most deadly.
        //
        //if missFirst == true the first dueler misses intentionally.
        //Return the winner duelist in this contest or null if undefined.
        public static Duelist SingleDuel(Duelist[] duelers, bool missFirst)
        {            
            Duelist winner = null;//selects the winner
            if (null != duelers)
            {
                int countAlive = duelers.Length;//All duelers are alive at the beginning
                for (int i = missFirst ? 1 : 0; countAlive > 1; i++)//i = 1 if missFirst = true; else i = 0
                {
                    int index = i % duelers.Length;//Selecting dueler by turn.
                    if (null == duelers[index])//FIXED: checks null elements
                    { 
                        countAlive--;
                    }
                    else if (duelers[index].IsAlive && CurrentShooter(duelers, index))
                    {
                        winner = duelers[index];
                        countAlive--;
                    }
                }
            }
            return winner;
        }

        //Simulates and prints result for a contest with three duelers 
        //Aaron, Bob, and Charlie, with the given number of test and 
        //missFirst = true if Aaron intentionally misses his first shot.
        public static void ConstestAaronBobCharlie(int testQuantity, bool missFirst)
        {
            String[] names = new string[] { "Aaron", "Bob", "Charlie" };
            double[] accuracy = new double[] { (1.0 / 3.0), (1.0 / 2.0), 0.95 };
            int[] winningCount = new int[] { 0, 0, 0 };

            for (int i = 0; i < testQuantity; i++)
            {
                //Creating duelers
                Duelist aaron = new Duelist(names[0], accuracy[0], true);
                Duelist bob = new Duelist(names[1], accuracy[1], true);
                Duelist charlie = new Duelist(names[2], accuracy[2], true);
                Duelist[] duelers = new Duelist[] { aaron, bob, charlie };

                //Getting winner from a single duel
                String winnerName = SingleDuel(duelers, missFirst).Name;

                //counting number of time winning for each contestant.
                winningCount[Array.IndexOf(names, winnerName)]++; 
            }

            //Printing results
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0, -10} = {1, -10} = {2:P}", 
                    names[i], winningCount[i], winningCount[i] / (double) testQuantity);
            }
        }

        //Runs four tests for ConstestAaronBobCharlie; 
        //two Intentionally Missing first shot
        //two every one shotting at target
        static void Main(string[] args)
        {
            int testQuantity = 10000;
            Console.WriteLine("Test#1 Intentionally Missing first shot....");
            ConstestAaronBobCharlie(testQuantity, true);

            Console.WriteLine("\nTest#2 Intentionally Missing first shot....");
            ConstestAaronBobCharlie(testQuantity, true);

            Console.WriteLine("\nTest#3 (every one shooting at target)....");
            ConstestAaronBobCharlie(testQuantity, false);

            Console.WriteLine("\nTest#4 (every one shooting at target)....");
            ConstestAaronBobCharlie(testQuantity, false);

            //pause screen
            Console.ReadLine();
        }
    }
}
