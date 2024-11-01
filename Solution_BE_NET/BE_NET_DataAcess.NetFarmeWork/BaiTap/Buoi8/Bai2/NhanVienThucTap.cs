using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai2
{
    public class NhanVienThucTap : NhanVien
    {
        public double PhuCapTheoNgay { get; set; }
        public int SoNgayLamViec { get; set; }
        public double Thuong { get; set; }

        public NhanVienThucTap(string maNV, string tenNV, string loaiNV, double phuCapTheoNgay, int soNgayLamViec, double thuong) : base(maNV, tenNV, loaiNV)
        {
            PhuCapTheoNgay = phuCapTheoNgay;
            SoNgayLamViec = soNgayLamViec;
            Thuong = thuong;
        }

        public override double TinhLuong()
        {
            return (PhuCapTheoNgay * SoNgayLamViec) + Thuong;
        }
    }
}
