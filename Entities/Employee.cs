using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entities
{

    public class HourlyEmployee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public int HourlySalary { get; set; }
    }

    public class MonthlyEmployee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public int MonthlySalary { get; set; }
    }

    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }


}