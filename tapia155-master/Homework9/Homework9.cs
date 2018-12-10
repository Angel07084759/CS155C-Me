/// Chapter No. Week9	Exercise No. Homework9
/// File Name:          Homework9.cs
/// @author:            Angel Tapia
/// Date:               November 6, 2018
/// Problem Statement:  This is tester program for inheritance using
///                     A simple definition of a Vehicle class and one
///                     subclass called Truck.
///                     
/// Algorithm:
/// 1) Create simple class Person that can be used in the class Vehicle as the owner:
///     Create an instance variable string name that represents the name of the person.
///     Implement a default constructor that sets name = "UNKNOWN"
///     Implement a constructor that receives a string name for the instance variable.
///     Implement a constructor that receives a Person object and set this.name = object.name.
///     Implement Getters and Setters for name.
///     Override ToString: return name.
///     Override Equal: compare and return true if this.name == other.name; false otherwise.
/// 2) Create a Vehicle class:
///     Create an enum Manufacturer that stores the name of the nine most popular vehicle manufacturers.
///     Create instance variable for:
///         Manufacturer name;//Manufacturer name
///         int numCyl;//number of cylinders
///         Person owner;//owner
///     Create a default constructor that initializes instance variables as 
///         a Ford vehicle of 4 cylinders with an unknown owner's name.
///     Create a constructor that initializes instance variables with the given values.
///     Create Getters and Setters for name and numCyl
///     Create Getter or owner:
///         Return a copy of a owner data: return new Person(owner);
///     Create a Setter for Person: set this.owner = new Person(obj);
///     Override ToString:
///         Build and return a string that contains the name, numCyl, and owner of the vehicle.
///     Override Equal:
///         Return true if this an another vehicle are equivalents in name and numCyl; false otherwise.
/// 3) Create a class Truck that is a derived class from Vehicle:
///     Create instance variable for:
///         double load;//load capacity in tons.
///         int towing;//towing capacity in pounds.
///     Create a default constructor that call the base default constructor and initializes
///         load = 0; and towing = 0;
///     Create a full constructor that initializes all of the instance variable with the given values:
///         Truck(Manufacturer name, int numCyl, Person owner, double load, int towing) :  base(name, numCyl, owner)
///     Create Setters and Getters for load and towing.
///     Override ToString:
///         Build and return the base ToString concatenating the load and towing capacity.
///     Override Equal:
///         return true if base.ToString, load, and towing are equivalent; false otherwise.
/// 4) Create a Tester class:
///     Implement Main:
///         Create two Person objects (use default and full constructor).
///         Create three Vehicle objects (use 1 default and 2 full constructor).
///             vehicle1.SetOwner(new Person("John Connor"));
///         Create three Truck objects (use 1 default and 2 full constructor).
///             For the truck with default constructor, use setters for:
///                 numCyl, load, and towing.
///         Display ToString of all of the Person objects.
///         Display ToString of all of the Vehicle objects.
///         Display ToString of all of the Trucks objects.
///         Display Equals comparing All of the vehicle and all the trucks.
///         
///     
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Homework9
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Angel Tapia");

            Vehicle vehicle1 = new Vehicle();
            vehicle1.SetOwner(new Person("John Connor"));
            Vehicle vehicle2 = new Vehicle(Manufacturer.Toyota, 6, person2);
            Vehicle vehicle3 = new Vehicle(Manufacturer.Toyota, 6, new Person());

            Truck truck1 = new Truck();
            truck1.SetNumCyl(vehicle2.GetNumCyl());
            truck1.SetLoad(2.0);
            truck1.SetTowing(1200);
            Truck truck2 = new Truck(Manufacturer.Dodge, 8, person2, 2.5, 11600);
            Truck truck3 = new Truck(Manufacturer.Dodge, 8, new Person(), 2.5, 11600);


            Console.WriteLine("Person1 ToString():  {0}", person1);
            Console.WriteLine("Person2 ToString():  {0}\n", person2);

            Console.WriteLine("Vehicle1 ToString(): {0}", vehicle1);
            Console.WriteLine("Vehicle2 ToString(): {0}", vehicle2);
            Console.WriteLine("Vehicle3 ToString(): {0}\n", vehicle3);

            Console.WriteLine("Truck1 ToString():   {0}", truck1);
            Console.WriteLine("Truck2 ToString():   {0}", truck2);
            Console.WriteLine("Truck2 ToString():   {0}\n", truck3);

            Console.WriteLine("Vehicle1.Equal(vehicle2):   {0}", vehicle1.Equals(vehicle2));
            Console.WriteLine("Vehicle2.Equal(vehicle3):   {0}\n", vehicle2.Equals(vehicle3));

            Console.WriteLine("truck1.Equal(truck2):   {0}", truck1.Equals(truck2));
            Console.WriteLine("truck2.Equal(truck3):   {0}", truck2.Equals(truck3));



            Console.ReadLine();
        }
    }
}
