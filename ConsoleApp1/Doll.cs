using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Doll : toy
    {
        private int accNums;        
        private double accPrice;  

        public Doll(string name, double baseprice, string color, int accNums, double accPrice)
                    : base(name, baseprice, color)
        {
            this.accNums = accNums;
            this.accPrice = accPrice;
        }

        public override double Price()
        {  
            return this.basePrice + this.accPrice * this.accNums;
        }

        public override string ToString()
        {
            string str = $"Name {base.ToString()}\n accNums: {this.accNums},\n" +
                $"accPrice:  {this.accPrice}";
            return str;
           

        }
        public override void HowITSound()
        {
            Console.WriteLine("sound: Chi Chi Chi");
        }


    }


}
