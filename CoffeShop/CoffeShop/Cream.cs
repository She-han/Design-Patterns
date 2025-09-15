using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class Cream : CoffeeDecorator
    {
        public Cream(Coffee coffee) : base(coffee) { }
        public override string getDescription()
        {
            return coffee.getDescription() + "Cream";
        }

        public override double getPrice()
        {
            return coffee.getPrice() + 70;
        }
    }
}
