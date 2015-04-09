using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            InstantiateCar();
            InstantiateMotorcycle();
        }
        static void InstantiateCar()
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            Car chuck = new Car();
            chuck.PrintState();
            Car mary = new Car("Mary");
            mary.PrintState();
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            Console.ReadLine();
        }

        static void InstantiateMotorcycle()
        {
            Console.WriteLine("***** Fun with class Types *****\n");
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.driverName);

            Console.ReadLine();
        }
    }
}
