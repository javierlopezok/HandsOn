using Business_Logic;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOn.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExternalApi externalApi;
        private readonly IEmployeeService employeeService;

        public HomeController(IExternalApi externalApi,
            IEmployeeService employeeService)
        {
            this.externalApi = externalApi;
            this.employeeService = employeeService;
        }

        public ActionResult Index()
        {
            var listEmployees = externalApi.GetEmployees();

            var final = new List<Employee>();

            foreach (var item in listEmployees)
            {
                final.Add(employeeService.GetEmployee(item));
            }

            ViewBag.Employees = final;

            return View();
        }    
    }
}