﻿using System;
using System.Collections.ObjectModel;

namespace ObservableCollectionExample
{
    public enum NotifyCollectionChangedAction
    {
        Add = 0,
        Remove = 1,
        Replace = 2,
        Move = 3,
        Reset = 4,
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Make a collection to observe and add a few Person objects.
            ObservableCollection<Person> people = new ObservableCollection<Person>();
            people.CollectionChanged += people_CollectionChanged;
            people.Add(new Person { FirstName = "Peter", LastName = "Murphy", Age = 52 });
            people.Add(new Person { FirstName = "Kevin", LastName = "Key", Age = 48 });
            people.RemoveAt(0);
            // Wire up the CollectionChanged event.

            Console.ReadLine();
        }

        static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // What was the action that caused the event?
            Console.WriteLine("Action for this event: {0}", e.Action);
            // They removed something.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
            // They added something.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                // Now show the NEW items that were inserted.
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            Console.WriteLine("");
        }
    }
}
