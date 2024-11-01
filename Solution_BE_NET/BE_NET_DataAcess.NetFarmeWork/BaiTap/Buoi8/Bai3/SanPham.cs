using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai3
{
    public abstract class SanPham
    {
        public string MaSP {  get; set; }
        public string TenSP {  get; set; }
        public double GiaGocSP {  get; set; }
        public SanPham(string maSP, string tenSP, double giaGocSP)
        {
            MaSP = maSP;
            TenSP = tenSP;
            GiaGocSP = giaGocSP;
        }
        public abstract double TinhGiaBan();
    }
}
