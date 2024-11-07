using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject
{
    public class ReturnData
    {
        public int ResponseCode { get; set; } //Mã phản hồi
        public string ResponseMessenger { get; set; } //Tin nhắn phản hồi
    }

    //Dữ liệu phản hồi thêm sản phẩm
    public class ProductInsertResponseData : ReturnData
    {

    }  

    //Dữ liệu phản hồi thêm Nhân Viên
    public class EmployeeInsertResponseData : ReturnData
    {

    }

    //Dữ liệu phản hồi thêm công đoạn sản xuất
    public class ProductionStageInsertResponseData : ReturnData
    {

    }
}
