using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class CustomerRepo
    {
        public static List<Customer> Customer_List = new List<Customer>();
        public static int cus_id =1;

        public static void addCustomer(Customer customer)
        {
            Customer_List.Add(customer);
            customer.no = cus_id++;
        }
    }
}
