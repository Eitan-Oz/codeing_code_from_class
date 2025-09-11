using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            for (int i = int.MinValue; i < int.MaxValue; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(random.Next(0, 2));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(random.Next(0, 2));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(random.Next(0, 2));
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(random.Next(0, 2));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(random.Next(0, 2));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(random.Next(0, 2));
            }
        }
    }
}
