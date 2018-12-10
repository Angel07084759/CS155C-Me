/// Chapter No. Week8	Exercise No. Homework7_1
/// File Name:          Homework7_1.cs
/// @author:            Angel Tapia
/// Date:               October 22, 2018
/// Problem Statement:  This is a tester program for a the class
///                     Odometer. It tests every created 
///                     method in the Odometer class.
/// Algorithm:
/// 1) Create an Odometer class:
///     Create instance variable for double miles, fuel
///         to represent the miles driven and the fuel consumed.
///     Create a default constructor (no parameters) that initializes
///         miles and fuel to 0.
///     Create a full constructor that initializes miles and fuel
///         to the given values.
///     Create Setter for miles and fuel:
///         Set value only if the given values >= 0
///     Create Getter for miles and fuel.
///     Creates a Reset method that sets miles and fuel to 0 (Use Setters).
///     Create an Add method that adds miles and fuel to the current miles and fuel:
///         Add the given values to miles and fuel only if both given values are positive values.
///     Create a method GetMPG that returns the Miles Per Gallon based on the current values:
///         return fuel == 0 ? 0 : miles / fuel; 
///     Override ToString:
///         Builds and returns a string representation of the current object.
///     Override Equals:
///         Compares this and another Odometer object.
///         Returns true if their miles and fuels are equivalents.
/// 2) Create a tester class (Implement Main):
///     Create first odometer: default constructor.
///         Test Setters and getters and print Getters.
///         Test Setters on invalid values (negative values) and print Getters.
///         Test GetMPG()
///         Print GetMPG()
///         Test Add and print ToString()
///     Create a second odometer with full constructor.
///         Test toString on the second odometer.
///     Test The Equals method: 
///         compare first and second odometer
///     Print end of the test.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_1
{
    class Homework7_1
    {
        static void Main(string[] args)
        {
            //Create first odometer: default constructor
            Console.WriteLine("Testing Odometer#1: Default Constructor....");
            Odometer odo = new Odometer();

            //Test Setters and getters   
            Console.WriteLine("Odometer#1: SetMiles(95), SetFuel(4)....");
            odo.SetMiles(95);
            odo.SetFuel(4);
            Console.WriteLine("Odometer#1: GetMiles(): {0}, GetFuel(): {1}", odo.GetMiles(), odo.GetFuel());
            Console.WriteLine("Odometer#1: SetMiles(-35), SetFuel(-2)...");
            //Test negative invalid values and print Getters

            odo.SetMiles(-35);
            odo.SetFuel(-2);
            Console.WriteLine("Odometer#1: GetMiles(): {0}, GetFuel(): {1}", odo.GetMiles(), odo.GetFuel());
            
            //Test GetMPG()
            Console.WriteLine("Odometer#1: GetMPG(): {0}, ", odo.GetMPG());
            
            //Test Reset and print Getters
            Console.WriteLine("Odometer#1: Reset()");
            odo.Reset();
            Console.WriteLine("Odometer#1: GetMiles(): {0}, GetFuel(): {1}", odo.GetMiles(), odo.GetFuel());
            Console.WriteLine("Odometer#1: Add(120, 3)");
            
            //Test Add and print ToString
            odo.Add(120, 3);
            Console.WriteLine("Odometer#1: ToString(): {0}", odo);

            //Create a second odometer with full constructor
            Console.WriteLine("\n\nTesting Odometer#2: Full Constructor(120, 3)");
            Odometer odo2 = new Odometer(120, 3);

            //Test Equal Method
            Console.WriteLine("Test odo1.Equal(odo2): {0}", odo.Equals(odo2));

            //Test Add
            Console.WriteLine("Odometer#2: Add(30, 1)...");
            odo2.Add(30, 1);

            //Test ToString
            Console.WriteLine("Odometer#1: ToString(): {0}", odo);
            Console.WriteLine("Odometer#2: ToString(): {0}", odo2);
            Console.WriteLine("Test odo1.Equal(odo2): {0}", odo.Equals(odo2));

            //Print end of the test
            Console.WriteLine("End of the Test.....");

            Console.ReadLine();
        }
    }
}
