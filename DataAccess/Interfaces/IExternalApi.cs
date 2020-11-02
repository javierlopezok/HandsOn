using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IExternalApi
    {
        List<EmployeeVM> GetEmployees();
    }
}
