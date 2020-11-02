using DataAccess.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace DataAccess
{
    public class ExternalApi : IExternalApi
    {

        public List<EmployeeVM> GetEmployees()
        {

            var requestUri = "http://masglobaltestapi.azurewebsites.net/api/Employees";

            var client = new HttpClient
            {
                BaseAddress = new Uri(requestUri)
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(requestUri).Result;

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;

                var resultContent = JsonConvert.DeserializeObject<List<EmployeeVM>>(content);

                return resultContent.ToList();
            }
            else
            {
                return null;
            }
        }

    }
}