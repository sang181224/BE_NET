using BE_NET_DataAcess.NetFarmeWork.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai1
{
    public class QLHinhHoc
    {
        Validation validate = new Validation();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("---------QL Hình Học---------");
                Console.WriteLine("1. Hình Chữ Nhật");
                Console.WriteLine("2. Hình Tròn");
                Console.WriteLine("0. Thoát");
                double bai1 = validate.InputNumber("Chọn 0 - 2: ");
                switch (bai1)
                {
                    case 1:
                        double chieuDai = validate.InputNumber("Nhập chiều dài HCN: ");
                        double chieuRong = validate.InputNumber("Nhập chiều rộng HCN: ");
                        HinhChuNhat hinhChuNhat = new HinhChuNhat(chieuDai, chieuRong);
                        Console.WriteLine("Chu vi của hình chữ nhật là: " + hinhChuNhat.TinhChuVi());
                        Console.WriteLine("Diện tích của HCN là: " + hinhChuNhat.TinhDienTich());
                        break;
                    case 2:
                        double banKinh = validate.InputNumber("Nhập bán kính hình tròn: ");
                        HinhTron hinhTron = new HinhTron(banKinh);
                        Console.WriteLine("Chu vi của hình tròn là: " + hinhTron.TinhChuVi());
                        Console.WriteLine("Diện tich của hình tròn là: " + hinhTron.TinhDienTich());
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Vui lòng chọn 0 - 2: ");
                        break;
                }

            }
        }
    }
}
