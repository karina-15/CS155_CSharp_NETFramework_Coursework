/// Homework No. 10 Exercise No. 01
/// File Name:      MarshmallowManAlien.cs
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
    class MarshmallowManAlien : Alien
    {
        // damage as constant to prevent tampering
        private const int DAMAGE = 1;

        // default construtor inherits from Alien class
        public MarshmallowManAlien() : base()
        {

        }

        // full constructor inherits from Alien class
        public MarshmallowManAlien(int type, int health, string name) : base(type, health, name)
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
