using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;

namespace SfeAdminPortal.Controllers
{
    public class HRMSController : Controller
    {
        private readonly DBContext _context;
        public HRMSController(DBContext dBContext)
        {
            _context = dBContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
