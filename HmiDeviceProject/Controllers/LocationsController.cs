using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HmiDeviceProject.Models;


namespace HmiDeviceProject.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ILogger<DevicesController> _logger;

        private List<LocationsViewModel> TempLocations = new List<LocationsViewModel>();

        public LocationsController(ILogger<DevicesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempLocations.Add(new LocationsViewModel() { Id = 1, Location = "Regina", CurrentTemperature = "5" });
            TempLocations.Add(new LocationsViewModel() { Id = 2, Location = "Calgary", CurrentTemperature = "20" });
            TempLocations.Add(new LocationsViewModel() { Id = 3, Location = "Edminton", CurrentTemperature = "16" });
            TempLocations.Add(new LocationsViewModel() { Id = 4, Location = "Toronto", CurrentTemperature = "31" });
            TempLocations.Add(new LocationsViewModel() { Id = 5, Location = "Saskatoon", CurrentTemperature = "12" });
            TempLocations.Add(new LocationsViewModel() { Id = 6, Location = "BritishColumbia", CurrentTemperature = "24" });
            TempLocations.Add(new LocationsViewModel() { Id = 7, Location = "HabourLanding", CurrentTemperature = "4" });

            return View(TempLocations);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

};

