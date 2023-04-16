using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace UseCase1
{
    internal class UC1
    {
        static void Main(string[] args)
        {
            double x1 = 1;
            double y1 = 5;
            double x2 = 4;
            double y2 = 6;

            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"The length of the line is {length}");

        }
    }
}