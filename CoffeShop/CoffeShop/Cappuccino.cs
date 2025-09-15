using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class Cappuccino : Coffee
    {
        public string getDescription()
        {
            return "Cappuccino";
        }

        public double getPrice()
        {
            return 350;
        }
    }
}
