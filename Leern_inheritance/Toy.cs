using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leern_inheritance
{
    internal class Toy
    {
        protected string name;
        protected double price;
        protected string color;
      
        public Toy(string name, int price, string color)
        {
            this.name = name;
            this.price = price;
            this.color = color;
        }

        public double Price()
        {
            return price;
        }

        public void UpdatePrice(double percent)
        {
            price*= ((100 +  percent) / 100) ;
        }
    }
}
