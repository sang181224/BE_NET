using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.Common
{
    public class Validate
    {
        public double NhapSo(String inputCheck)
        {
            double so;
            while (true)
            {
                Console.Write(inputCheck);
                string nhap = Console.ReadLine();
                string mau = @"^\d+(\.\d+)?$";
                Regex regex = new Regex(mau);
                if (regex.IsMatch(nhap) && double.TryParse(nhap, out so)){
                    if (so > double.MaxValue)
                    {
                        Console.WriteLine("Số quá lớn, vui lòng nhập lại");
                    } else
                    {
                        return so;
                    }

                }
                else
                {
                    Console.WriteLine("Đầu vào không hợp lệ, vui lòng nhập lại");
                }
            }
        }
    }
}
