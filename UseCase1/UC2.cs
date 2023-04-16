using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LineProblms
{
    internal class UC2
    {
        static void Main(string[] args)
        {
            // Define the two lines
            Line line1 = new Line(new Point(0, 0), new Point(5, 5));
            Line line2 = new Line(new Point(0, 0), new Point(7, 5));

            // Check if the lines are equal using the Equals method
            if (line1.Equals(line2))
            {
                Console.WriteLine("Line 1 is equal to Line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is not equal to Line 2.");
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

    class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Line))
            {
                return false;
            }

            Line other = (Line)obj;

            return (Start.Equals(other.Start) && End.Equals(other.End)) ||
                   (Start.Equals(other.End) && End.Equals(other.Start));
        }

        public override int GetHashCode()
        {
            return Start.GetHashCode() ^ End.GetHashCode();
        }
    }

}

