using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai3
{
    public class Sach : SanPham
    {
        public bool LaBestseller { get; set; }
        public Sach(string maSP, string tenSP, double giaGocSP, bool laBestseller) : base(maSP, tenSP, giaGocSP)
        {
            LaBestseller = laBestseller;
        }

        public override double TinhGiaBan()
        {
            return LaBestseller ? GiaGocSP * 1.1 : GiaGocSP;
        }
    }
}
