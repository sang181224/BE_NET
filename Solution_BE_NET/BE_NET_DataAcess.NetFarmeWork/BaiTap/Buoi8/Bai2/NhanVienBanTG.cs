using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai2
{
    public class NhanVienBanTG : NhanVien
    {
        public double SoGioLamViec {  get; set; }
        public double LuongMoiGio { get; set; }

        public NhanVienBanTG(string maNV, string tenNV, string loaiNV, double soGioLamViec, double luongMoiGio) : base(maNV, tenNV, loaiNV)
        {
            SoGioLamViec = soGioLamViec;
            LuongMoiGio = luongMoiGio;
        }
        public override double TinhLuong()
        {
            return SoGioLamViec*LuongMoiGio;
        }
    }
}
