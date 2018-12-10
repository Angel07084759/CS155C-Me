/// Chapter No. Week8	Exercise No. Homework7_1
/// File Name:          Odometer.cs
/// @author:            Angel Tapia
/// Date:               October 22, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_1
{
    class Odometer
    {
        private double miles;//Represents miles driven.
        private double fuel;//Represents fuel consumed.

        //Default Constructor that sets miles and fuel to 0.
        public Odometer()
        {
            this.miles = 0;
            this.fuel = 0;
        }

        //Constructor that sets miles and fuel to the given values.
        public Odometer(double miles, double fuel) : this()
        {
            this.miles = miles;
            this.fuel = fuel;
        }

        //Setter for miles (miles must be >= 0).
        public void SetMiles(double miles)
        {
            if (miles >= 0)
            {
                this.miles = miles;
            }
        }

        //Setter for fuel (fuel must be >= 0).
        public void SetFuel(double fuel)
        {
            if (fuel >= 0)
            {
                this.fuel = fuel;
            }
        }

        //Getter for miles (Returns the current value in miles).
        public double GetMiles()
        {
            return this.miles;
        }

        //Getter for fuel (Returns the current value in fuel).
        public double GetFuel()
        {
            return this.fuel;
        }

        //Resets miles and fuel to 0.
        public void Reset()
        {
            SetFuel(0);
            SetMiles(0);
        }

        //Add the given miles and fuel to the current miles and fuel (given values must be >= 0).
        public void Add(double miles, double fuel)
        {
            if (miles >= 0 && fuel >= 0)
            {
                this.miles += miles;
                this.fuel += fuel;
            }
        }

        //Returns the Miles Per Gallon based on the current values.
        public double GetMPG()
        {
            return fuel == 0 ? 0 : miles / fuel; 
        }

        //Builds and returns a string representation of the current object.
        public override string ToString()
        {
            return "MILES: " + miles +  "   FULE: " + fuel + "   MPG: " + GetMPG();
        }

        //Compares this and another Odometer object.
        //Returns true if their miles and fuels are equivalents.
        public override bool Equals(object obj)
        {
            if (null == obj || GetType() != obj.GetType())
            {
                return false;
            }
            Odometer other = (Odometer)obj;
            return miles == other.miles && fuel == other.fuel;
        }
    }
}
