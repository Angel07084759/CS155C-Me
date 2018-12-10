/// Chapter No. Week10	Exercise No. Homework10
/// File Name:          Alien.cs
/// @author:            Angel Tapia
/// Date:               November 15, 2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    /// Class Alien Represent an alien or a 
    /// monster that can inflict and get damage.
    class Alien
    {
        //The amount of damage this Alien can inflict.
        private const int DAMAGE = 0;

        public int health; //0 = dead, 100 = full.
        public string name;//The name of this alien.

        //Default constructor set health = 0 and name = "UNKNOWN".
        public Alien()
        {
            SetHealth(0);
            SetName("UNKNOWN");
        }

        //Full constructor that initializes an alien with the given health and name.
        public Alien(int health, string name) : this()
        {
            SetHealth(health);
            SetName(name);
        }

        //Setter for health.
        public void SetHealth(int health)
        {
            this.health = health;
        }

        //Setter for name.
        public void SetName(string name)
        {
            this.name = name;
        }

        //Getter for health
        public int GetHealth()
        {
            return this.health;
        }

        //Getter for name.
        public string GetName()
        {
            return this.name;
        }

        //Get damage can be overridden by other subclasses.
        //Returns the amount of damage an alien can inflict.
        public virtual int GetDamage()
        {
            return DAMAGE;
        }

        //Build and return a string representation of an monster.
        public override string ToString()
        {
            return String.Format("Type: {0, -25} Name: {1,-10} Health: {2,-10} Damage: {3,-10} ", 
                GetType(), GetName(), GetHealth(), GetDamage());
        }

        //Compares this alien with another alien.
        //Returns true is the names an health are equivalent.
        public override bool Equals(object obj)
        {
            if (null == obj || GetType() != obj.GetType())
            {
                return false;
            }
            Alien other = (Alien)obj;
            return this.name.Equals(other.GetName()) && this.health == other.GetHealth();
        }
    }
}
