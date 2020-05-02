using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int choice = -1;
            Console.WriteLine("To start ordering");

            do
            {
                Console.WriteLine("Choose from below" +
                "\n1. Pick an entree" +
                "\n2. Pick a side" +
                "\n3. Pick a drink" +
                "\n4. Pick a dessert" +
                "\n0. Finish ordering");
                Console.Write(">");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    menu.EntreePick();
                    Console.WriteLine(menu.ToString());
                }
                else if (choice == 2)
                {
                    menu.SidePick();
                    Console.WriteLine(menu.ToString());
                }
                else if (choice == 3)
                {
                    menu.DrinkPick();
                    Console.WriteLine(menu.ToString());
                }
                else if (choice == 4)
                {
                    menu.DessertPick();
                    Console.WriteLine(menu.ToString());
                }
                else if (choice == 0)
                {
                    break;
                }
                else
                {
                    try
                    {
                        throw new Exception("Message");
                    }
                    catch (Exception e) when (e.Message == "Message")
                    {
                        Console.WriteLine("Invalid menu choice. Try again.");
                    }
                }

            } while (choice != 0);
        }
    }
}
