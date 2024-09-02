using AYS.Data;
using AYS.Models;
using Microsoft.AspNetCore.Mvc;

namespace AYS.Web.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
		{
			return View();
		}
		public IActionResult GetAll()
		{
			var result = _context.Categories.ToList();
			return Json(new {data = result});	

		}
		[HttpPost]
		public IActionResult Add(Category category)
		{
			_context.Categories.Add(category);
			_context.SaveChanges();
			return Ok(category);
		}
		[HttpPost]
		public IActionResult Delete(int id)
		{
			//SOFT DELETE
			Category category = _context.Categories.Find(id);
			category.IsDeleted = true;
			_context.Categories.Update(category);
			_context.SaveChanges();
			return Ok(category);
		}
		[HttpPost]
		public IActionResult Uptade(Category category)
		{
			_context.Categories.Update(category);
			_context.SaveChanges();
			return Ok(category);
		}
	}

}
