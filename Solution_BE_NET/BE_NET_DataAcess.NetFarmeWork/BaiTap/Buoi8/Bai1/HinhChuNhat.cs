using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai1
{
    public class HinhChuNhat : HinhHoc
    {
        public double ChieuDai {  get; set; }
        public double ChieuRong { get; set; }
        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }
        public override double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }
        public override double TinhChuVi()
        {
            return 2 * (ChieuDai + ChieuRong);
        }
    }
}
