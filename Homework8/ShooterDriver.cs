/// Homework No. 08 Exercise No. 01
/// File Name:      ShooterDriver.cs
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
    class ShooterDriver
    {
        static void Main(string[] args)
        {
            int aaronWins = 0;
            int bobWins = 0;
            int charlieWins = 0;

            for(int i = 0; i < 5; i++)
            {
                Duelist aaron = new Duelist("Aaron", 0.3333);
                Duelist bob = new Duelist("Bob", 0.5);
                Duelist charlie = new Duelist("Charlie", 0.995);
                int count = 3;  // tracks how many shooters are still alive
                // while there is no winner
                while(count > 1)
                {
                    if (aaron.Alive)
                    {
                        if (charlie.Alive)
                        {
                            aaron.ShootAtTarget(charlie);
                            if (!charlie.Alive)
                            {
                                count--;
                            }
                        }
                        else
                        {
                            aaron.ShootAtTarget(bob);
                            if(!bob.Alive)
                            {
                                count--;
                            }
                        }
                    }
                    if (bob.Alive)
                    {
                        if(charlie.Alive)
                        {
                            bob.ShootAtTarget(charlie);
                            if(!charlie.Alive)
                            {
                                count--;
                            }
                        }
                        else
                        {
                            bob.ShootAtTarget(aaron);
                            if (aaron.Alive)
                            {
                                aaronWins++;
                            }
                        }
                    }
                    if(charlie.Alive)
                    {
                        if(bob.Alive)
                        {
                            charlie.ShootAtTarget(bob);
                            if (!bob.Alive)
                            {
                                count--;
                            }
                            else
                            {
                                charlie.ShootAtTarget(aaron);
                                if (!aaron.Alive)
                                {
                                    count--;
                                }
                            }
                        }
                    }
                    if (aaron.Alive)
                    {
                        aaronWins++;
                    }
                    else if(bob.Alive)
                    {
                        bobWins++;
                    }
                    else
                    {
                        charlieWins++;
                    }
                }
                Console.WriteLine("Aaron won {0} times.", aaronWins);
                Console.WriteLine("Bob won {0} times.", bobWins);
                Console.WriteLine("Charlie won {0} times.", charlieWins);
            }

            Console.ReadKey();
        }
    }
}
