using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Menu
    {
        // Instance variables
        private String name;
        private double price;
        private int quantity;
        private double totalPricePerItem;
        private double total;

        /**
         * Constructors
         */
        public Menu()
        {

        }
        public Menu(String name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public String GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public double GetTotalPricePerItem()
        {
            totalPricePerItem = quantity * price;
            return totalPricePerItem;
        }

        public double GetTotal()
        {
            total += totalPricePerItem;
            return total;
        }

        public Menu EntreePick()
        {
            Console.Clear();
            int choice = -1;
            Console.WriteLine("Pick an entree");
            do
            {
                Console.WriteLine("1. Hamburger" +
                    "\n2. Chicken" +
                    "\n3. Roast beef" +
                    "\n4. Pizza" +
                    "\n5. Lasagna" +
                    "\n6. Tacos" +
                    "\n0. Return to main menu");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    name = "Hamburger";
                    price = 5.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 2)
                {
                    name = "Chicken";
                    price = 6.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 3)
                {
                    name = "Roast beef";
                    price = 8.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 4)
                {
                    name = "Pizza";
                    price = 10.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 5)
                {
                    name = "Lasagna";
                    price = 8.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 6)
                {
                    name = "Tacos";
                    price = 5.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 0)
                {
                    return null;
                }
                else
                {
                    try
                    {
                        throw new Exception("Message");
                    }
                    catch (Exception e) when (e.Message == "Message")
                    {
                        Console.WriteLine("Invalid entree choice. Try again.");
                        return null;
                    }
                }
            } while (choice != 0);
        }

        public Menu SidePick()
        {
            Console.Clear();
            int choice = -1;
            Console.WriteLine("Pick a side");
            do
            {
                Console.WriteLine("1. Fries" +
                    "\n2. Green beans" +
                    "\n3. Spanish rice" +
                    "\n4. Mashed potatoes" +
                    "\n5. Soup" +
                    "\n6. Bread sticks" +
                    "\n0. Return to main menu");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    name = "Fries";
                    price = 2.50;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 2)
                {
                    name = "Green beans";
                    price = 1.90;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 3)
                {
                    name = "Spanish rice";
                    price = 1.50;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 4)
                {
                    name = "Mashed potatoes";
                    price = 3.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 5)
                {
                    name = "Soup";
                    price = 2.75;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 6)
                {
                    name = "Bread sticks";
                    price = 3.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 0)
                {
                    return null;
                }
                else
                {
                    try
                    {
                        throw new Exception("Message");
                    }
                    catch (Exception e) when (e.Message == "Message")
                    {
                        Console.WriteLine("Invalid side choice. Try again.");
                        return null;
                    }
                }
            } while (choice != 0);
        }

        public Menu DrinkPick()
        {
            Console.Clear();
            int choice = -1;
            Console.WriteLine("Pick a drink");
            do
            {
                Console.WriteLine("1. Coca Cola" +
                    "\n2. Sprite" +
                    "\n3. Lemonade" +
                    "\n4. Beer" +
                    "\n5. Red wine" +
                    "\n6. Water" +
                    "\n0. Return to main menu");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    name = "Coca Cola";
                    price = 1.50;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 2)
                {
                    name = "Sprite";
                    price = 1.50;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 3)
                {
                    name = "Lemonade";
                    price = 2.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 4)
                {
                    name = "Beer";
                    price = 5.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 5)
                {
                    name = "Red wine";
                    price = 5.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 6)
                {
                    name = "Water";
                    price = 0.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 0)
                {
                    return null;
                }
                else
                {
                    try
                    {
                        throw new Exception("Message");
                    }
                    catch (Exception e) when (e.Message == "Message")
                    {
                        Console.WriteLine("Invalid drink choice. Try again.");
                        return null;
                    }
                }
            } while (choice != 0);
        }

        public Menu DessertPick()
        {
            Console.Clear();
            int choice = -1;
            Console.WriteLine("Pick a dessert");
            do
            {
                Console.WriteLine("1. Pie a la mode" +
                    "\n2. Chocolate lava cake" +
                    "\n3. Cheesecake" +
                    "\n4. Sundae" +
                    "\n5. Banana split" +
                    "\n6. Brownie" +
                    "\n0. Return to main menu");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    name = "Pia a la mode";
                    price = 4.50;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 2)
                {
                    name = "Cocolate lava cake";
                    price = 5.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 3)
                {
                    name = "Cheesecake";
                    price = 3.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 4)
                {
                    name = "Sundae";
                    price = 2.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 5)
                {
                    name = "Banana split";
                    price = 6.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 6)
                {
                    name = "Brownie";
                    price = 1.00;
                    Console.WriteLine("How many would you like?");
                    quantity = Int32.Parse(Console.ReadLine());
                    return new Menu(name, price, quantity);
                }
                else if (choice == 0)
                {
                    return null;
                }
                else
                {
                    try
                    {
                        throw new Exception("Message");
                    }
                    catch (Exception e) when (e.Message == "Message")
                    {
                        Console.WriteLine("Invalid dessert choice. Try again.");
                        return null;
                    }
                }
            } while (choice != 0);
        }

        public override string ToString()
        {
            Console.Clear();
            return String.Format("Item: {0, -17}" +
                "Price:{1, -7:C2}" +
                "Quantity:{2, -5}" +
                "Total for item:{3, 0:C2}" +
                "\nTotal:{4, 0:C2}",
                GetName(), GetPrice(), GetQuantity(), GetTotalPricePerItem(), GetTotal());
        }
    }
}
