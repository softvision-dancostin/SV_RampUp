using System;
using CarLibrary;

namespace CarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Car Client *****");
            // Make a sports car.
            SportsCar sport = new SportsCar("Viper", 240, 40);
            sport.TurboBoost();
            // Make a minivan.
            MiniVan mini = new MiniVan();
            mini.TurboBoost();

            Console.WriteLine("Done. Press any key to terminate");
            Console.ReadLine();
        }
    }
}
