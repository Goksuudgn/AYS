using AYS.Business.Abstract;
using AYS.Data;
using AYS.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AYS.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            User appUser = _context.Users.FirstOrDefault(u => u.Name == user.Name && u.Email == user.Email && u.Password == user.Password);
            if ((appUser != null))
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, appUser.Id.ToString()));
                claims.Add(new Claim(ClaimTypes.Name, appUser.Name));
                claims.Add(new Claim(ClaimTypes.Email, appUser.Email));

                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(new ClaimsPrincipal(identity));
                return RedirectToAction("Index , Home");

            }
            else
            {
                return View();
            }

        }

        [HttpPost]
        public IActionResult Add(User user)
        {
          _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            //SOFT DELETE
            User user = _context.Users.Find(id);
            user.IsDeleted = true;
            _context.Users.Update(user);
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult GetAll()
        {
            var result=_context.Users.Where(u => u.IsDeleted == false).ToList();
            return Json(new { data = result });
        }

    }
}
//Ana sayfa login ekleme güncelleme silme listeleme
