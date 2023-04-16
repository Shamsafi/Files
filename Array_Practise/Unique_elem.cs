using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{
    internal class Unique_elem
    {    // program to print all unique elements in array
        static void Main(string[] args)
        {
            int size, i, j, count;
            bool unique;

            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter {0} elements in the array", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nUnique elements in the array are: ");
            for (i = 0; i < size; i++)
            {
                unique = true;
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique == true)
                {
                    Console.Write("{0} \t ", arr[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
