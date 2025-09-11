using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class toy
    {
        protected string name;
        protected double basePrice;
        protected string color;

        public toy(string name, double basePrice, string color)
        {
            this.name = name;
            this.basePrice = basePrice;
            this.color = color;
        }
        public virtual double Price()
        {
            return this.basePrice;
        }
        public virtual void UpdatePrice(double percent)
        {     
            this.basePrice += this.basePrice * (percent / 100);
        }
        public override string ToString()
        {
            string str = this.name + " base price = " + this.basePrice + " " + this.color + " ";
            return str;

        }
    }


}
