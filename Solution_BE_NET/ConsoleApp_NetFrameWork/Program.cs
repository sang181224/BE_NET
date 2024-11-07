using BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai1;
using BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai2;
using BE_NET_DataAcess.NetFarmeWork.BaiTap.Buoi8.Bai3;
using BE_NET_DataAcess.NetFarmeWork.Common;
using BE_NET_DataAcess.NetFarmeWork.DataObject;
using BE_NET_DataAcess.NetFarmeWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp_NetFrameWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            #region Bài Tập Buổi 8
            //QLHinhHoc qLHinhHoc = new QLHinhHoc();
            //QLNhanVien qLNhanVien = new QLNhanVien();
            //QLSanPham qLSanPham = new QLSanPham();
            //Validation validate = new Validation();
            //while (true)
            //{
            //    Console.WriteLine("---------MENU---------");
            //    Console.WriteLine("1: Quản Lý Hình Học");
            //    Console.WriteLine("2: Quản Nhân Viên");
            //    Console.WriteLine("3: Quản Lý Sản Phẩm");
            //    Console.WriteLine("0: Thoát");
            //    double i = validate.NhapSo("Chọn 0 - 3: ");
            //    switch (i)
            //    {
            //        case 1:
            //            qLHinhHoc.Menu();
            //            break;
            //        case 2:
            //            qLNhanVien.Luong();
            //            break;
            //        case 3:
            //            qLSanPham.GiaBan();
            //            break;
            //        case 0:
            //            return;
            //        default:
            //            Console.WriteLine("Vui lòng nhập 1 số từ 0 - 3");
            //            break;
            //    }
            //}
            #endregion

            #region Ví Dụ Buổi 9 
            //var ps = new ProductManager();
            //var result = ps.Product_Insert(new Product { Id = 1, Name = "" });
            //Console.WriteLine("Product_Insert result : {0}", result.ResponseCode + " | Des:" + result.ResponseMessenger);
            #endregion

            #region Bài Tập Buổi 9
            EmployeeManager employeeManager = new EmployeeManager();
            while (true)
            {
                ShowMenu();
                var choise = Console.ReadLine();
                var kiemtra = Validation.CheckNumber(choise);
                if(kiemtra == true)
                {
                    switch (int.Parse(choise))
                    {
                        case 1:
                            employeeManager.AddEmployee();
                            break;
                        case 2:
                            employeeManager.CreateProduction();
                            break;
                        case 3:
                            //ExportReportToExcel();
                            break;
                        case 4:
                            //SearchEmployee();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Chọn lại chức năng.");
                            break;

                    }
                } else
                {
                    Console.WriteLine("Không hợp lệ, vui lòng nhập lại");
                }
            }
            
            Console.ReadKey();
        }
        #region Menu
        private static void ShowMenu()
        {
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1. Thêm nhân viên");
            Console.WriteLine("2. Tạo sản lượng theo công đoạn");
            Console.WriteLine("3. Xuất báo cáo ra Excel");
            Console.WriteLine("4. Tìm kiếm nhân viên");
            Console.WriteLine("5. Thoát");
            Console.Write("Chức năng: ");
        }
        #endregion
        #endregion
    }

}
