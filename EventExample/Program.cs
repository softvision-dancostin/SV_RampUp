using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");
            // First, make a Car object.
            Car car = new Car("SlugBug", 100, 10);
            // Now, tell the car which method to call
            // when it wants to send us messages.
            car.AboutToBlow += car_AboutToBlow;
            car.Exploded += car_Exploded;
            // Speed up (this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                car.Accelerate(20);
            Console.ReadLine();
        }

        static void car_Exploded(object sender, CarEventArgs e)
        {
            Console.WriteLine("Fatal Message from Car: {0}", e.msg);
        }

        static void car_AboutToBlow(object sender, CarEventArgs e)
        {
            Console.WriteLine("Message from Car: {0}", e.msg);
        }
    }
}
