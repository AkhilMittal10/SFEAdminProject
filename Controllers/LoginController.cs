using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace SfeAdminPortal.Controllers
{
    public class LoginController : Controller
    {
        private readonly DBContext _context;
        public LoginController(DBContext Mycontext)
        {
            _context = Mycontext;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult LoginSubmit()
        {
            string Name = Request.Form["email"];
            string Pass = Request.Form["Psw"];
            Users tbl = new Users();
            tbl=_context.Users.Where(s => s.UserName == Name && s.Password == Pass).FirstOrDefault();
            if(tbl==null)
            {
                TempData["Message"]="Invalid User Credentials!";
                return RedirectToAction("Login");
            }
            else
            {
                //Create the identity for the user  
                ClaimsIdentity identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, Name),
                    new Claim(ClaimTypes.Role, tbl.Roles)
                    }, CookieAuthenticationDefaults.AuthenticationScheme);

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}
