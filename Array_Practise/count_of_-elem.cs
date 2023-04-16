using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{           //program to count negative elements in array
    internal class count_of__elem
    {
        static void Main(string[] args)
        {


            /* Input array size */
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int count = 0;

            /* Input elements in array */
            Console.WriteLine("Enter {0} elements in the array", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*Count total negative elements in array*/
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                }
            }

            Console.Write("\nTotal negative elements in array = {0}", count);
            Console.ReadLine();
        }
    }
}
