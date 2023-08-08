using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;
using System.Linq;
using System;
using System.Collections.Generic;

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
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}
