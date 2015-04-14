using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousDelegatesExample
{
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Primary Thread stats *****");
            Thread.CurrentThread.Name = "ThePrimaryThread";
            ShowThreadStats();

            Console.WriteLine("***** Async Delegate Invocation *****");
            Console.WriteLine("Main() invoked on thread {0}.",
            Thread.CurrentThread.ManagedThreadId);
            BinaryOp binaryOp = new BinaryOp(Add);
            IAsyncResult iftAR = binaryOp.BeginInvoke(10, 10, null, null);
            while (!iftAR.IsCompleted)
            {
                Console.WriteLine("Doing more work in Main()!");
                Thread.Sleep(1000);
            }
            int answer = binaryOp.EndInvoke(iftAR);
            Console.WriteLine("10 + 10 is {0}.", answer);
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            Console.WriteLine("");
            Console.WriteLine("***** Secondary Thread stats *****");
            Thread.CurrentThread.Name = "TheSecondaryThread";
            ShowThreadStats();

            Console.WriteLine("Add() invoked on thread {0}.",
            Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }

        static void ShowThreadStats()
        {
            // Obtain and name the current thread.
            Thread primaryThread = Thread.CurrentThread;
            // Show details of hosting AppDomain/Context.
            Console.WriteLine("Name of current AppDomain: {0}",
            Thread.GetDomain().FriendlyName);
            Console.WriteLine("ID of current Context: {0}",
            Thread.CurrentContext.ContextID);
            // Print out some stats about this thread.
            Console.WriteLine("Thread Name: {0}",
            primaryThread.Name);
            Console.WriteLine("Has thread started?: {0}",
            primaryThread.IsAlive);
            Console.WriteLine("Priority Level: {0}",
            primaryThread.Priority);
            Console.WriteLine("Thread State: {0}",
            primaryThread.ThreadState);
            Console.WriteLine("");
        }
    }
}
