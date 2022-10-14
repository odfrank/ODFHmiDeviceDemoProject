using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HmiDeviceProject.Models;
using HmiDeviceProject.Data;

namespace HmiDeviceProject.Controllers
{
    public class StaffsController : Controller
    {

        private readonly AppDbContext _db;


        private readonly ILogger<StaffsController> _logger;

        public StaffsController(ILogger<StaffsController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;   
        }

        public IActionResult Index()
        {
            // var dbStaffList = _db.Staffs.ToList();

            IEnumerable<StaffsModel> dbStaffList = _db.Staffs;
            return View(dbStaffList);
        }

        //GET
        public IActionResult AddStaff()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStaff(StaffsModel staffObj)
        {
            if(ModelState.IsValid)
            {
                _db.Staffs.Add(staffObj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(staffObj);
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

};
