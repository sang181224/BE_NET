using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject
{
    public class Booking
    {
        //BookingId, CustomerName, RoomNumber, CheckInDate, và CheckOutDate.
        public int BookingID { get; set; }
        public string CustomerName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

    }
}
