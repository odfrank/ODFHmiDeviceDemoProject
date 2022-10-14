using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HmiDeviceProject.Models;
using HmiDeviceProject.Data;


namespace HmiDeviceProject.Controllers;

public class DevicesController : Controller
{
    private readonly AppDbContext _db;

    private readonly ILogger<DevicesController> _logger;

    public DevicesController(ILogger<DevicesController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }


    public IActionResult Index()
    {
        IEnumerable<DevicesModel> dbDeviceList = _db.Devices;
        return View(dbDeviceList);
    }

    //GET
    public IActionResult AddDevice()
    {
        return View();
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddDevice(DevicesModel deviceObj)
    {
        if (ModelState.IsValid)
        {
            _db.Devices.Add(deviceObj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(deviceObj);

    }

    //GET
    public IActionResult RegulateDevice(int? id)
    {
        if(id == null || id==0)
        {
            return NotFound();
        }

        var deviceFromDb = _db.Devices.Find(id);

        if (deviceFromDb == null)
        {
            return NotFound();
        }
        return View(deviceFromDb);
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult RegulateDevice(DevicesModel deviceObj)
    {
        if (ModelState.IsValid)
        {
            _db.Devices.Update(deviceObj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(deviceObj);

    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
