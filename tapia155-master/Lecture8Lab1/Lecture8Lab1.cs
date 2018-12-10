/// Lecture8	        Exercise No. Lab1
/// File Name:          Lecture8Lab1.cs
/// @author:            Angel Tapia
/// Date:               October 22, 2018
/// Problem Statement:  This program tests the a third version of class Fraction(Using Fraction as a struct).
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab1
{
    class Lecture8Lab1
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
