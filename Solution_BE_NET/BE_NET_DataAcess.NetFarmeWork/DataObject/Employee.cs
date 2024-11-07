using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.DataObject
{
    public class Employee
    {
        //Nhân viên trong Mỗi đối tượng nhân viên có các thuộc tính sau:
        //id, tên, giới tính, tuổi, lương cơ bản, hệ số lương, phụ cấp, tổng lương
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double BaseSalary { get; set; } //Lương cơ bản
        public double SalaryCoefficient { get; set; } //Hệ số lương
        public double Allowance { get; set; } //Phụ cấp
        public double TotalSalary => BaseSalary*SalaryCoefficient+Allowance;
        public List<ProductionStage> productionStages { get; set; } = new List<ProductionStage>();
    }
}
