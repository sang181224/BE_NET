using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai3
{
    public class LapTop : SanPham
    {
        public double Thue { get; set; }
        public LapTop(string maSP, string tenSP, double giaGocSP, double thue) : base(maSP, tenSP, giaGocSP)
        {
            Thue = thue;
        }

        public override double TinhGiaBan()
        {
            return GiaGocSP + (GiaGocSP * Thue / 100);
        }
    }
}
