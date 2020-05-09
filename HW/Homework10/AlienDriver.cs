/// Homework No. 10 Exercise No. 01
/// File Name:      AlienDriver.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
/// 
/// Problem Statement: In the attached file you will find some
/// video game code by J. Hacker. There is an Alien class to
/// represent a monster and an AlienPack class that represents
/// a band of aliens and how much damage they can inflict. The
/// code is not very object oriented and does not support information
/// hiding in the Alien class. Split the code into multiple
/// files. Rewrite the code so that inheritance is used to represent
/// the different types of aliens instead of the “type” parameter.
/// This should result in deletion of the “type” parameter.
/// Also rewrite the Alien class to hide the instance variables
/// and create a GetDamage method for each derived class that
/// returns the amount of damage the alien inflicts. Finally,
/// rewrite the CalculateDamage method to use GetDamage and
/// write a Main method that tests the code.
/// 
/// 
/// Overall Plan
/// 1. Separate Alien and AlienPack into separate classes
/// 2. Write SnakeAlien, OgreAlien, and MarshmallowManAlien
///     classes that inherit from parent Alien class
/// 3. Write properties for Alien class
///     type, health, name
/// 4. Add enum for alien type and GetDamage method to Alien
///     class
/// 5. Override ToString
/// 6. Override GetDamage method in child classes
/// 7. Create Driver using AlienPack for list of aliens
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class          - AlienDriver.cs
/// list of Alien class - AlienPack.cs
/// parent class        - Alien.cs
/// child class         - SnakeAlien.cs
/// child class         - OgreAlien.cs
/// child class         - MarshmallowManAlien.cs

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class AlienDriver
    {
        static void Main(string[] args)
        {
            // create list of aliens
            int numAliens = 5;
            AlienPack aliens = new AlienPack(numAliens);

            // add aliens to list
            aliens.AddAlien(new SnakeAlien(0, 80, "Cobra"), 0);
            aliens.AddAlien(new OgreAlien(1, 100, "Green Guy"), 1);
            aliens.AddAlien(new MarshmallowManAlien(2, 100, "Fluffy"), 2);
            aliens.AddAlien(new SnakeAlien(0, 150, "Python"), 3);
            aliens.AddAlien(new MarshmallowManAlien(2, -1, "Blue"), 4);

            // display each alien's info
            foreach(Alien alien in aliens.GetAliens())
            {
                Console.WriteLine(alien);
            }
            // display total damage of alien pack
            Console.WriteLine(String.Format("Total Damage: {0}",
                aliens.CalculateDamage()));

            Console.ReadLine(); // prevents window from closing
        }
    }
}
