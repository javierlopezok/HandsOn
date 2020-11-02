using DataAccess;
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

        public HomeController(IExternalApi externalApi)
        {
            this.externalApi = externalApi;
        }

        public ActionResult Index()
        {
            ViewBag.Employees = externalApi.GetEmployees();

            return View();
        }    
    }
}