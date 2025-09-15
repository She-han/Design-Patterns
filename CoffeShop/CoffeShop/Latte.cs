using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class Latte : Coffee
    {
        public string getDescription()
        {
            return "Latte";
        }

        public double getPrice()
        {
            return 300;
        }
    }
}
