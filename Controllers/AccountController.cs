using Microsoft.AspNetCore.Mvc;

namespace SfeAdminPortal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
