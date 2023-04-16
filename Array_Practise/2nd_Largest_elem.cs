using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{           //program to find second largest number in array
    internal class _2nd_Largest_elem
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int max1, max2;

            Console.WriteLine("Enter {0} elements in the array", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max1 = max2 = arr[0];

            for (int i = 0; i < size; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2 && arr[i] < max1)
                {
                    max2 = arr[i];
                }
            }

            Console.Write("First largest = {0}\n", max1);
            Console.Write("Second largest = {0}", max2);
            Console.ReadLine();
        }
    }
}
