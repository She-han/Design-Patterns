using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class Wellness : RoomDecorator
    {
        private double charges;
        public Wellness(Room room, double charges) : base(room)
        {
            this.charges = charges;
        }


        public override string getDescription()
        {
            return room.getDescription() + "Wellness charges";
        }

        public override double getPrice()
        {
            return room.getPrice() + charges;
        }

    }
}
