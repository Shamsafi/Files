namespace Array_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            /* Input elements in array */
            Console.WriteLine("Enter {0} elements in the array", size);
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*Print all negative elements of array*/
            Console.Write("\nAll negative elements in array are : ");
            for (int i = 0; i < size; i++)
            {
                /* If current array element is negative */
                if (arr[i] < 0)
                {
                    Console.Write("{0}\t", arr[i]);
                }
            }
            Console.ReadLine();
        }
    }

}