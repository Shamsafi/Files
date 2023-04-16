using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{      //program to insert an element in array
    internal class Insert_elem
    {
        static void Main(string[] args)
        {
            int i, size, num, pos;
            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int[] arr2;
            Console.WriteLine("Enter {0} elements in the array", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Enter element to insert : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the element position  1 to {0}:", size);
            pos = Convert.ToInt32(Console.ReadLine());

            if (pos > size + 1 || pos <= 0)
            {
                Console.Write("Invalid position! Please enter position between 1 to {0}", size);
            }
            else
            {
                arr2 = new int[size + 1];
                for (i = size; i >= pos; i--)
                {
                    arr2[i] = arr[i - 1];
                }
                arr2[pos - 1] = num;
                size++;

                for (i = 0; i < pos - 1; i++)
                {
                    arr2[i] = arr[i];
                }
                Console.Write("Array elements after insertion : ");
                for (i = 0; i < size; i++)
                {
                    Console.Write("{0}\t", arr2[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
