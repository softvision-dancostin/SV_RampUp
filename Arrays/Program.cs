using System;

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
            var intArray = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("intArray is a: {0}", intArray.ToString());
            // b is really double[].
            var doubleArray = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("doubleArray is a: {0}", doubleArray.ToString());
            // c is really string[].
            var stringArray = new[] { "hello", null, "world" };
            Console.WriteLine("stringArray is a: {0}", stringArray.ToString());
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
