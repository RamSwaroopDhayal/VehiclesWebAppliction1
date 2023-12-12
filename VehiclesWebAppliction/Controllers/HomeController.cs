using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VehiclesWebAppliction.Models;
using VehiclesWebAppliction.Services;

namespace VehiclesWebAppliction.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IVehicleService _vehicleService;
        public HomeController(IVehicleService vehicleService) 
        {
          _vehicleService = vehicleService;
        }
        public async Task<IActionResult> GetVehiclesList()
        {
            var response = await _vehicleService.VehicleList();
            return View(response);
        }
        public IActionResult AddVehicles()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddVehicles(VehiclesModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _vehicleService.AddVehicle(model);
                if (response != null)
                {
                    return RedirectToAction("GetVehiclesList", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Failed to add the vehicle. Please try again.");
                }
            }

            return RedirectToAction("AddVehicles", "Home");
        }
    }
}
