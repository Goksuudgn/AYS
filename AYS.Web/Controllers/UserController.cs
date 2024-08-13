using AYS.Business.Abstract;
using AYS.Models;
using Microsoft.AspNetCore.Mvc;

namespace AYS.Web.Controllers
{
    //public class UserController : Controller
    //{
    //    private readonly IUserService _userService;

    //    public UserController(IUserService userService)
    //    {
    //        _userService = userService;
    //    }

    //    [HttpGet]
    //    public IActionResult Login()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public IActionResult Login(LoginViewModel model)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var user = _userService.ValidateUser(model.UserName, model.Password);
    //            if (user != null)
    //            {
    //                // Kullanıcı doğrulandı, oturum aç
    //                // Session veya Cookie ayarları yapılabilir
    //                return RedirectToAction("Index", "Home");
    //            }
    //            ModelState.AddModelError("", "Invalid login attempt.");
    //        }
    //        return View(model);
    //    }

    //    [HttpGet]
    //    public IActionResult Register()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    //public IActionResult Register(RegisterViewModel model)
    //    //{
    //    //    if (ModelState.IsValid)
    //    //    {
    //    //        var user = new User
    //    //        {
    //    //            Name = model.UserName,
    //    //            Password = model.Password // Not: Parola hashlenerek saklanmalı
    //    //        };
    //    //        _userService.RegisterUser(user);
    //    //        return RedirectToAction("Login");
    //    //    }
    //    //    return View(model);
    //    //}

    //    public IActionResult Logout()
    //    {
    //        // Oturumu kapat
    //        return RedirectToAction("Login");
    //    }
    //}
}

