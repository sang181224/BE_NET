using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai2
{
    public class QLNhanVien
    {
        public void Luong()
        {
            NhanVienToanTG nv1 = new NhanVienToanTG("NV01", "Nguyễn Văn A", "NVTTG", 10000000, 1000000, 500000);
            NhanVienBanTG nv2 = new NhanVienBanTG("NV02", "Nguyễn Văn B", "NVBTG", 10, 30000);
            NhanVienThucTap nv3 = new NhanVienThucTap("NV03", "Nguyễn Văn C", "NVTT", 250000, 15, 100000);
            Console.WriteLine("Mã NV: {0}, Tên NV: {1}, Loại NV: {2}, Lương cơ bản: {3}, Thưởng: {4}, Phạt: {5}, Thực nhận: {6}", 
                               nv1.MaNV, nv1.TenNV, nv1.LoaiNV, nv1.LuongCoBan, nv1.Thuong, nv1.Phat, nv1.TinhLuong());
            Console.WriteLine("Mã NV: {0}, Tên NV: {1}, Loại NV: {2}, Số giờ làm việc {3}, Lương mỗi giờ: {4}, Thực nhận: {5}",
                              nv2.MaNV, nv2.TenNV, nv2.LoaiNV, nv2.SoGioLamViec, nv2.LuongMoiGio,nv2.TinhLuong());
            Console.WriteLine("Mã NV: {0}, Tên NV: {1}, Loại NV: {2}, Phụ cấp theo ngày: {3}, Số ngày làm việc: {4}, Thực nhận: {5}",
                              nv3.MaNV, nv3.TenNV, nv3.LoaiNV, nv3.PhuCapTheoNgay, nv3.SoNgayLamViec, nv3.TinhLuong());
        }
    }
}
