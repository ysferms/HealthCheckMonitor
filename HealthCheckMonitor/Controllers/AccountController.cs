using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HealthCheckMonitor.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace HealthCheckMonitor.Controllers
{
  public class AccountController : Controller
  {
    [HttpGet]
    public IActionResult Login()
    {
      return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginModel loginModel)
    {
      if (LoginUser(loginModel.Username, loginModel.Password))
      {
        var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.Username)
            };

        var userIdentity = new ClaimsIdentity(claims, "login");

        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
       await  HttpContext.SignInAsync(principal);


        return RedirectToAction(nameof(HomeController.Index),"Home");

      }
      return View();
    }
    [HttpPost]
    public async Task<IActionResult> LogOut()
    {
      await HttpContext.SignOutAsync();
 

      return RedirectToAction("Login", "Account");
    }

    private bool LoginUser(string username, string password)
    {

      if (username == "cagatay" && password == "123")
      {
        return true;
      }
      else
      {
        return false;
      }

    }
  }
}
