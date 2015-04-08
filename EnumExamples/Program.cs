using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExamples
{
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }

    class Program
    {
        static void Main(string[] args)
        {
            CallAskForBonus();
            CallEvaluateEnum();
        }

        static void CallAskForBonus()
        {
            Console.WriteLine("**** Fun with Enums *****");
            // Make a contractor type.
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.ReadLine();
        }

        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }

        static void CallEvaluateEnum()
        {
            Console.WriteLine("**** Fun with Enums *****");
            // Make a contractor type.
            EmpType emp = EmpType.Contractor;
            EvaluateEnum(emp);
            Console.ReadLine();
        }

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",
            Enum.GetUnderlyingType(e.GetType()));
            // Get all name/value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Now show the string name and associated value, using the D format
            // flag (see Chapter 3).
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",
                enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}
