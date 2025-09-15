using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class Customer
    {
        public int no { get; set; }
        public string name { get; set; }

        public DateTime checkingdate { get; set; }

        public string roomtype { get; set; }

        public double rescharges { get; set; }

        public double barcharges { get; set; }

        public double wellcharges { get; set; }

        public double pickcharges { get; set; }

        public double total { get; set; }
    }
}
