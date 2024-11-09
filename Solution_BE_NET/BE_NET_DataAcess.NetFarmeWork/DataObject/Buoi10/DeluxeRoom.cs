using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject
{
    public class DeluxeRoom : Room
    {
        public DeluxeRoom(int roomNumber) : base(roomNumber)
        {
            RoomType = "Deluxe";
        }
    }
}
