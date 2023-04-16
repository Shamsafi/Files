using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{     //C# program to find sum of array elements
    internal class Sum_Array
    {
        static void Main(string[] args)
        {

            /* Input array size */
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int sum = 0;

            /* Input elements in array */
            Console.WriteLine("Enter elements in the array", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*Add each array element to sum*/
            for (int i = 0; i < size; i++)
            {
                sum = sum + arr[i];
            }


            Console.Write("Sum of all elements of array = {0}", sum);
            Console.ReadLine();
        }
    }
}
