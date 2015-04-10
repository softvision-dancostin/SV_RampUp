using System;

namespace OverloadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Overloaded Operators *****\n");
            // Make two points.
            Point pointOne = new Point(100, 100);
            Point pointTwo = new Point(40, 40);
            Console.WriteLine("ptOne = {0}", pointOne);
            Console.WriteLine("ptTwo = {0}", pointTwo);
            // Add the points to make a bigger point?
            Console.WriteLine("ptOne + ptTwo: {0} ", pointOne + pointTwo);
            // Subtract the points to make a smaller point?
            Console.WriteLine("ptOne - ptTwo: {0} ", pointOne - pointTwo);
            Console.WriteLine("ptOne == ptTwo : {0}", pointOne == pointTwo);
            Console.WriteLine("ptOne != ptTwo : {0}", pointOne != pointTwo);
            Console.ReadLine();
        }
    }
}
