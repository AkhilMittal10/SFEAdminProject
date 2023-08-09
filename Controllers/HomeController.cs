using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SfeAdminPortal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SfeAdminPortal.Controllers
{
    [Authorize(Roles = "NormalUser,AdminUser")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBContext _context;

        public HomeController(ILogger<HomeController> logger, DBContext context)
        {
            _logger = logger;
            _context = context;
        }

        //[Route("/Main/")]
        //[Route("")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewProject()
        {
            return View();
        }
        public IActionResult ResourceManagement()
        {
            return View();
        }
        public IActionResult AddNewResource()
        {
            return View();
        }

        public IActionResult ProjectManagement()
        {
            return View();
        }
        public IActionResult SaveProject()
        {
            string ProjectName = Request.Form["ProjectName"];
            string ClientName = Request.Form["ClientName"];
            string ProjectCity = Request.Form["ProjectCity"];
            string ProjectState = Request.Form["ProjectState"];
            string ProjectAddress = Request.Form["ProjectAddress"];
            string ProjectZip = Request.Form["ProjectZip"];

            tbl_Projects tbl = new tbl_Projects();
            tbl.ProjectName = ProjectName;
            tbl.ClientName = ClientName;
            tbl.ProjectCity = ProjectCity;
            tbl.ProjectState = ProjectState;
            tbl.ProjectAddress = ProjectAddress;
            tbl.ProjectZip = ProjectZip;

            _context.tbl_Projects.Add(tbl);
            _context.SaveChanges();



            return View("AddNewProject");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult EmployeePartialView()
        {
            return View();
        }
        public IActionResult AddResourceSalaryDetails()
        {
            var ResourceList = _context.tbl_ResourceMaster.ToList();
            ViewBag.Resourcedetails = ResourceList;

             List<tbl_ResourceSalaryDetails> obj1=new List<tbl_ResourceSalaryDetails>();
            obj1=_context.tbl_ResourceSalaryDetails.ToList();
            return View(obj1);
        }

        public IActionResult SaveResourceSalaryDetails()
        {
            int Resourceid = Convert.ToInt32(Request.Form["ResourceList"]);
            int MonthlySalary = Convert.ToInt32(Request.Form["MonthlySalary"]);
            int YearlySalary = Convert.ToInt32(Request.Form["YearlySalary"]);
            int TDS = Convert.ToInt32(Request.Form["TDS"]);
            int EPF = Convert.ToInt32(Request.Form["EPF"]);
            int Bonus = Convert.ToInt32(Request.Form["Bonus"]);

            tbl_ResourceSalaryDetails obj = new tbl_ResourceSalaryDetails();
            obj.ResourceID = Resourceid;
            obj.MonthlySalary = MonthlySalary;
            obj.YearlySalary = YearlySalary;
            obj.TDS = TDS;
            obj.EPF = EPF;
            obj.Bonus = Bonus;
            _context.tbl_ResourceSalaryDetails.Add(obj);
            _context.SaveChanges();

            return RedirectToAction("AddResourceSalaryDetails");
        }
        //public IActionResult Updatelist(string resourceId)
        //{
        //    //var updatelist = _context.tbl_ResourceSalaryDetails.Where(x => x.ResourceID == Convert.ToInt16(resourceId)).FirstOrDefault();
        //    return View();
        //}

    }
}