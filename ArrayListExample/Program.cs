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
            Console.ReadLine();

            WorkWithArrayList();
            Console.ReadLine();
        }

        static void WorkWithArrayList()
        {
            // Value types are automatically boxed when
            // passed to a member requesting an object.
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            // Unboxing occurs when a object is converted back to
            // stack-based data.
            int i = (int)myInts[0];
            // Now it is reboxed, as WriteLine() requires object types!
            Console.WriteLine("Value of your int: {0}", i);
        }
    }
}
