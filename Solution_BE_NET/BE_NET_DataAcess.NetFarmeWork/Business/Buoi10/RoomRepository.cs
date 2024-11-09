using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject.Buoi10
{
    public class RoomRepository : IRoomRepository
    {
        private List<Room> _rooms;

        public RoomRepository()
        {
            _rooms = new List<Room>
            {
                new StandardRoom(101),
                new DeluxeRoom(102),
                new SuiteRoom(103)
            };
        }

        public Room GetRoom(int roomNumber)
        {
            return _rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
        }
    }
}
