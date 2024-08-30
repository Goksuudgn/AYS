using Microsoft.AspNetCore.Mvc;

namespace AYS.Web.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
