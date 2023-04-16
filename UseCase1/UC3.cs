using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the two lines
        Line line1 = new Line(new Point(0, 0), new Point(8, 8));
        Line line2 = new Line(new Point(0, 0), new Point(7, 7));

        // Compare the lines using the CompareTo method
        int result = line1.CompareTo(line2);

        // Output the comparison result
        if (result == 0)
        {
            Console.WriteLine("Line 1 is equal to Line 2.");
        }
        else if (result < 0)
        {
            Console.WriteLine("Line 1 is less than Line 2.");
        }
        else if (result > 0)
        {
            Console.WriteLine("Line 1 is greater than Line 2.");
        }

        Console.ReadLine();
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Line : IComparable<Line>
{
    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public int CompareTo(Line other)
    {
        // Get the lengths of both lines
        double length1 = Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
        double length2 = Math.Sqrt(Math.Pow(other.End.X - other.Start.X, 2) + Math.Pow(other.End.Y - other.Start.Y, 2));

        // Compare the lengths using the CompareTo method
        return length1.CompareTo(length2);
    }
}
