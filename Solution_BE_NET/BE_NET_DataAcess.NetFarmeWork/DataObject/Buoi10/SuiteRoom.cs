using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject
{
    public class SuiteRoom : Room
    {
        public SuiteRoom(int roomNumber) : base(roomNumber)
        {
            RoomType = "Suite";
        }
    }
}
