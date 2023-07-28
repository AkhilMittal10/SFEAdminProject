using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SfeAdminPortal.Controllers
{
    public class ResouceMasterController : Controller
    {
        private readonly DBContext _context;

        public ResouceMasterController(DBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AssignResource()
        {
            try
            {
                var resourceId = Convert.ToInt32(Request.Form["Resources"].ToString());
                var filterresult = _context.tbl_ProjectResources.Where(s => s.ResourceID == resourceId).ToList();
                if (filterresult.Count > 0)
                {
                    TempData["message"] = "this Resource is already exist";
                    return RedirectToAction("ResourceAssignment");
                }

                var projectId = Convert.ToInt32(Request.Form["ProjectList"].ToString());
                tbl_ProjectResources obj1 = new tbl_ProjectResources();
                obj1.ResourceID = resourceId;
                obj1.ProjectID = projectId;
                _context.tbl_ProjectResources.Add(obj1);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("ResourceAssignment");
            }

            return RedirectToAction("ResourceAssignment");
        }
        public IActionResult ResourceAssignment()
        {
            List<tbl_ResourceMaster> list_resources = new List<tbl_ResourceMaster>();
            list_resources = _context.tbl_ResourceMaster.ToList();
            ViewBag.ResourcesList = list_resources;

            List<tbl_Projects> List_Project = new List<tbl_Projects>();
            List_Project = _context.tbl_Projects.ToList();
            ViewBag.ProjectList = List_Project;

            return View();
        }
        public IActionResult SaveResourceMaster()
        {
            try
            {
                string ResourceName = Request.Form["ResourceName"];
                string ResourceType = Request.Form["ResourceType"];
                string Address = Request.Form["Address"];
                string Email = Request.Form["Email"];
                string PhoneNo = Request.Form["PhoneNo"];
                decimal Salary = Convert.ToDecimal(Request.Form["Salary"]);

                tbl_ResourceMaster tbl = new tbl_ResourceMaster();
                tbl.ResourcName = ResourceName;
                tbl.ResourceType = ResourceType;
                tbl.Address = Address;
                tbl.Email = Email;
                tbl.PhoneNo = PhoneNo;
                tbl.Salary = Salary;

                _context.tbl_ResourceMaster.Add(tbl);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                TempData["Message1"] = ex.Message;
            }

            return RedirectToAction("AddNewResource", "Home");
        }
    }
}
