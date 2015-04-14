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
            // This caller does not care about getting all songs,
            // but indirectly created 10,000 objects!
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();
            Console.ReadLine();
        }
    }
}
