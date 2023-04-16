using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProblms
{
    internal class UC4
    {

        static void Main(string[] args)
        {
            // Define the two lines
            Line line1 = new Line(new Point(0, 0), new Point(9, 9));
            Line line2 = new Line(new Point(0, 0), new Point(3, 3));
            Line line3 = new Line(new Point(0, 0), new Point(7, 7));

            // Check if the lines are equal using the Equals method
            if (line1.Equals(line2))
            {
                Console.WriteLine("Line 1 is equal to Line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is not equal to Line 2.");
            }

            // Compare the lines using the CompareTo method
            int result = line1.CompareTo(line3);

            if (result < 0)
            {
                Console.WriteLine("Line 1 is less than Line 3.");
            }
            else if (result > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 3.");
            }
            else
            {
                Console.WriteLine("Line 1 is equal to Line 3.");
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

        public bool Equals(Line other)
        {
            if (other == null)
            {
                return false;
            }

            return (Start.Equals(other.Start) && End.Equals(other.End)) ||
                   (Start.Equals(other.End) && End.Equals(other.Start));
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Line))
            {
                return false;
            }

            Line other = (Line)obj;

            return Equals(other);
        }

        public override int GetHashCode()
        {
            return Start.GetHashCode() ^ End.GetHashCode();
        }

        public int CompareTo(Line other)
        {
            if (other == null)
            {
                return 1;
            }

            double length1 = Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
            double length2 = Math.Sqrt(Math.Pow(other.End.X - other.Start.X, 2) + Math.Pow(other.End.Y - other.Start.Y, 2));

            return length1.CompareTo(length2);
        }
    }
}

