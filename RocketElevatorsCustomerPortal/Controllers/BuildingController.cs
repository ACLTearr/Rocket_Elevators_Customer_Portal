using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RocketElevatorsCustomerPortal.Areas.Identity.Data;
using RocketElevatorsCustomerPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RocketElevatorsCustomerPortal.Controllers
{
    public class BuildingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);

            List<Building> buildingList = new List<Building>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://radiant-ridge-19107.herokuapp.com/api/buildings/" + userName + "/customer"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    buildingList = JsonConvert.DeserializeObject<List<Building>>(apiResponse);
                }
            }
            return View(buildingList);
        }
    }
}
