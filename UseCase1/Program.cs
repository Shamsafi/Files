namespace UseCase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                // Define the two points that define the line
                double x1 = 1;
                double y1 = 2;
                double x2 = 4;
                double y2 = 6;

                // Calculate the length of the line
                double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                Console.WriteLine($"The length of the line is {length}");
            
        }
    }
}