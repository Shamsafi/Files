using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{
    internal class Sorting
    {     //In Desending order
        public static void Main(string[] args)
        {
            int[] num = { 25, 84, 5, 917, 47, 02, 2589 };
            Array.Sort(num);
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
