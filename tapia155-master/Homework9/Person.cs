/// Chapter No. Week9	Exercise No. Homework9
/// File Name:          Person.cs
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
    //Person is a really simple class that represents a person by the name.
    class Person
    {
        //Instance variable
        private String name;//The person's name.

        //Default constructor that sets the name of the person as "UNKNOWN".
        public Person()
        {
            SetName("UNKOWN");
        }

        //Full constructor that sets name to the given value. 
        public Person(string theName) : this()
        {
            this.name = theName; 
        }

        //Constructor that sets name from an existent Person object's name. 
        public Person(Person obj)
        {
            if (null == obj)
            {
                throw new Exception("Person obj is null.");
            }
            this.name = obj.name;
        }

        //Getter for name
        public string GetName()
        {
            return this.name;
        }

        //Setter for name
        public void SetName(string name)
        {
            this.name = name;
        }

        //Return the name of the person
        public override string ToString()
        {
            return name;
        }

        //Returns true if the names of this an another person are equivalent; false otherwise.
        public override bool Equals(Object obj)
        {
            if (null == obj && GetType() != obj.GetType())
            {
                return false;
            }
            Person other = (Person)obj;
            return name == other.name;
        }
    }
}
