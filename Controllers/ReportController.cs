using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OfficeOpenXml;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml.Style;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using SfeAdminPortal.MyExtensions;

namespace SfeAdminPortal.Controllers
{
    [Authorize(Roles = "AdminUser,NormalUser")]
    public class ReportController : Controller
    {
        private readonly DBContext _context;
        public ReportController(DBContext Mycontext)
        {
            _context = Mycontext;
        }

        [Route("/Report/ReportIndex/")]
        [Route("/Report/Index/")]
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.abc = "sss";
            ViewData["abc"] = "sss";
            TempData["abc"] = "sss";

            int ii = 10;
            int jj = 20;
            int k = ii.GetSmallerValue(jj);

            //var result = Generics.GetValue<int>(5);

            string[] strArray = new string[] { "Akhil", "Raj", "Ravi", "Rajesh" };
            
            
            return View();
        }
        public IActionResult Search()
        {
            string searchResource = Request.Form["searchResource"];
            string searchResourceType = Request.Form["searchResourceType"].ToString().ToLower();
            string strResourceType = "";

            if (searchResourceType == "worker")
            {
                strResourceType = "1";
            }
            if (searchResourceType == "staff")
            {
                strResourceType = "2";
            }
            if (searchResourceType == "foreman")
            {
                strResourceType = "3";
            }
            if (searchResourceType == "mechanical")
            {
                strResourceType = "4";
            }
            if (searchResourceType == "electrical")
            {
                strResourceType = "5";
            }

            List<tbl_ResourceMaster> res = new List<tbl_ResourceMaster>();
            //var filteredResult = studentList.Where(s => s.Age > 12 && s.Age < 20);
            res = _context.tbl_ResourceMaster.Where(s => s.ResourcName == searchResource || s.ResourceType == strResourceType).ToList();
            return View("ResourceDetailsrEport", res);
        }
        public IActionResult ResourceDetailsrEport()
        {
            List<tbl_ResourceMaster> obj = new List<tbl_ResourceMaster>();
            obj = _context.tbl_ResourceMaster.ToList();
            return View(obj);

        }
        public IActionResult DownloadReport()
        {
            List<tbl_ResourceMaster> obj = new List<tbl_ResourceMaster>();
            obj = _context.tbl_ResourceMaster.ToList();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage ep = new ExcelPackage();

            // Sheet1
            ExcelWorksheet sheet1 = ep.Workbook.Worksheets.Add("Report");
            sheet1.Cells["A1"].Value = "Resource Name";
            sheet1.Cells["B1"].Value = "Resource Type";
            sheet1.Cells["C1"].Value = "Address";
            sheet1.Cells["D1"].Value = "Email";
            sheet1.Cells["E1"].Value = "PhoneNo";
            sheet1.Cells["F1"].Value = "Salary";

            int row = 2;

            for (int i = 0; i < obj.Count(); i++)
            {
                sheet1.Cells["A" + row].Value = obj[i].ResourcName;
                sheet1.Cells["B" + row].Value = obj[i].ResourceType;
                sheet1.Cells["C" + row].Value = obj[i].Address;
                sheet1.Cells["D" + row].Value = obj[i].Email;
                sheet1.Cells["E" + row].Value = obj[i].PhoneNo;
                sheet1.Cells["F" + row].Value = obj[i].Salary;

                row++;
            }

            // Sheet2
            ExcelWorksheet sheet2 = ep.Workbook.Worksheets.Add("Demo");
            sheet2.Cells["A1"].Value = "Demo Header";
            sheet2.Cells["A1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet2.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);

            sheet2.Cells["A2"].Value = "Akhil";

            byte[] mybyteArray = ep.GetAsByteArray();

            return File(mybyteArray, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ResourceReport.xlsx");
        }
        public IActionResult MaterialDetailReport()
        {
            List<ViewMaterialDetailReport> lst = new List<ViewMaterialDetailReport>();

            lst = (from materialList in _context.tbl_MaterialMaster
                   join qty in _context.tbl_MaterialQty
                   on materialList.MaterialID equals qty.MaterialID
                   select new ViewMaterialDetailReport
                  {
                      MaterialID = materialList.MaterialID,
                      MaterialName = materialList.MaterialName,
                      Quantity = qty.Quantity
                  }).ToList();


            return View(lst);
        }
        public IActionResult MaterialPurchaseReport()
        {
           List<MaterialPurchaseModel> lst = new List<MaterialPurchaseModel>();
           lst = (from matPO in _context.tbl_MaterialPO
                  join OrdStatus in _context.tbl_OrderStatus on matPO.ID equals OrdStatus.POID
                  select new MaterialPurchaseModel
                  {
                      MaterialID = matPO.MaterialID,
                      Quantity = matPO.Quantity,
                      PerPiecePrice = matPO.PerPiecePrice,
                      POTotal = matPO.POTotal,
                      CreateDate = matPO.CreateDate,
                      Status = OrdStatus.Status,
                      TransactionType = OrdStatus.TransactionType
                  }).ToList();

           
            return View(lst);
        }
        public IActionResult Filter()
        {
            string strSearch = Request.Form["txtSearch"];

            List<MaterialPurchaseModel> lst = new List<MaterialPurchaseModel>();
            lst = (from matPO in _context.tbl_MaterialPO
                   join OrdStatus in _context.tbl_OrderStatus
                   on matPO.ID equals OrdStatus.POID
                   where (Convert.ToString(matPO.MaterialID) == strSearch || OrdStatus.Status == strSearch || OrdStatus.TransactionType == strSearch)
                   select new MaterialPurchaseModel
                   {
                       MaterialID = matPO.MaterialID,
                       Quantity = matPO.Quantity,
                       PerPiecePrice = matPO.PerPiecePrice,
                       POTotal = matPO.POTotal,
                       CreateDate = matPO.CreateDate,
                       Status = OrdStatus.Status,
                       TransactionType = OrdStatus.TransactionType
                   }).ToList();
          

            return View("MaterialPurchaseReport",lst);
        }
    }

}


