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
        protected double baseprice;
        protected string color;
      
        public Toy(string name, double price, string color)
        {
            this.name = name;
            this.baseprice = price;
            this.color = color;
        }

        public double Price()
        {
            return this.baseprice;
        }

        public void UpdatePrice(double percent)
        {
            baseprice += this.baseprice*(percent/100) ;
        }
        public override string ToString()
        {
            return $"{name},\nBase Price: {baseprice},\nColor: {color}";
        }
    }
}
