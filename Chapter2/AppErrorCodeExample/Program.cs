using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static int Main(string[] args)
        {
            //Display a message and wait for Enter key to be pressed.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            foreach (string arg in args)
                Console.WriteLine("Arg: {0}", arg);
            Console.WriteLine();

            ShowEnvironmentDetails();
            Console.WriteLine();

            //GetUserData();
            //Console.WriteLine();

            FormatNumericalData();
            Console.WriteLine();

            LocalVarDeclarations();
            Console.WriteLine();

            Console.ReadLine();
            return -1;
        }

    }
}
