using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class Espresso : Coffee
    {
        public string getDescription()
        {
            return "Espresso";
        }

        public double getPrice()
        {
            return 200;
        }
    }
}
