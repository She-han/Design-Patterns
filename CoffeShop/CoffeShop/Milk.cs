using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class Milk : CoffeeDecorator
    {
        public Milk(Coffee coffee) : base(coffee) { }

        public override string getDescription()
        {
            return coffee.getDescription() + "Milk";
        }

        public override double getPrice()
        {
            return coffee.getPrice() + 30;
        }
    }
}
