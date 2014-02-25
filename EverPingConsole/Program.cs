using System;
using CodersBlock.EverPing;

namespace EverPing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting EverPinger...");
            EverPinger.Start("http://codersblock.com/ping", 60000);

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }
    }
}
