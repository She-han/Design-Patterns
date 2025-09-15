using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    internal class OrderRepo
    {
        public static List<Order> orders = new List<Order>();
        public static int Oid = 1;

        public static void AddOrder(Order order)
        {
            orders.Add(order);
            order.No = Oid++;
        }
    }
}
