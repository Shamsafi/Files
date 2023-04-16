using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practise
{
    internal class Majority
    {
        public class MajorityUnsortedArray
        {
            public static int GetMajorityElement(params int[] x)
            {
                Dictionary<int, int> d = new Dictionary<int, int>();
                int majority = x.Length / 2;

                //Stores the number of occcurences of each item in the passed array in a dictionary
                foreach (int i in x)
                    if (d.ContainsKey(i))
                    {
                        d[i]++;
                        //Checks if element just added is the majority element
                        if (d[i] > majority)
                            return i;
                    }
                    else
                        d.Add(i, 1);
                //No majority element
                throw new Exception("No majority element in array");
            }
        }
    }
}
