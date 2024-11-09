using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject
{
    public abstract class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public bool IsVailable { get; set; }
        public Room (int roomNumber)
        {
            RoomNumber = roomNumber;
            IsVailable = true;
        }
    }
}
