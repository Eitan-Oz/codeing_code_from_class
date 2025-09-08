using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Toy
    {

        protected double price;
        protected string color;
      
        public Toy(int price, string color)
        {
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
