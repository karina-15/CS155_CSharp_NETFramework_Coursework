using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab2
{
    class CashPayment : Payment
    {
        /** CashPayment
         * derived from Payment
         * redefine PaymentDetails method to indicate that
         * the payment is in cash
         */
         public CashPayment(double cash) : base(cash)
        {
        }

        public override string PaymentDetails()
        {
            return "Cash " + base.PaymentDetails();
        }
    }
}
