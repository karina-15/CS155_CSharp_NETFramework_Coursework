using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{

    class Alien
    {
        public const int SNAKE_ALIEN = 0;
        public const int OGRE_ALIEN = 1;
        public const int MARSHALLOW_MAN_ALIEN = 2;

        public int type;
        public int health; //0 = dead, 100 = full
        public string name;

        public Alien(int type, int health, string name )
        {
            this.type = type;
            this.health = health;
            this.name = name;
        }
    }

    class AlienPack
    {
        private Alien[] aliens;

        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }
        public Alien[] GetAliens()
        {
            return aliens;
        }
        public int CalculateDamage()
        {
            int damage = 0;

            foreach(Alien a in aliens)
            {
                if(a.type == Alien.SNAKE_ALIEN)
                {
                    damage += 10;
                }
                else if (a.type == Alien.OGRE_ALIEN)
                {
                    damage += 6;
                }
                else if (a.type == Alien.MARSHALLOW_MAN_ALIEN)
                {
                    damage += 1;
                }
            }
            return damage;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
