using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.Enum
{
    public enum ProductInsertStatus
    {
        Success = 1,            //Thành công
        DataInvalid = -1,       //Dữ liệu không hợp lệ
        ProductNameNull = -2,   //Tên sản phẩm NULL
        InvalidXSSInput = -3,   //Đầu vào chứa mã độc XSS
        Dupplicate = -4         //Trùng lặp
    }
}
