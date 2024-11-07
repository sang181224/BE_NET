using BE_NET_DataAcess.NetFarmeWork.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.Interface
{
    public interface IProduct
    {
        ProductInsertResponseData Product_Insert(Product product);
    }
}
