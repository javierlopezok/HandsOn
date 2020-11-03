using DataAccess.ViewModels;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Utils;

namespace Business_Logic
{
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployee(EmployeeVM item)
        {

            if (item.ContractTypeName == GeneralEnum.HourlySalaryEmployee)
            {

                return new HourlyEmployee(item.HourlySalary)
                {
                    Id = item.Id,
                    Name = item.Name,
                    RoleId = item.RoleId,
                    RoleName = item.RoleName,
                    RoleDescription = item.RoleDescription,
                    HourlySalary = item.HourlySalary,
                    contractTypeName = item.ContractTypeName
                };
            }

            if (item.ContractTypeName == GeneralEnum.MonthlySalaryEmployee)
            {

                return new MonthlyEmployee(item.MonthlySalary)
                {
                    Id = item.Id,
                    Name = item.Name,
                    RoleId = item.RoleId,
                    RoleName = item.RoleName,
                    RoleDescription = item.RoleDescription,
                    MonthlySalary = item.MonthlySalary,
                    contractTypeName = item.ContractTypeName
                };

            }

            return null;

        }

        [TestMethod]
        public void TestGetEmployee()
        {
            Assert.IsNull(GetEmployee(null));
        }

    }
}