using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai2
{
    public class NhanVienToanTG : NhanVien
    {
        public double LuongCoBan {  get; set; }
        public double Thuong {  get; set; }
        public double Phat {  get; set; }

        public NhanVienToanTG(string maNV, string tenNV, string loaiNV, double luongCoBan, double thuong, double phat) : base(maNV, tenNV, loaiNV)
        {
            LuongCoBan = luongCoBan;
            Thuong = thuong;
            Phat = phat;
        }
        public override double TinhLuong()
        {
            return LuongCoBan + Thuong - Phat;
        }

    }
}
