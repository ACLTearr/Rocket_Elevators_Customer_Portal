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
    public class ElevatorController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //var userName = User.FindFirstValue(ClaimTypes.Name);

            List<Elevator> elevatorList = new List<Elevator>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://radiant-ridge-19107.herokuapp.com/api/elevators/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    elevatorList = JsonConvert.DeserializeObject<List<Elevator>>(apiResponse);
                }
            }
            return View(elevatorList);
        }
    }
}
