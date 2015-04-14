using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lazy Instantiation *****\n");
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();
            Console.ReadLine();
        }
    }
}
