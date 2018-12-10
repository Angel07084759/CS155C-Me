/// Chapter No. Week9	Exercise No. Homework9
/// File Name:          Truck.cs
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
    //Truck is a derived class from Vehicle and represents
    //a truck by adding a load capacity in tons and towing capacity in pounds.
    class Truck : Vehicle
    {
        //Instance variables.
        private double load;//load capacity in tons.
        private int towing;//towing capacity in pounds.
        
        //Default constructor that initializes instance variable to 0 and default base values. 
        public Truck() : base()
        {
            SetLoad(0.0);//0.0 tons
            SetTowing(0);//0 pounds
        }

        //Full constructor that initializes all of the instance variable with the given values.
        //(load capacity in tons and towing capacity in pounds.)
        public Truck(Manufacturer name, int numCyl, Person owner, double load, int towing) : base(name, numCyl, owner)
        {
            SetLoad(load);
            SetTowing(towing);
        }

        //Properties might not be appropriate.
        //public double Load { get { return load; } set { load = value; } }
        //public int Towing { get { return towing; } set { towing = value; } }

        //Getter for load.
        public double GetLoad()
        {
            return this.load;
        }

        //Getter for towing
        public int GetTowing()
        {
            return this.towing;
        }

        //Setter for load.
        public void SetLoad(double load)
        {
            this.load = load;
        }

        //Setter for towing.
        public void SetTowing(int towing)
        {
            this.towing = towing;
        }

        //Builds and returns a string representation of a vehicle.
        public override string ToString()
        {
            return base.ToString() + String.Format("  {0, -10} {1, -10}", load, towing);
        }

        //Returns true if all of the values from this truck are equivalent to the other truck.
        public override bool Equals(object obj)
        {
            if (null == obj && GetType() != obj.GetType())
            {
                return false;
            }
            Truck other = (Truck)obj;
            return base.Equals(other) && load == other.load && towing == other.towing; 
        }
    }
}
