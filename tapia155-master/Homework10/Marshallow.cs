/// Chapter No. Week10	Exercise No. Homework10
/// File Name:          Marshallow.cs
/// @author:            Angel Tapia
/// Date:               November 15, 2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    //Marshallow is a subclass of the class Alien
    class Marshallow : Alien
    {
        //Marshallow can inflict 1 % of damage to other Aliens.
        private const int DAMAGE = 1;

        //Default constructor set health = 0 and name = "UNKNOWN" by calling the base constructor.
        public Marshallow() : base(){}

        //Copy constructor that copies the name an health of other Alien, by calling the base constructor.
        //public Marshallow(Marshallow alien) : base(alien) { }

        //Full constructor that initializes an alien with the given health and name, by calling the base constructor.
        public Marshallow(int health, string name) : base(health, name){}

        //Returns the amount of damage an alien can inflict.
        public override int GetDamage()
        {
            return DAMAGE;
        }
    }
}
