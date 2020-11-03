using Business_Logic;
using DataAccess;
using Entities;
using System.Collections.Generic;
using System.Web.Http;

namespace HandsOn.Controllers
{
    [RoutePrefix("v1")]
    public class V1_ApiController : ApiController
    {
        private readonly IExternalApi externalApi;
        private readonly IEmployeeService employeeService;

        public V1_ApiController(IExternalApi externalApi,
            IEmployeeService employeeService)
        {
            this.externalApi = externalApi;
            this.employeeService = employeeService;
        }

        [Route("HandsOn/Employees")]
        [HttpGet]
        public IHttpActionResult Employees(string id)
        {
            var listEmployees = externalApi.GetEmployees(id);

            var final = new List<Employee>();

            foreach (var item in listEmployees)
            {
                final.Add(employeeService.GetEmployee(item));
            }

            return Ok(final);
        }    
    }
}