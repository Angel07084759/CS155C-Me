/// Lecture7	        Exercise No. Lab2
/// File Name:          Fraction.cs
/// @author:            Angel Tapia
/// Date:               October 15, 2018
/// Problem Statement:  This program tests the a second version of class Fraction.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Lab2
{
    class Lecture7Lab2
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Fraction fraction = new Fraction();

            for (int i = 0; i < 20; i++)
            {
                fraction.setFraction(random.Next(1, 100), random.Next(1, 100));

                string gcd = fraction.getGCD().ToString();
                string reduced = fraction.getReducedToLowestTerm();
                string asDouble = fraction.getAsDoubleValue().ToString();

                Console.WriteLine("ToString: {0, -5}  GCD(): {1, -4}  Reduced: {2, -8}  Double: {3}", fraction, gcd, reduced, asDouble);
            }

            Console.ReadLine();
        }
    }
}
