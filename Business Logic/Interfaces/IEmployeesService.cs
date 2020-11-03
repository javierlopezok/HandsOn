using DataAccess.ViewModels;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business_Logic
{
    public interface IEmployeeService
    {
        Employee GetEmployee(EmployeeVM item);
    }
}