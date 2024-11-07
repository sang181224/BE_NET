using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.Enum
{
    public enum ProductionStageInsertStatus
    {
        Success = 1,            //Thành công
        DataInvalid = -1,       //Dữ liệu không hợp lệ
        ProductionStageNull = -2,   //Dữ liệu công đoạn sản xuất NULL
        InvalidXSSInput = -3,   //Đầu vào chứa mã độc XSS
        Dupplicate = -4         //Trùng lặp
    }
}
