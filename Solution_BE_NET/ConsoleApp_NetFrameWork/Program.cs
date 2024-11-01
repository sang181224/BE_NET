using BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai1;
using BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai2;
using BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai3;
using BE_NET_DataAcess.NetFarmeWork.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp_NetFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLHinhHoc qLHinhHoc = new QLHinhHoc();
            QLNhanVien qLNhanVien = new QLNhanVien();
            QLSanPham qLSanPham = new QLSanPham();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Validate validate = new Validate();
            while (true)
            {
                Console.WriteLine("---------MENU---------");
                Console.WriteLine("1: Quản Lý Hình Học");
                Console.WriteLine("2: Quản Nhân Viên");
                Console.WriteLine("3: Quản Lý Sản Phẩm");
                Console.WriteLine("0: Thoát");
                double i = validate.NhapSo("Chọn 0 - 3: ");
                switch (i)
                {
                    case 1:
                        qLHinhHoc.Menu();
                        break;
                    case 2:
                        qLNhanVien.Luong();
                        break;
                    case 3:
                        qLSanPham.GiaBan();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Vui lòng nhập 1 số từ 0 - 3");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
    
}
