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
    public class InterventionController : Controller
    {
        public IActionResult Index()
        {

            var userName = User.FindFirstValue(ClaimTypes.Name);

            //Returning Buildings
            HttpClient buildingClient = new HttpClient();
            var responseBuilding = buildingClient.GetStringAsync("https://rest-api-burroughs.herokuapp.com/api/buildings/" + userName + "/customer").GetAwaiter().GetResult();

            List<Building> buildingList = JsonConvert.DeserializeObject<List<Building>>(responseBuilding);

            var buildingId = buildingList[0].id;

            ViewBag.building = buildingList;


            //Returning Batteries
            HttpClient batteryClient = new HttpClient();
            var responseBattery = batteryClient.GetStringAsync("https://rest-api-burroughs.herokuapp.com/api/batteries/find-batteries/" + buildingId).GetAwaiter().GetResult();

            List<Battery> batteryList = JsonConvert.DeserializeObject<List<Battery>>(responseBattery);

            var batteryId = batteryList[0].id;

            ViewBag.battery = batteryList;


            //Returning Columns
            HttpClient columnClient = new HttpClient();
            var responseColumn = columnClient.GetStringAsync("https://rest-api-burroughs.herokuapp.com/api/columns/find-columns/" + batteryId).GetAwaiter().GetResult();

            List<Column> columnList = JsonConvert.DeserializeObject<List<Column>>(responseColumn);


            ViewBag.column = columnList;

            //Returning Elevators
            var i = 0;
            List<Elevator> elevatorList = new List<Elevator>();

            foreach (var column in columnList)
            {
                var columnId = columnList[i].id;

                HttpClient elevatorClient = new HttpClient();
                var responseElevator = elevatorClient.GetStringAsync("https://rest-api-burroughs.herokuapp.com/api/elevators/find-elevators/" + columnId).GetAwaiter().GetResult();

                var newElevators = JsonConvert.DeserializeObject<List<Elevator>>(responseElevator);

                foreach (var elevator in newElevators)
                {

                    elevatorList.Add(elevator);

                }

                i++;

            }

            ViewBag.elevator = elevatorList;

            return View();
        }
    }
}
