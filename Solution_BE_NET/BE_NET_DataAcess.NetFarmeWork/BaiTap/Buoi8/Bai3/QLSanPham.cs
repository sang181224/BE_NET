using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai3
{
    public class QLSanPham
    {
        public void GiaBan()
        {
            DienThoai sp1 = new DienThoai("SP001", "Iphone 16 Pro Max", 34990000, 10);
            LapTop sp2 = new LapTop("SP002", "Dell xps 17 9700", 45000000, 15);
            Sach sp3 = new Sach("SP003", "Lộ trình BE ASP.NET CORE", 1000000, true);
            Console.WriteLine("Mã SP: {0}, Tên SP: {1}, Giá Gốc: {2}, Khuyến Mãi: {3}, Giá bán: {4}", 
                                sp1.MaSP, sp1.TenSP, sp1.GiaGocSP, sp1.KhuyenMai, sp1.TinhGiaBan());
            Console.WriteLine("Mã SP: {0}, Tên SP: {1}, Giá Gốc: {2}, Thuế: {3}, Giá bán: {4}",
                                sp2.MaSP, sp2.TenSP, sp2.GiaGocSP, sp2.Thue, sp2.TinhGiaBan());
            Console.WriteLine("Mã SP: {0}, Tên SP: {1}, Giá Gốc: {2}, Là BestSeller: {3}, Giá bán: {4}",
                                sp3.MaSP, sp3.TenSP, sp3.GiaGocSP, sp3.LaBestseller, sp3.TinhGiaBan());
        }
    }
}
