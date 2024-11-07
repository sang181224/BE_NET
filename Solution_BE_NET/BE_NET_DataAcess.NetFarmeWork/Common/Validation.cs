using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.Common
{
    public class Validation
    {
        #region Nhập Số
        public double InputNumber(String inputCheck)
        {
            double number;
            while (true)
            {
                Console.Write(inputCheck);
                string input = Console.ReadLine();
                //string pattern = @"^-?\d+(\.\d+)?$"; //Có số âm
                string pattern = @"^\d+(\.\d+)?$"; //Không có số âm
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(input) && double.TryParse(input, out number))
                {
                    if (number > double.MaxValue)
                    {
                        Console.WriteLine("Số quá lớn, vui lòng nhập lại");
                    }
                    else
                    {
                        return number;
                    }

                }
                else
                {
                    Console.WriteLine("Đầu vào không hợp lệ, vui lòng nhập lại");
                }
            }
        }
        #endregion

        #region Nhập Chữ
        //Chuỗi không được chứa số
        public string InputString(string inputCheck)
        {
            while (true)
            {
                Console.Write(inputCheck);
                string input = Console.ReadLine();
                string pattern = @"^[a-zA-Z\s]*$"; // Chỉ chứa ký tự chữ và khoảng trắng
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(input))
                {
                    return input; // Trả về chuỗi hợp lệ
                }
                else
                {
                    Console.WriteLine("Đầu vào không hợp lệ, vui lòng chỉ nhập các chữ cái.");
                }
            }
        }

        #endregion

        #region Kiểm tra Chuỗi
        public static bool CheckString(string input)
        {
            // 1. Kiểm tra xem chuỗi có null hoặc rỗng không
            if (string.IsNullOrEmpty(input)) return false;

            // 2. Thử chuyển chuỗi thành số nguyên
            int number;
            if (int.TryParse(input, out number)) return false;

            // 3. Kiểm tra độ dài của chuỗi có lớn hơn 100 ký tự không
            if (input.Length > 100) return false;

            // 4. Nếu tất cả các kiểm tra đều qua, trả về true
            return true;
        }
        #endregion

        #region Kiểm tra Số
        public static bool CheckNumber(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            int number;
            if (!int.TryParse(input, out number)) return false;
            return true;
        }
        #endregion

        #region Kiểm tra mã độc XSS
        public static bool CheckXSSInput(string input)
        {
            try
            {
                // 1. Danh sách các chuỗi nguy hiểm liên quan đến XSS
                var listdangerousString = new List<string> { "<applet", "<body", "<embed", "<frame", "<script", "<frameset", "<html", "<iframe", "<img", "<style", "<layer", "<link", "<ilayer", "<meta", "<object", "<h", "<input", "<a", "&lt", "&gt" };
                if (string.IsNullOrEmpty(input)) return false;
                if (string.IsNullOrEmpty(input)) return false;
                foreach (var dangerous in listdangerousString)
                {
                    // 4. Kiểm tra chuỗi đầu vào (sau khi được chuyển về chữ thường và loại bỏ khoảng trắng)
                    if (input.Trim().ToLower().IndexOf(dangerous) >= 0) return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                // 6. Nếu có lỗi trong quá trình kiểm tra, trả về false
                return false;
            }
        }
        #endregion

        #region Nhập giới tính
        public string InputGender(string inputCheck)
        {
            while (true)
            {
                Console.Write(inputCheck);
                string input = Console.ReadLine();
                string pattern = @"^(Male|Female|Other)$"; // Chỉ chứa ký tự chữ và khoảng trắng
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase); //RegexOptions.IgnoreCase để không phân biệt hoa thường
                if (regex.IsMatch(input))
                {
                    return input; // Trả về chuỗi hợp lệ
                }
                else
                {
                    Console.Write("Đầu vào không hợp lệ, vui lòng nhập lại.");
                }
            }
        }
        #endregion
    }
}
