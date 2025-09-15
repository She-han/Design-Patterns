using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    internal class Restaurent : RoomDecorator
    {
        private double charge;
        public Restaurent(Room room, double charge) : base(room)
        {
            this.charge = charge;
        }

        public override string getDescription()
        {
            return room.getDescription() + "Restaurent charges";
        }

        public override double getPrice()
        {
            return room.getPrice() + charge;
        }

    }
}
