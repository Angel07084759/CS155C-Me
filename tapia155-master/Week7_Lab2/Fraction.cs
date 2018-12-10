/// Chapter No. Week7	Exercise No. Week7_Lab2
/// File Name:          Fraction.cs
/// @author:            Angel Tapia
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Lab2
{
    class Fraction
    {
        //Instance Variables for numerator and denominator.
        private int numerator;
        private int denominator;

        //Getters
        //Returns the value of numerator.
        public int getNumerator()
        {
            return this.denominator;
        }
        //Returns the value of denominator.
        public int getDenominator()
        {

            return this.denominator;
        }

        //Setters
        //sets a value to numerator.
        public void setNumerator(int numerator)
        {
            this.numerator = numerator;
        }
        //Sets a value to denominator (Displays error if denominator == 0).
        public void setDenominator(int denominator)
        {
            if(denominator == 0)
            {
                Console.WriteLine("ERROR: Denominator = 0 is not allowed!!!! Please stop the program......");
                Console.ReadLine();
            }
            this.denominator = denominator;
        }

        //Sets values to numerator and denominator (uses Setters).
        public void setFraction(int numerator, int denominator)
        {
            setNumerator(numerator);
            setDenominator(denominator);
        }

        //Finds and returns the Greatest Common Denominator.
        public int getGCD()
        {
            int min = numerator < denominator ? numerator : denominator;
            for(int i = min; i >=1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }

        //Returns the current fraction as a decimal value.
        public double getAsDoubleValue()
        {
            return numerator / (double) denominator;
        }

        //Returns the current fraction reduced to its lowest term.
        public string getReducedToLowestTerm()
        {
            int gcd = getGCD();
            return (numerator / gcd) + "/" + (denominator / gcd);
        }

        //Returns the current fraction as string.
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        //Compares this fraction with another fraction.
        //Returns true if the decimal values are equals; false otherwise.
        public override bool Equals(object obj)
        {
            Fraction other = (Fraction) obj;
            return getAsDoubleValue() == other.getAsDoubleValue();
        }
    }
}
