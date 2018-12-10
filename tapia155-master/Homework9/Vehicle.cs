/// Chapter No. Week9	Exercise No. Homework9
/// File Name:          Vehicle.cs
/// @author:            Angel Tapia
/// Date:               November 6, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    //Manufacturer stores the name of the nine most popular vehicle manufacturers
    enum Manufacturer { Ford, Nissan, Toyota, Chrysler, Honda, Buick, Chevrolet, Dodge, Mercedes };

    //Vehicle is a simple class that represents a vehicle by the 
    //Manufacturer name; number of cylinder, and owner.
    class Vehicle
    {
        //Instance variables
        private Manufacturer name;//Manufacturer name
        private int numCyl;//number of cylinders
        private Person owner;//owner

        //Default constructor that initializes instance variables as
        //a Ford vehicle of 4 cylinders with an unknown owner's name.
        public Vehicle()
        {
            SetName(Manufacturer.Ford);
            SetNumCyl(4);
            SetOwner(new Person());
        }

        //Constructor that initializes instance variables with the given values.
        public Vehicle(Manufacturer name, int numCyl, Person owner) : this()
        {
            SetName(name);
            SetNumCyl(numCyl);
            SetOwner(owner);
        }

        //Properties might not be appropriate.
        //public int NumCyl { get { return numCyl; } set { numCyl = value; } }
        //public Person Owner { get { return owner; } set { owner = value; } }
        //public Manufacturer Name { get { return name; } set { name = value; } }

        //Getter for name.
        public Manufacturer GetName()
        {
            return this.name;
        }

        //Getter for numCyl.
        public int GetNumCyl()
        {
            return this.numCyl;
        }

        //Getter for owner: Returns a deep copy of the owner's data.
        public Person GetOwner()
        {
            return new Person(owner);
        }

        //Setter for name.
        public void SetName(Manufacturer name)
        {
            this.name = name;
        }

        //Setter for numCyl.
        public void SetNumCyl(int numCyl)
        {
            this.numCyl = numCyl;
        }

        //Setter for owner: sets owner with a deep copy of the given person.
        public void SetOwner(Person obj)
        {
            this.owner = new Person(obj);
        }

        //Builds and returns a string representation of a vehicle.
        public override string ToString()
        {
            return String.Format("{0, -10} {1, -10} {2, -10}", name, numCyl, owner);
        }

        //Returns true if name and numCyl from this vehicle are equivalent to the other vehicle.
        public override bool Equals(object obj)
        {
            if (null == obj && GetType() != obj.GetType())
            {
                return false;
            }
            Vehicle other = (Vehicle) obj;
            return name.Equals(other.name) && numCyl == other.numCyl;
        }
    }
}
