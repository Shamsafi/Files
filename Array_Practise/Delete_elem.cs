using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{           //program to delete element from an array
    internal class Delete_elem
    {
        static void Main(string[] args)
        {
            int i, size, pos;
            Console.Write("Enter size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];



            Console.WriteLine("Enter {0} elements in the array", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Enter the element position to delete : ");
            pos = Convert.ToInt32(Console.ReadLine());



            if (pos < 0 || pos > size)
            {
                Console.Write("Invalid position! Please enter position between 1 to {0}", size);
            }
            else
            {
                for (i = pos - 1; i < size - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                size--;
            }

            Console.Write("\nElements of array after delete are \n ");
            for (i = 0; i < size; i++)
            {
                Console.Write("{0}\t", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
