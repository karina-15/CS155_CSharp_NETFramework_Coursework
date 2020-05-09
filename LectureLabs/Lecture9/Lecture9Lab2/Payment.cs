using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab2
{
    class Payment
    {
        public double Amount
        {
            get; set;
        }

        public Payment() : this(0)
        {
        }

        public Payment(double amount)
        {
            Amount = amount;
        }


        /** PaymentDetails
         * outputs String sentence to describe the amount
         * of the payment
         */
         public virtual String PaymentDetails()
        {
            return String.Format("amount paid: {0:C}\n", Amount);
        }       
    }
}
