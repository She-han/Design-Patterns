using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class Double : Room
    {
        public string getDescription()
        {
            return "Double room";
        }

        public double getPrice()
        {
            return 22000;
        }
    }
}
