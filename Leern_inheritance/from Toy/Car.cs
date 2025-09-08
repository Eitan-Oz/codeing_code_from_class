using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leern_inheritance.from_Toy
{
    internal class Car: Toy
    {
        private int size;
        public Car(string name, int size, string color, double basePrice) : base(name, basePrice, color)
        {
            this.size = size;
        }
        public double Price()
        {
            if (size ==0)
            {
                return base.Price();
            }
            else if (size == 1)
            {
                return base.Price() + 15;
            }
            else
            {
                return base.Price() + 30;
            }
        }
        public override string ToString()
        {
            string str=$"Car: {this.name} \nbase Price: {this.baseprice} color: {this.color}\n";
            if (size == 0) {str += "Size: Small";}
            else if (size == 1){str += "Size: Medium";}
            else{str += "Size: Large";}
            return str;
        }
    }
}
