    using BE_NET_DataAcess.NetFarmeWork.Common;
using BE_NET_DataAcess.NetFarmeWork.DataObject;
using BE_NET_DataAcess.NetFarmeWork.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET_DataAcess.NetFarmeWork.Interface
{
    public class EmployeeManager : IEmployee
    {
        public List<Employee> employees = new List<Employee>();
        Validation validation = new Validation();

        #region Dữ liệu phản hồi thêm Nhân Viên
        public EmployeeInsertResponseData Employee_Insert(Employee employee)
        {
            var returnData = new EmployeeInsertResponseData();
            try
            {
                if(employee == null ||
                    string.IsNullOrEmpty(employee.Name) || string.IsNullOrEmpty(employee.Age.ToString())
                    || string.IsNullOrEmpty(employee.Gender) || string.IsNullOrEmpty(employee.BaseSalary.ToString())
                    || string.IsNullOrEmpty(employee.Allowance.ToString()) || string.IsNullOrEmpty(employee.SalaryCoefficient.ToString())
                    || employee.Id <= 0)
                {
                    returnData.ResponseCode = (int)(EmployeeInsertStatus.DataInvalid);
                    returnData.ResponseMessenger = "Dữ liệu đầu vào không hợp lệ";
                    return returnData;
                }
                if(!Validation.CheckString(employee.Name) || !Validation.CheckNumber(employee.Age.ToString())
                   || !Validation.CheckString(employee.Gender) || !Validation.CheckNumber(employee.BaseSalary.ToString())
                   || !Validation.CheckNumber(employee.Allowance.ToString()) || !Validation.CheckNumber(employee.SalaryCoefficient.ToString()))
                {
                    returnData.ResponseCode = (int)(EmployeeInsertStatus.EmployeeNull);
                    returnData.ResponseMessenger = "Dữ liệu đầu vào không đúng định dạng";
                    return returnData;
                }
                if(!Validation.CheckXSSInput(employee.Name) || !Validation.CheckXSSInput(employee.Age.ToString())
                   || !Validation.CheckXSSInput(employee.Gender) || !Validation.CheckXSSInput(employee.BaseSalary.ToString())
                   || !Validation.CheckXSSInput(employee.Allowance.ToString()) || !Validation.CheckXSSInput(employee.SalaryCoefficient.ToString()))
                {
                    returnData.ResponseCode = (int)(EmployeeInsertStatus.InvalidXSSInput);
                }
                //Kiểm tra trùng id
                var isExits = true;
                if(employees.Count > 0)
                {
                    foreach (var item in employees)
                    {
                        if (employee.Id.Equals(item.Id))
                        {
                            isExits = false;
                            break;
                        }
                    }
                }
                if ((!isExits))
                {
                    returnData.ResponseCode = (int)EmployeeInsertStatus.Dupplicate;
                    returnData.ResponseMessenger = "ID Nhân viên bị trùng";
                    return returnData;
                }
                employees.Add(employee);
                returnData.ResponseCode = (int)EmployeeInsertStatus.Success;
                returnData.ResponseMessenger = "Thêm mới Nhân Viên thành công";
                return returnData;
            }
            catch (Exception ex)
            {
                returnData.ResponseCode = -99;
                returnData.ResponseMessenger = ex.Message;
                return returnData;
            }
        }
        #endregion

        #region Dữ liệu phản hồi thêm Công Đoạn
        public ProductionStageInsertResponseData ProductionStage_Insert(ProductionStage productionStage, Employee employee)
        {
            var returnData = new ProductionStageInsertResponseData();
            try
            {
                if(productionStage == null || string.IsNullOrEmpty(productionStage.StageCode.ToString()) 
                   || string.IsNullOrEmpty(productionStage.StageName) || string.IsNullOrEmpty(productionStage.ProductCount.ToString()))
                {
                    returnData.ResponseCode = (int)ProductionStageInsertStatus.DataInvalid;
                    returnData.ResponseMessenger = "Dữ liệu đầu vào không hợp lệ";
                    return returnData;
                }
                if(!Validation.CheckNumber(productionStage.StageCode.ToString())
                   || !Validation.CheckString(productionStage.StageName)
                   || !Validation.CheckNumber(productionStage.ProductCount.ToString()))
                {
                    returnData.ResponseCode = (int)ProductionStageInsertStatus.ProductionStageNull;
                    returnData.ResponseMessenger = "Dữ liệu đầu vào không đúng định dạng";
                    return returnData;
                }
                //Kiểm tra trùng mã
                var isExits = true;
                if(employee.productionStages.Count > 0)
                {
                    foreach (var item in employee.productionStages)
                    {
                        if (item.StageCode.Equals(productionStage.StageCode))
                        {
                            isExits = false;
                            break;
                        }
                    }
                }
                if (!isExits)
                {
                    returnData.ResponseCode = (int)ProductionStageInsertStatus.Dupplicate;
                    returnData.ResponseMessenger = "Trùng mã công đoạn";
                    return returnData ;
                }
                employee.productionStages.Add(productionStage);
                returnData.ResponseCode = (int)ProductionStageInsertStatus.Success;
                returnData.ResponseMessenger = "Thêm công đoạn mới thành công";
                return returnData ;
            }
            catch (Exception ex)
            {
                returnData.ResponseCode = -99;
                returnData.ResponseMessenger = ex.Message;
                return returnData;
            }
        }
        #endregion

        #region Thêm Nhân Viên

        public void AddEmployee()
        {
            Console.WriteLine("Chọn cách thêm nhân viên:");
            Console.WriteLine("1. Nhập từ bàn phím");
            Console.WriteLine("2. Nhập từ file Excel");
            Console.WriteLine("3. Thoát");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Employee employee = new Employee();
                employee.Id = (int)validation.InputNumber("Nhập ID: ");
                employee.Name = validation.InputString("Nhập tên (Không dấu): ");
                employee.Gender = validation.InputGender("Nhập giới tính (Male, Female, Other): ");
                employee.Age =(int) validation.InputNumber("Nhập tuổi: ");
                employee.BaseSalary = validation.InputNumber("Nhập lương cơ bản: ");
                employee.SalaryCoefficient = validation.InputNumber("Nhập hệ số lương: ");
                employee.Allowance = validation.InputNumber("Nhập phụ cấp: ");
                //kiểm tra thông tin nhập vào có hợp lệ không
                var result = Employee_Insert(employee);
                Console.WriteLine("Employee_Insert result : {0}", result.ResponseCode + " | Des:" + result.ResponseMessenger);
            }
            else if (choice == 2)
            {
                // Logic nhập từ file Excel sẽ được thêm ở đây
                Console.WriteLine("Chức năng nhập từ file Excel chưa được triển khai.");
            }
            else if(choice == 3)
            {
                return;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập từ 1 - 3"); 
                AddEmployee();
            }
        }
        #endregion

        #region Thêm Công Đoạn
        public void CreateProduction()
        {
            int employeeId = (int)validation.InputNumber("Nhập ID nhân viên: ");
            var isExits = false;
            Employee employee = null;
            if (employees.Count > 0)
            {
                foreach (var item in employees)
                {
                    if (item.Id.Equals(employeeId))
                    {
                        isExits = true;
                        employee = item;
                        break;
                    }
                }
            }
            if (isExits)
            {
                ProductionStage productionStage = new ProductionStage();
                productionStage.StageCode = (int) validation.InputNumber("Nhập mã công đoạn: ");
                productionStage.StageName = validation.InputString("Nhập tên công đoạn: ");
                productionStage.ProductCount = (int)validation.InputNumber("Nhập số lượng sản phẩm: ");
                var result = ProductionStage_Insert(productionStage, employee);
                Console.WriteLine("ProductionStage_Insert result : {0}", result.ResponseCode + " | Des:" + result.ResponseMessenger);
            }
            else
            {
                Console.WriteLine("ID Nhân viên không tồn tại.");
            }
        }

        public EmployeeInsertResponseData ProductionStage_Insert(Employee employee)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
