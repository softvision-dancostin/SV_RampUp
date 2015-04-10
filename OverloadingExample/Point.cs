using System;

namespace OverloadingExample
{
    public class Point : IComparable<Point>
    {
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public int X { get; set; }
        public int Y { get; set; }

        // Overloaded operator +.
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        // Overloaded operator -.
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }
        // Add 1 to the X/Y values for the incoming Point.
        public static Point operator ++(Point p1)
        {
            return new Point(p1.X + 1, p1.Y + 1);
        }
        // Subtract 1 from the X/Y values for the incoming Point.
        public static Point operator --(Point p1)
        {
            return new Point(p1.X - 1, p1.Y - 1);
        }
        public override bool Equals(object o)
        {
            return o.ToString() == this.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        // Now let's overload the == and != operators.
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
                return 1;
            if (this.X < other.X && this.Y < other.Y)
                return -1;
            else
                return 0;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) < 0);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) > 0);
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) <= 0);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) >= 0);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.X, this.Y);
        }
    }
}
