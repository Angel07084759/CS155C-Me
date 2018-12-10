/// Chapter No. Week8	Exercise No. Homework7_1
/// File Name:          Homework7_1.cs
/// @author:            Angel Tapia
/// Date:               October 22, 2018
/// Problem Statement:  This is a tester program for the class Temperature.
///                     This testes all of the Constructors, Setters, and Getters
///                     Created withing the class.
/// Algorithm:
/// 1) Create a Temperature Class:
///     Create char constants to represent scale ( F, Fahrenheit and C, Celsius) 
///     Create instance variables for char scale and double temperature.
///     Create a default constructor that sets scale to Celsius and temperature to 0.
///     Create a constructor that sets scale to the given value and temperature to 0.
///     Create a constructor that sets temperature to the given value and scale to Celsius.
///     Create a constructor that sets temperature and scale to the given value.
///     Create setter for scale: Sets scale ONLY if the given value is either F or C.
///     Create setter for temperature.
///     Create a method SetTemperature(char scale, double temperature):
///     Set scale and temperature using the setters for scale and temperature.
///     Create a GetScale that returns the current scale value.
///     Create a GetTempCel method that calculates and returns the current 
///     temperature in Celsius, using the formula: (temperature - 32) * 5.0 / 9.0
///     Create a GetTempFah method that calculates and returns the current 
///     temperature in Fahrenheit, using the formula: (temperature * 9.0 / 5.0) + 32
///     Override ToString: Build and return a string representation of the current object
///     Override Equals:
///         Compares this and another Odometer object.
///         Return true if their getTempFah method are equals.
/// 2) Create a tester class (implement Main):
///     Create temp1 using default constructor
///         Display GetTempCel and GetTempFah
///     Create temp2 using the constructor to set scale: F
///         Display the ToString
///     Create temp3 using the constructor to set temperature: 30
///         Display GetScale(),  GetTempCel(),  GetTempFah()
///     Create temp4 using a full constructor: f, 86
///         Display the ToString
///     Print GetScale(),  GetTempCel(),  GetTempFah(), and ToString on temp 2, 3, 4
///     Print TEMP#4 Equal(TEMP#3)
///     Print TEMP#4 Equal(TEMP#2)
///     Print End of the test


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_2
{
    class Homework7_2
    {
        static void Main(string[] args)
        {
            //Note: Setters are used in all constructors, So Setters test are covered.

            Console.WriteLine("Test TEMP#1...Default constructor = default values: Celsius and 0 degrees...");
            Temperature temp1 = new Temperature();
            Console.WriteLine("*TEMP#1 GetTempCel(): {0},  GetTempFah(): {1}", temp1.GetTempCel(), temp1.GetTempFah());

            Console.WriteLine("\nTest TEMP#2...using constructor to sets scale: F...");
            Temperature temp2 = new Temperature('F');

            Console.WriteLine("*TEMP#2 ToString(): {0}", temp2.ToString());

            Console.WriteLine("\nTest TEMP#3...using constructor to sets temperature: 30...");
            Temperature temp3 = new Temperature(30);
            Console.WriteLine("*TEMP#3 GetScale(): {0},  GetTempCel(): {1},  GetTempFah(): {2}", temp3.GetScale(), temp3.GetTempCel(), temp3.GetTempFah());

            Console.WriteLine("\nTest TEMP#4...using constructor to sets temperature: 86 and scale f...");
            Temperature temp4 = new Temperature('f', 86);
            Console.WriteLine("*TEMP#4 ToString(): {0}", temp4.ToString());

            Console.WriteLine("\n*TEMP#2 GetScale(): {0},  GetTempCel(): {1},  GetTempFah(): {2},  ToString(): {3}", temp2.GetScale(), temp2.GetTempCel(), temp2.GetTempFah(), temp2);
            Console.WriteLine("*TEMP#3 GetScale(): {0},  GetTempCel(): {1},  GetTempFah(): {2},    ToString(): {3}", temp3.GetScale(), temp3.GetTempCel(), temp3.GetTempFah(), temp3);
            Console.WriteLine("*TEMP#4 GetScale(): {0},  GetTempCel(): {1},  GetTempFah(): {2},    ToString(): {3}", temp4.GetScale(), temp4.GetTempCel(), temp4.GetTempFah(), temp4);

            Console.WriteLine("*TEMP#4 Equal(TEMP#3): {0}", temp4.Equals(temp3));
            Console.WriteLine("*TEMP#4 Equal(TEMP#2): {0}", temp4.Equals(temp2));

            Console.WriteLine("END of the test!!!");

            Console.ReadLine();
        }
    }
}
