using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car : Toy
    {
        private int size;  
        public Car(string name, double basePrice, string color, int size)
                    : base(name, basePrice, color) { this.size = size; }
        public override double Price()
        {   
            return this.basePrice + size * 15;
        }

        public override string ToString()
        {
            string str = $"the car: {base.ToString()}\n" +
                $"the car size is:  {this.size}";

            return str;
            
        }

        public override void HowITSound()
        {
            Console.WriteLine("sound: Van Van");
        }

    }

}
