using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal abstract class RoomDecorator : Room
    {
        protected Room room;

        public RoomDecorator(Room room)
        {
            this.room = room;
        }

        public virtual string getDescription()
        {
            return room.getDescription();
        }

        public virtual double getPrice()
        {

            return room.getPrice() ;
        }
    }
}
