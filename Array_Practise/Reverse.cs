using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{
    internal class Reverse
    {
        public static void Main(string[] args)
        {
            int[] num = { 22, 50, 11, 2, 49 };
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
