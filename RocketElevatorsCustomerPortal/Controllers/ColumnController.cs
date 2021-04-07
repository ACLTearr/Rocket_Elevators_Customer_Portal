using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RocketElevatorsCustomerPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RocketElevatorsCustomerPortal.Controllers
{
    public class ColumnController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //var userName = User.FindFirstValue(ClaimTypes.Name);

            List<Column> columnList = new List<Column>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://radiant-ridge-19107.herokuapp.com/api/columns/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    columnList = JsonConvert.DeserializeObject<List<Column>>(apiResponse);
                }
            }
            return View(columnList);
        }
    }
}
