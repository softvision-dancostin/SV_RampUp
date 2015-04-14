using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });
            // Show number of items in ArrayList.
            Console.WriteLine("This collection has {0} items.", strArray.Count);
            Console.WriteLine();
            // Add a new item and display current count.
            strArray.Add("Fourth!");
            Console.WriteLine("This collection has {0} items.", strArray.Count);
            // Display contents.
            foreach (string s in strArray)
            {
                Console.WriteLine("Entry: {0}", s);
            }
            Console.WriteLine();
        }
    }
}
