/// Chapter No. Week10	Exercise No. Homework10
/// File Name:          Snake.cs
/// @author:            Angel Tapia
/// Date:               November 15, 2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    //Snake is a subclass of the class Alien
    class Snake : Alien
    {
        //Snake can inflict 10 % of damage to other Aliens.
        private const int DAMAGE = 10;

        //Default constructor set health = 0 and name = "UNKNOWN" by calling the base constructor.
        public Snake() : base(){}

        //Copy constructor that copies the name an health of other Alien, by calling the base constructor.
        //public Snake(Snake alien) : base(alien) { }

        //Full constructor that initializes an alien with the given health and name, by calling the base constructor.
        public Snake(int health, string name) : base(health, name){}

        //Returns the amount of damage an alien can inflict.
        public override int GetDamage()
        {
            return DAMAGE;
        }        
    }
}
