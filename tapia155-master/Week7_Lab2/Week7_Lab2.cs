/// Chapter No. Week7	Exercise No. Week7_Lab2
/// File Name:          Week7_Lab2.cs
/// @author:            Angel Tapia
/// Date:               October 8, 2018
/// Problem Statement:  This program Tests a class fraction which can be
///                     used to Create fractions; simplifies them; and 
///                     find its Greatest Common Denominator.
///                     
///                     
/// Algorithm:
/// 1) Create a class counter.
///     =>Create Instance Variables for numerator and denominator.
///     =>Create Getters and Setters for numerator and denominator.
///       (Display error if denominator is set = 0.)
///     =>Create setFraction method that sets numerator and denominator.
///       (Call each setter to set the values.)
///     =>Create a getGCD that finds and returns the Greatest Common Denominator:
///         =>for int i = min; i >=1; i--: 
///             if numerator % i == 0 && denominator % i == 0 
///                 return i;
///         =>Return 1 if fails to find GCD.
///     =>Create a getAsDoubleValue method that returns the current fraction as a decimal value.
///     =>Override ToString:
///         =>Returns The current fraction with out simplifying it.
///     =Override Equals:
///         Return true if  getAsDoubleValue() == other.getAsDoubleValue(); false otherwise.
/// 2) Create a tester class (implement Main):
///     =>Create an object of the Random class.
///     =>Create an object of the Fraction class.
///     =>Create a for loop to generate 20 random fractions:
///         Set fractions to new values (numerator and denominator).
///         Find Greatest Common Denominator(call  fraction.getGCD()).
///         Get reduced fraction (call fraction.getReducedToLowestTerm()).
///         Get fraction a decimal value ( call fraction.getAsDoubleValue());
///         Print all of the values.
///         Pause The screen.
///         
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Lab2
{
    class Week7_Lab2
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
