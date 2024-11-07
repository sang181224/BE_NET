using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject
{
    public class ProductionStage
    {
        public int StageCode {  get; set; }//Mã công đoạn
        public string StageName { get; set; }//Tên công đoạn
        public int ProductCount { get; set; }//Số lượng sản phẩm
    }
}
