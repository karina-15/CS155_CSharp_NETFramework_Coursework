/// Homework No. 10 Exercise No. 01
/// File Name:      AlienPack.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    // creates list of different Alien objects
    class AlienPack
    {
        // data fields
        private Alien[] aliens;

        // full constructor
        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        // adds Alien to list
        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }

        // getter for alien list
        public Alien[] GetAliens()
        {
            return aliens;
        }

        // calculates total damage in list
        public int CalculateDamage()
        {
            int damage = 0;

            // adds up damage of each alien in list
            foreach (Alien a in aliens)
            {
                damage += a.GetDamage();
            }
            return damage;
        }
    }
}
