using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject
{
    public class StandardRoom : Room
    {
        public StandardRoom(int roomNumber) : base(roomNumber)
        {
            RoomType = "Standard";
        }
    }
}
