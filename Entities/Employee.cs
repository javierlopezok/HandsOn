using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entities
{

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string RoleDescription { get; set; }

        public string contractTypeName { get; set; }

        public decimal AnnualSalary { get; set; }

    }

    public partial class HourlyEmployee : Employee
    {
        public HourlyEmployee(decimal hourlySalary)
        {
            AnnualSalary = hourlySalary * 12 * 120;
        }

        public decimal HourlySalary { get; set; }

    }


    public class MonthlyEmployee : Employee
    {
        public MonthlyEmployee(decimal monthlySalary)
        {
            AnnualSalary = monthlySalary * 12;
        }

        public decimal MonthlySalary { get; set; }
    }

}