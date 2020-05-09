/// Homework No. 10 Exercise No. 01
/// File Name:      Alien.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    // parent class
    class Alien
    {
        // enum to display alien type string instead of int
        public enum AlienType { Snake, Ogre, MarshmallowMan };

        // damage as constant to prevent tampering
        private const int DAMAGE = 0;

        // data fields
        private int _type;
        private int _health;
        private string _name;

        // properties
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        // set health to number between 0-100
        public int Health   //0 = dead, 100 = full
        {
            get { return _health; }
            set {
                if (value < 0)
                {
                    value = 1;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                _health = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // default constructor
        public Alien()
        {
            Type = 0;
            Health = 100;
            Name = "Alien";
        }

        // full constructor using this for child classes to inherit
        public Alien(int type, int health, string name) : this()
        {
            Type = type;
            Health = health;
            Name = name;
        }

        // use virtual for child classes to override/inherit
        public virtual int GetDamage()
        {
            return DAMAGE;
        }

        // ToString method prints Alien information
        public override string ToString()
        {
            return String.Format("Type: {0}\nHealth: {1}\nName: {2}\nDamage: {3}\n",
                Enum.GetName(typeof(AlienType), Type), Health, Name, GetDamage());
        }

        // Equals method
        public override bool Equals(object obj)
        {
            var alien = obj as Alien;
            // return true if type, health, and name are equal,
            // otherwise false
            return alien != null &&
                Type == alien.Type &&
                Health == alien.Health &&
                Name == alien.Name;
        }
    }
}
