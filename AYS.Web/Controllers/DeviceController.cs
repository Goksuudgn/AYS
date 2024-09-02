using AYS.Data;
using AYS.Models;
using Microsoft.AspNetCore.Mvc;

namespace AYS.Web.Controllers
{
    public class DeviceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeviceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll(int categoryId) //belli kategorideki deviceları getirsin hepsini değil 
        {
            var result = _context.Devices.Where(d => d.CategoryId == categoryId && !d.IsDeleted);
            return Json(new { data = result });
        }
        [HttpPost]
        public IActionResult Add(Device device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();
            return Ok(device);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Device device = _context.Devices.Find(id);
            device.IsDeleted = true;
            _context.Devices.Update(device);
            _context.SaveChanges();
            return Ok(device);
        }
        [HttpPost]
        public IActionResult HardDelete(int id)
        {
            Device device = _context.Devices.Find(id);
            _context.Devices.Remove(device);
            _context.SaveChanges();
            return Ok(device);
        }
        [HttpPost]
        public IActionResult Uptade(Device device)
        {
            _context.Devices.Update(device);
            _context.SaveChanges();
            return Ok(device);
        }
    }
}

