using BE_NET_DataAcess.NetFarmeWork.Common;
using BE_NET_DataAcess.NetFarmeWork.DataObject;
using BE_NET_DataAcess.NetFarmeWork.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.Interface
{
    public class ProductManager : IProduct
    {
        public List<Product> products = new List<Product>();
        public ProductInsertResponseData Product_Insert(Product product)
        {
            var returnData = new ProductInsertResponseData();
            try
            {
                //Code xử lý
                // Kiểm tra tính hợp lệ của đối tượng product và các thuộc tính của nó
                if (product == null  // Nếu đối tượng product là null (không tồn tại)
                    || string.IsNullOrEmpty(product.Name)  // Hoặc nếu tên sản phẩm là null hoặc chuỗi rỗng
                    || product.Id <= 0)  // Hoặc nếu Id của sản phẩm nhỏ hơn hoặc bằng 0 (không hợp lệ)
                {
                    returnData.ResponseCode = (int)ProductInsertStatus.DataInvalid;  // Gán mã lỗi cho ResponseCode
                    returnData.ResponseMessenger = "Dữ liệu đầu vào không hợp lệ!";  // Thông báo lỗi
                    return returnData;  // Trả về đối tượng response chứa thông báo lỗi
                }
                // Kiểm tra xem Name có rủi ro gì không ( javascript , thẻ html ... ký tự đặc biêt..)
                if (!Validation.CheckString(product.Name))
                {
                    returnData.ResponseCode = (int)ProductInsertStatus.ProductNameNull;
                    returnData.ResponseMessenger = "ProductName không hợp lệ!";
                    return returnData;
                }

                if (!Validation.CheckXSSInput(product.Name))
                {
                    returnData.ResponseCode = (int)ProductInsertStatus.InvalidXSSInput;
                    returnData.ResponseMessenger = "ProductName không hợp lệ!";
                    return returnData;
                }


                // kiểm tra trùng  c1
                //var isExits = products.FindAll(s => s.Name == product.Name).Any() ? true : false;
                //if (isExits)
                //{
                //    returnData.ReponseCode = -4;
                //    returnData.ResponseMessenger = "ProductName đã tồn tại!";
                //    return returnData;
                //}

                // kiểm tra trùng  c2
                var isExits = true;
                if (products.Count > 0)
                {
                    foreach (var item in products)
                    {
                        if (item.Name.Equals(product.Name)) { isExits = false; break; }
                    }
                }

                if (!isExits)
                {
                    returnData.ResponseCode = (int)ProductInsertStatus.Dupplicate;
                    returnData.ResponseMessenger = "ProductName đã tồn tại!";
                    return returnData;
                }



                products.Add(product);

                returnData.ResponseCode = (int)ProductInsertStatus.Success;
                returnData.ResponseMessenger = "Thêm thành công!";
                return returnData;

            }
            catch (Exception ex)
            {

                returnData.ResponseCode = -99;
                returnData.ResponseMessenger = ex.StackTrace;
                return returnData;
            }
        }
    }
}
