using AYS.Data;
using AYS.Models;
using Microsoft.AspNetCore.Mvc;

namespace AYS.Web.Controllers
{
    public class Home1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Home1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetAll()
        {
            var result = _context.Homes.ToList();
            return Json(new { data = result });
        }
        [HttpPost]
        public IActionResult Add(Home home)
        {
            _context.Homes.Add(home);
            _context.SaveChanges();
            return Ok(home);
        }
        [HttpPost]
        public IActionResult Update(Home home)
        {
           _context.Homes.Update(home);
            _context.SaveChanges();
            return Ok(home);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
                //SOFT DELETE
                Home home = _context.Homes.Find(id);
                home.IsDeleted = true;
                _context.Homes.Update(home);
                _context.SaveChanges();
                return Ok(home);
        }

    }
}
