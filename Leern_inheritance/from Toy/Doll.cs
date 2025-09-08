using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leern_inheritance.from_Toy
{
    internal class Doll: Toy
    {
        private int accNums;
        private double accPrice;
        public Doll(string name, double baseprice, string color, int accNums, double accPrice) : base(name, baseprice, color)
        {
            this.accNums = accNums;
            this.accPrice = accPrice;
        }
        public double Price()
        {
            return base.Price() + (accNums * accPrice);
        }
        public override string ToString()
        {
            return $"{base.ToString()},\nAccessories: {accNums},\nAccessory Price: {accPrice}";
        }
    }
}
