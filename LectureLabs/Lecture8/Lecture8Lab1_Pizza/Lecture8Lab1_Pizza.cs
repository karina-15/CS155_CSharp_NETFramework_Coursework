using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab1_Pizza
{
    class Lecture8Lab1_Pizza
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza();
            try
            {
                Console.WriteLine("Choose a size:" +
                    "\n1. Small" +
                    "\n2. Medium" +
                    "\n3. Large");
                int size = Int32.Parse(Console.ReadLine());
                pizza1.SetSize(size);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid choice.");
            }
            try
            {
                Console.WriteLine("How many cheese toppings?:");
                int cheeseToppings = Int32.Parse(Console.ReadLine());
                pizza1.SetCheeseToppings(cheeseToppings);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
            try
            {
                Console.WriteLine("How many pepperoni toppings?:");
                int pepperoniToppings = Int32.Parse(Console.ReadLine());
                pizza1.SetPepperoniToppings(pepperoniToppings);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
            try
            {
                Console.WriteLine("How many ham toppings?:");
                int hamToppings = Int32.Parse(Console.ReadLine());
                pizza1.SetHamToppings(hamToppings);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine(pizza1.ToString());

            Console.ReadKey();  // prevents window from closing
        }
    }
}
