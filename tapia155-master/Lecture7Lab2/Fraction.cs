/// Lecture7	        Exercise No. Lab2
/// File Name:          Fraction.cs
/// @author:            Angel Tapia
/// Date:               October 15, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Lab2
{
    class Fraction
    {
        //Instance Variables for numerator and denominator.
        private int _numerator;
        private int _denominator;

        //Numerator Property
        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }        
        }
        //Denominator Property
        public int Denominator
        {
            get { return _denominator;}
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("ERROR: Denominator = 0 is not allowed!!!! Please stop the program......");
                    Console.ReadLine();
                }
                _denominator = value;
            }
        }

        //Sets values to numerator and denominator (uses Setters).
        public void setFraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        //Finds and returns the Greatest Common Denominator.
        public int getGCD()
        {
            int min = _numerator < _denominator ? _numerator : _denominator;
            for(int i = min; i >=1; i--)
            {
                if (_numerator % i == 0 && _denominator % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }

        //Returns the current fraction as a decimal value.
        public double getAsDoubleValue()
        {
            return _numerator / (double) _denominator;
        }

        //Returns the current fraction reduced to its lowest term.
        public string getReducedToLowestTerm()
        {
            int gcd = getGCD();
            return (_numerator / gcd) + "/" + (_denominator / gcd);
        }

        //Returns the current fraction as string.
        public override string ToString()
        {
            return _numerator + "/" + _denominator;
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
