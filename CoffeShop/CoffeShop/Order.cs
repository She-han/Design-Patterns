using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class Order
    {
        public int No { get; set; }

        public string name { get; set; }

        public DateTime orderdate { get; set; }

        public string type { get; set; }

        public string size { get; set; }

        public string addons { get; set; }

        public int quantity { get; set; }

        public double netprice { get; set; }
    }
}
