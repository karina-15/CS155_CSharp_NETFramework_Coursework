using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab2
{
    class Lecture9Lab2
    {
        static void Main(string[] args)
        {
            // CashPayment 1
            Console.WriteLine("Enter the amount paid:");
            CashPayment cash1 = new CashPayment(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(cash1.PaymentDetails());
            // CashPayment 2
            Console.WriteLine("Enter the amount paid:");
            CashPayment cash2 = new CashPayment(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(cash2.PaymentDetails());
            // CreditCardPayment 1
            Console.WriteLine("Enter charge amount:");
            double charge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter card name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter card number:");
            String cardNum = Console.ReadLine();
            CreditCardPayment card1 = new CreditCardPayment(charge, name, cardNum);
            Console.WriteLine(card1.PaymentDetails());
            // CreditCardPayment 2
            Console.WriteLine("Enter charge amount:");
            charge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter card name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter card number:");
            cardNum = Console.ReadLine();
            CreditCardPayment card2 = new CreditCardPayment(charge, name, cardNum);
            Console.WriteLine(card2.PaymentDetails());

            Console.ReadKey();  // prevents window from closing
        }
    }
}
