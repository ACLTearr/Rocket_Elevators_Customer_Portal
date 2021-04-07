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
    public class BatteryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //var userName = User.FindFirstValue(ClaimTypes.Name);

            List<Battery> batteryList = new List<Battery>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://radiant-ridge-19107.herokuapp.com/api/batteries/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    batteryList = JsonConvert.DeserializeObject<List<Battery>>(apiResponse);
                }
            }
            return View(batteryList);
        }
    }
}
