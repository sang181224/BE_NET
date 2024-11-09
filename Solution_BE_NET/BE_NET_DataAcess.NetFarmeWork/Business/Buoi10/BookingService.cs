using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject.Buoi10
{
    public class BookingService : IBookingCreation, IBookingCancellation
    {
        private readonly IRoomRepository _roomRepository;
        List<Booking> _bookings = new List<Booking>();
        public BookingService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public RoomCreationResponseData CreateBooking(Booking booking)
        {
            var returnData = new RoomCreationResponseData();
            Room room = _roomRepository.GetRoom(booking.RoomNumber);
            if (room == null || !room.IsVailable)
            {
                returnData.ResponseCode = -1;
                returnData.ResponseMessenger = "Phòng không có sẵn";
                return returnData;
            }
            room.IsVailable = false;
            _bookings.Add(booking);
            returnData.ResponseCode = 1;
            returnData.ResponseMessenger = $"Đã đặt phòng với mã phòng là {booking.RoomNumber} thành công";
            return returnData;
        }
        public RoomCancellationResponseData CancelBooking(int BookingId)
        {
            
            var returnData = new RoomCancellationResponseData();
            var booking = _bookings.Find(b => BookingId == b.BookingID);
            if (booking == null)
            {
                returnData.ResponseCode= -1;
                returnData.ResponseMessenger = "Phòng này vẫn chưa được đặt";
                return returnData;
            }
            Room room = _roomRepository.GetRoom(booking.RoomNumber);
            room.IsVailable = true;
            returnData.ResponseCode = 1;
            returnData.ResponseMessenger = $"Huỷ đặt phòng với mã phòng là {booking.RoomNumber} thành công";
            _bookings.Remove(booking);
            return returnData;
        }
    }
}
