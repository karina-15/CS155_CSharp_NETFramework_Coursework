/// Homework No. 08 Exercise No. 01
/// File Name:      Duelist.cs
/// @author:        Karina Elias
/// Date:           Oct 28, 2019
/// 
/// Problem Statement: Create a class named Duelist that
/// contains the dueler’s name and shooting accuracy, a
/// Boolean indicating whether the dueler is still alive,
/// and a method ShootAtTarget(Duelist target) that sets
/// the target to dead if the dueler hits his target (using
/// a random number and the shooting accuracy) and does
/// nothing otherwise.  Use properties for your Duelist class.
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// Main class - ShooterDriver.cs
/// Duelist class - Temperature.cs

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Duelist
    {
        /**
         * Properties - Instance variables and Getters/Setters
         */
        private String _name;
        private double _accuracy;
        private bool _alive;
        private Random rand;
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Accuracy
        {
            get { return _accuracy; }
            set { _accuracy = value; }
        }
        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }

        /** constructor */
        public Duelist(String _name, double _accuracy)
        {
            Name = _name;
            Accuracy = _accuracy;
            Alive = true;
            rand = new Random((int)(_accuracy * DateTime.Now.Ticks));
        }

        /** ShootAtTarget method */
        public void ShootAtTarget(Duelist duel)
        {
            if(rand.NextDouble() < Accuracy)
            {
                duel.Alive = false;
            }
        }
    }
}
