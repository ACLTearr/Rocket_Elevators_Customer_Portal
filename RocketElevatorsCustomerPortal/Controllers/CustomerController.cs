using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RocketElevatorsCustomerPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RocketElevatorsCustomerPortal.Controllers
{
    public class CustomerController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);

            List<Customer> customerList = new List<Customer>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://rest-api-burroughs.herokuapp.com/api/customers/" + userName + "/customer"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customerList = JsonConvert.DeserializeObject<List<Customer>>(apiResponse);
                }
            }
            return View(customerList);
        }
    }
}
