using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class Standard : Room
    {
        public string getDescription()
        {
            return "Standard room";
        }

        public double getPrice()
        {
            return 15000;
        }
    }
}
