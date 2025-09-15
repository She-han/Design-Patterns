using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal abstract class CoffeeDecorator : Coffee
    {
        protected Coffee coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual string getDescription()
        {
            return coffee.getDescription();
        }

        public virtual double getPrice()
        {
            return coffee.getPrice();
        }
    }
}
