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
        static void Main(string[] args)
        {
            Toy doll = new Doll("Barbie", 50.0, "Pink", 3, 7.5);

            Toy car = new Car("Hot Wheels", 40.0, "Red", 2);

            Console.WriteLine(doll.ToString());
            doll.HowITSound();
            Console.WriteLine($"Doll price: {doll.Price()}");

            Console.WriteLine(car.ToString());
            car.HowITSound();
            Console.WriteLine($"Car price: {car.Price()}");
        }
    }
}
