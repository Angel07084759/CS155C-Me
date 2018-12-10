/// Chapter No. Week10	Exercise No. Homework10
/// File Name:          Ogre.cs
/// @author:            Angel Tapia
/// Date:               November 15, 2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    //Ogre is a subclass of the class Alien
    class Ogre : Alien
    {
        //Ogre can inflict 6 % of damage to other Aliens.
        private const int DAMAGE = 6;

        //Default constructor set health = 0 and name = "UNKNOWN" by calling the base constructor.
        public Ogre() : base(){}

        //Copy constructor that copies the name an health of other Alien, by calling the base constructor.
        //public Ogre(Ogre alien) : base(alien) { }

        //Full constructor that initializes an alien with the given health and name, by calling the base constructor.
        public Ogre(int health, string name) : base(health, name){}

        //Returns the amount of damage an alien can inflict.
        public override int GetDamage()
        {
            return DAMAGE;
        }
    }
}
