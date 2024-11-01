using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai3
{
    public class DienThoai : SanPham
    {
        public double KhuyenMai {  get; set; }

        public DienThoai(string maSP, string tenSP, double giaGocSP, double khuyenMai) : base(maSP, tenSP, giaGocSP)
        {
            KhuyenMai = khuyenMai;
        }

        public override double TinhGiaBan()
        {
            return GiaGocSP - (GiaGocSP * KhuyenMai / 100);
        }
    }
}
