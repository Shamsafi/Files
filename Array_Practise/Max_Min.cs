using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{          //program to find maximum and minimum element in array
    internal class Max_Min
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int max, min;
            Console.WriteLine("Enter {0} elements in the array", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = arr[0];
            min = arr[0];

            for (int i = 1; i < size; i++)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                }
                if (arr[i] <= min)
                {
                    min = arr[i];
                }
            }

            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}", min);
            Console.ReadLine();
        }
    }
}
