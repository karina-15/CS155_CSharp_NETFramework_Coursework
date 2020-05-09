using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab2
{
    class CreditCardPayment : Payment
    {
        // instance variables
        public String CardName
        {
            get; set;
        }
        public String CardNumber
        {
            get; set;
        }

        public CreditCardPayment(double charge, String cardName, String cardNumber) : base(charge)
        {
            CardName = cardName;
            CardNumber = cardNumber;
        }

        public override string PaymentDetails()
        {
            return String.Format("Card name: {0}" +
                "\nCard number: {1}" +
                "\nCharge ", CardName, CardNumber)
                + base.PaymentDetails();
        }
    }
}
