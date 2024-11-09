using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject
{
    public interface IBookingCreation
    {
        RoomCreationResponseData CreateBooking(Booking booking);
    }
}
