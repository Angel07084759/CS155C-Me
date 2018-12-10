/// Chapter No. Week10	Exercise No. Homework10
/// File Name:          AlienPack.cs
/// @author:            Angel Tapia
/// Date:               November 15, 2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    //AlinePack can packs a given number of alien 
    //that represent a band of aliens or monsters.
    class AlienPack
    {
        private Alien[] aliens;//represents a band of alien or monsters.

        //Default constructor that initializes the array of monster 
        //with the given number of aliens.
        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        //Id index is not out of bounds, 
        //the given monster is added at the given index.
        public void AddAlien(Alien newAlien, int index)
        {
            if (index >= 0 || index < aliens.Length)
            {
                aliens[index] = newAlien;
            }
        }

        //Returns a copy of the this pack of aliens.
        public Alien[] GetAliens()
        {
            return aliens;
        }

        //Calculates the total damage that pack of aliens can inflict.
        public int CalculateDamage()
        {
            int damage = 0;

            foreach (Alien a in aliens)
            {
                damage += a.GetDamage();
            }
            return damage;
        }

    }
}
