using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class Pickup : RoomDecorator
    {
        private double charges;
        public Pickup(Room room, double charges) : base(room)
        {
            this.charges = charges;
        }

        public override string getDescription()
        {
            return room.getDescription() + "Pickup charges";
        }

        public override double getPrice()
        {
            return room.getPrice()+charges;
        }

    }
}
