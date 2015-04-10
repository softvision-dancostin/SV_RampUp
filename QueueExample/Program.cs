using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericQueue();
            Console.ReadLine();
        }
        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }
        static void UseGenericQueue()
        {
            // Make a Q with three people.
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person
            {
                FirstName = "Homer",
                LastName = "Simpson",
                Age = 47
            });
            peopleQ.Enqueue(new Person
            {
                FirstName = "Marge",
                LastName = "Simpson",
                Age = 45
            });
            peopleQ.Enqueue(new Person
            {
                FirstName = "Lisa",
                LastName = "Simpson",
                Age = 9
            });
            // Peek at first person in Q.
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);
            // Remove each person from Q.
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            // Try to de-Q again?
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error! {0}", e.Message);
            }
        }
    }
}
