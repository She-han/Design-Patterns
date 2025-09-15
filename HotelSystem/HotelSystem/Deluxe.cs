using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class Deluxe : Room
    {
        public string getDescription()
        {
            return "Deluxe room";
        }

        public double getPrice()
        {
            return 30000;
        }
    }
}
