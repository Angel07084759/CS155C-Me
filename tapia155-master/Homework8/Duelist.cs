/// Lecture8	        Exercise No. Homework8
/// File Name:          Duelist.cs
/// @author:            Angel Tapia
/// Date:               October 29, 2018
/// Class Duelist represents a dueler for a shooting contest.  
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    
    class Duelist
    {
        //Simulates a shooting at target by generating a random-pseudo-code number.
        public static readonly Random randomGenerator = new Random();

        //Instance variable.
        private String name;//duelist name.
        private double accuracy;//duelist accuracy.
        private bool isAlive;//duelist is alive.

        //Default constructor  that initializes name = "UNKBOW", accuracy = 0.0, isAlive = false.
        public Duelist()
        {
            this.Name ="UNKNOWN";
            this.Accuracy = 0.0;
            this.IsAlive = false;
        }

        //Full constructor that initializes name, accuracy, and isAlive with the given values.
        public Duelist(String name, double accuracy, bool isAlive) : this()
        {
            Name = name;
            Accuracy = accuracy;
            IsAlive = isAlive;
        }
         
        //Properties for name.
        public String Name { get { return name; } set { name = value; } }

        //Property for accuracy.
        public double Accuracy {  get { return accuracy; } set { accuracy = value; } }

        //Property for isAlive.
        public bool IsAlive { get { return isAlive; } set { isAlive = value; } }

        //Simulates this dueler shooting at target (another dueler):
        //sets the other dueler to isAlive = false if 
        //randomGenerator.NextDouble() <= accuracy and returns true; false otherwise.
        public bool ShootAtTarget(Duelist target)
        {
            if (null != target && randomGenerator.NextDouble() <= accuracy)
            {
                target.IsAlive = false;
                return true;
            }
            return false;
        }

        //Builds and return a string representation of this duelist.
        public override string ToString()
        {
            return "NAME: " + name + "  ACCURACY: " + accuracy + "  IS_ALIVE: "  + isAlive;
        }

        //Compares all of the instance variable to be equal by values.
        //return true if all of the instance variable to be equal by values; false otherwise.
        public override bool Equals(object obj)
        {
            if (null == obj || GetType() != obj.GetType())
            {
                return false;
            }
            Duelist other = (Duelist)obj;
            return name.Equals(other.name) && accuracy == other.accuracy && isAlive == other.isAlive;
        }
    }
}
