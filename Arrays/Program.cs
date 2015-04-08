using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            CallSimpleArrays();
            CallDeclareImplicitArrays();
            CallPassAndReceiveArrays();
        }
        
        static void CallSimpleArrays()
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create and fill an array of 3 Integers
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            // Now print each value.
            foreach (int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();
        }

        static void CallDeclareImplicitArrays()
        {
            Console.WriteLine("***** Fun with Arrays *****");
            DeclareImplicitArrays();
            Console.ReadLine();
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");
            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());
            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());
            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }

        static void CallPassAndReceiveArrays()
        {
            Console.WriteLine("***** Fun with Arrays *****");
            PassAndReceiveArrays();
            Console.ReadLine();
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            // Pass array as parameter.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);
            // Get array as return value.
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }
    }
}
