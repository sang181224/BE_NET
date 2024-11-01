using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai1
{
    public class HinhTron : HinhHoc
    {
        public double BanKinh { get; set; }

        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }
    }
}
