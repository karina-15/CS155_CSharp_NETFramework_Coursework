/// Homework No. 10 Exercise No. 01
/// File Name:      OgreAlien.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    // inherits from Alien class
    class OgreAlien : Alien
    {
        // damage as constant to prevent tampering
        private const int DAMAGE = 6;

        // default construtor inherits from Alien class
        public OgreAlien() : base()
        {

        }

        // full constructor inherits from Alien class
        public OgreAlien(int type, int health, string name) : base(type, health, name)
        {

        }

        // overrides GetDamge method in Alien class
        public override int GetDamage()
        {
            return DAMAGE;
        }

        // uses ToString in Alien class
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
