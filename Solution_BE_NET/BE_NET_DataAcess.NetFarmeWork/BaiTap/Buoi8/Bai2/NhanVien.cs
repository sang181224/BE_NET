using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai2
{
    public abstract class NhanVien
    {

        public string MaNV {  get; set; }
        public string TenNV {  get; set; }
        public string LoaiNV {  get; set; }

        public NhanVien(string maNV, string tenNV, string loaiNV)
        {
            MaNV = maNV;
            TenNV = tenNV;
            LoaiNV = loaiNV;
        }
        public NhanVien() { }
        public abstract double TinhLuong();
    }
}
