using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over Generic Collections *****\n");
            // Make a List<> of Car objects.
            List<Car> myCars = new List<Car>() {
                new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
                };

            GetFastCars(myCars);
            Console.WriteLine();

            GetFastBMWs(myCars);
            Console.WriteLine();

            DisplayDiff();
            Console.WriteLine();

            DisplayIntersection();
            Console.WriteLine();

            DisplayUnion();
            Console.WriteLine();

            DisplayConcat();
            Console.WriteLine();

            DisplayConcatNoDups();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void GetFastCars(List<Car> myCars)
        {
            Console.WriteLine("Get Fast Cars");
            // Find all Car objects in the List<>, where the Speed is
            // greater than 55.
            var fastCars = from c in myCars where c.Speed > 55 select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }

        static void GetFastBMWs(List<Car> myCars)
        {
            Console.WriteLine("Get Fast BMWs");
            // Find the fast BMWs!
            var fastCars = from c in myCars where c.Speed > 90 && c.Make == "BMW" select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }

        static void DisplayDiff()
        {
            Console.WriteLine("Display Differences");
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            var carDiff = (from c in myCars select c)
            .Except(from c2 in yourCars select c2);
            Console.WriteLine("Here is what you don't have, but I do:");
            foreach (string s in carDiff)
                Console.WriteLine(s); // Prints Yugo.
        }

        static void DisplayIntersection()
        {
            Console.WriteLine("Display Intersection");
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            // Get the common members.
            var carIntersect = (from c in myCars select c)
            .Intersect(from c2 in yourCars select c2);
            Console.WriteLine("Here is what we have in common:");
            foreach (string s in carIntersect)
                Console.WriteLine(s); // Prints Aztec and BMW.
        }

        static void DisplayUnion()
        {
            Console.WriteLine("Display Union");
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            // Get the union of these containers.
            var carUnion = (from c in myCars select c)
            .Union(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything:");
            foreach (string s in carUnion)
                Console.WriteLine(s); // Prints all common members.
        }

        static void DisplayConcat()
        {
            Console.WriteLine("Display Concat");
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            var carConcat = (from c in myCars select c)
            .Concat(from c2 in yourCars select c2);
            // Prints:
            // Yugo Aztec BMW BMW Saab Aztec.
            foreach (string s in carConcat)
                Console.WriteLine(s);
        }

        static void DisplayConcatNoDups()
        {
            Console.WriteLine("Display Concat No Duplicates");
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };
            var carConcat = (from c in myCars select c)
            .Concat(from c2 in yourCars select c2);
            // Prints:
            // Yugo Aztec BMW Saab Aztec.
            foreach (string s in carConcat.Distinct())
                Console.WriteLine(s);
        }
    }
}
