using Leern_inheritance.from_Toy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leern_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 qesion
            Car myCar = new Car("BBN", 2, "Blue", 452154.1214);
            Doll wowDoll = new Doll("Doll", 450.9, "black", 445, 50);
            //qesion 3
            double sum = 0;
            sum+= myCar.Price();
            sum+= wowDoll.Price();
            Console.WriteLine("the car price is: "+myCar.Price());
            Console.WriteLine("the doll price is: " + wowDoll.Price());
            Console.WriteLine("the total price is: "+sum);
            myCar.UpdatePrice(10000000000);
            wowDoll.UpdatePrice(50);
            Console.WriteLine("the car price after update is: "+myCar.Price());
            Console.WriteLine("the doll price after update is: " + wowDoll.Price());
            Console.WriteLine("the total price after update is: " + (myCar.Price()+ wowDoll.Price()));
            Console.WriteLine(myCar.ToString());
            Console.WriteLine(wowDoll.ToString());


        }
    }
}
