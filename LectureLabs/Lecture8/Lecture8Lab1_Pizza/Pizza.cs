using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab1_Pizza
{
    class Pizza
    {
        private int size;
        private int cheeseToppings;
        private int pepperoniToppings;
        private int hamToppings;

        /**
         * Constructors
         */
         // Default constructor
        public Pizza()
        {
            size = 1;
            cheeseToppings = 1;
            pepperoniToppings = 0;
            hamToppings = 0;
        }
        // Full constructor
        public Pizza(int size, int cheeseToppings, int pepperoniToppings, int hamToppings)
        {
            this.size = size;
            this.cheeseToppings = cheeseToppings;
            this.pepperoniToppings = pepperoniToppings;
            this.hamToppings = hamToppings;
        }

        /**
         * Setter / Mutators
         */
        public void SetSize(int size)
        {
            this.size = size;
        }

        public void SetCheeseToppings(int cheeseToppings)
        {
            this.cheeseToppings = cheeseToppings;
        }

        public void SetPepperoniToppings(int pepperoniToppings)
        {
            this.pepperoniToppings = pepperoniToppings;
        }

        public void SetHamToppings(int hamToppings)
        {
            this.hamToppings = hamToppings;
        }

        /**
         * Getters / Accessors
         */
        public int GetSize()
        {
            return size;
        }

        public int GetCheeseToppings()
        {
            return cheeseToppings;
        }

        public int GetPepperoniToppings()
        {
            return pepperoniToppings;
        }

        public int GetHamToppings()
        {
            return hamToppings;
        }

        /**
         * CalculateCost()
         * small pizza = $10
         * medium pizza = $12
         * large pizza = $14
         * $2 for each topping
         */
        public double CalculateCost()
        {
            double cost = 0;
            if(GetSize() == 1)
            {
                cost = 10.00;
            }
            else if (GetSize() == 2)
            {
                cost = 12.00;
            }
            else if(GetSize() == 3)
            {
                cost = 14.00;
            }
            cost += 2.00 * GetCheeseToppings();
            cost += 2.00 * GetPepperoniToppings();
            cost += 2.00 * GetHamToppings();
            return cost;
        }

        /**
         * ToString()
         * override to display Pizza object variables
         */
        public override string ToString()
        {
            String str = "";
            String size = "";
            if(GetSize() == 1)
            {
                size = "small";
            }
            else if(GetSize() == 2)
            {
                size = "medium";
            }
            else if(GetSize() == 3)
            {
                size = "large";
            }

            str = String.Format("Size: {0}" +
                "\nCheese Toppings: {1}" +
                "\nPepperoni Toppings: {2}" +
                "\nHam Toppings: {3}" +
                "\nTotal Cost: {4:C2}", 
                size, 
                GetCheeseToppings(), 
                GetPepperoniToppings(), 
                GetHamToppings(), 
                CalculateCost());
            return str;
        }
    }
}
