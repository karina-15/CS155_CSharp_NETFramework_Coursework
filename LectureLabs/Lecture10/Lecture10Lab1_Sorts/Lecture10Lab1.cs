using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Lab1_Sorts
{
    class Lecture10Lab1
    {
        static void Main(string[] args)
        {
            SelectionSort();
            Console.WriteLine();
            BubbleSort();
            
            Console.ReadKey();  // prevents window from closing
        }

        public static string ToString(int[] array)
        {
            string arrStr = null;
            foreach (int element in array)
            {
                arrStr += element + " ";
            }
            return arrStr;
        }

        /** Selection Sort
         * using algorithm in Lecture10 slide 72
         */
        public static void SelectionSort()
        {
            int[] arrSelection = new int[] { 70, 55, 25, 80, 78 };
            Console.WriteLine("Array before selection sort: " + ToString(arrSelection));
            int n = arrSelection.Length;
            for (int fill = 0; fill <= n - 2; fill++)
            {
                int posMin = fill;
                for (int next = fill + 1; next <= n - 1; next++)
                {
                    if (arrSelection[next] < arrSelection[posMin])
                    {
                        posMin = next;
                    }
                }
                int temp = arrSelection[posMin];
                arrSelection[posMin] = arrSelection[fill];
                arrSelection[fill] = temp;
            }
            Console.WriteLine("Array after selection sort:  " + ToString(arrSelection));
        }

        /** Bubble Sort
         * using algorithm in Lecture10 slide 97
         */
        public static void BubbleSort()
        {
            int[] arrBubble = new int[] { 88, 10, 45, 47, 99 };
            bool outOfOrder = true;
            Console.WriteLine("Array before bubble sort: " + ToString(arrBubble));
            do
            {
                outOfOrder = false;
                // use arrBubble.Length - 1 to avoid index error
                // b/c if statement accesses arrBubble[i + 1]
                for (int i = 0; i < arrBubble.Length - 1; i++)
                {
                    if (arrBubble[i] > arrBubble[i + 1])
                    {
                        outOfOrder = true;
                        int temp = arrBubble[i];
                        arrBubble[i] = arrBubble[i + 1];
                        arrBubble[i + 1] = temp;
                    }
                }
            } while (outOfOrder);
            Console.WriteLine("Array after bubble sort:  " + ToString(arrBubble));
        }
    }
}
