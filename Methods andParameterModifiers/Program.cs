using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_andParameterModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            CallSimpleAdd();
            CallAddWithOut();
            CallFillTheseValues();
            CallSwapStrings();
            CallCalculateAverage();
        }

        static void CallSimpleAdd()
        {
            Console.WriteLine("***** Fun with Methods *****");
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            int ans = x + y;
            // Caller will not see these changes
            // as you are modifying a copy of the
            // original data.
            x = 10000;
            y = 88888;
            return ans;
        }

        static void CallAddWithOut()
        {
            Console.WriteLine("***** Fun with Methods *****");
            // No need to assign initial value to local variables
            // used as output parameters, provided the first time
            // you use them is as output arguments.
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0}", ans);
            Console.ReadLine();
        }

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        static void CallFillTheseValues()
        {
            Console.WriteLine("***** Fun with Methods *****");
            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);
            Console.ReadLine();
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        static void CallSwapStrings()
        {
            Console.WriteLine("***** Fun with Methods *****");
            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1} ", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1} ", str1, str2);
            Console.ReadLine();
        }

        static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        static void CallCalculateAverage()
        {
            Console.WriteLine("***** Fun with Methods *****");
            // Pass in a comma-delimited list of doubles...
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);
            // ...or pass an array of doubles.
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);
            // Average of 0 is 0!
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            Console.ReadLine();
        }

        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }
    }
}
