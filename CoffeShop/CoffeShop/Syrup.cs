using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class Syrup : CoffeeDecorator
    {
        public Syrup(Coffee coffee) : base(coffee) { }
        public override string getDescription()
        {
            return coffee.getDescription() + "Syrup";
        }

        public override double getPrice()
        {
            return coffee.getPrice() + 50;
        }
    }
}
