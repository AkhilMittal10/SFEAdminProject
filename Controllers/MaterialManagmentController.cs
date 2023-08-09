using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SfeAdminPortal.Controllers
{
    [Authorize(Roles = "AdminUser,NormalUser")]
    public class MaterialManagmentController : Controller
    {
        private readonly DBContext _context;
        private readonly DBContext _contextLogs;

        public MaterialManagmentController(DBContext context, DBContext context2)
        {
            _context = context;
            _contextLogs = context2;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "AdminUser")]
        public IActionResult AddMaterialMasterDetails()
        {

            return View();
        }
        public IActionResult Savematerial()
        {
            try
            {
                var MaterialNm = Request.Form["MaterialName"];
                int QuantityNm = Convert.ToInt32(Request.Form["Quantity"]);

                tbl_MaterialMaster obj1 = new tbl_MaterialMaster();
                obj1.MaterialName = MaterialNm;
                var insertedItem1 = _context.tbl_MaterialMaster.Add(obj1);
                _context.SaveChanges();
                int iMaterialID = insertedItem1.Entity.MaterialID;

                tbl_MaterialQty obj2 = new tbl_MaterialQty();
                obj2.Quantity = QuantityNm;
                obj2.MaterialID = iMaterialID;
                _context.tbl_MaterialQty.Add(obj2);
                _context.SaveChanges();

                return View("AddMaterialMasterDetails");
            }
            catch (Exception e)
            {
                tbl_ErrorLogs tbl_Error = new tbl_ErrorLogs();
                tbl_Error.ControllerName = "MaterialManagmentController";
                tbl_Error.ActionName = "Savematerial";
                tbl_Error.ErrorMessage = e.Message;
                tbl_Error.CreatedDateTime = DateTime.Now;
                _contextLogs.tbl_ErrorLogs.Add(tbl_Error);
                _contextLogs.SaveChanges();

                TempData["errormessage"] = "Some thing went wrong";
                return View("AddMaterialMasterDetails");
            }

        }

        public IActionResult UpdateMaterial()
        {
            string MaterialNam = Request.Form["MaterialName"];
            int MaterialQuan = Convert.ToInt32(Request.Form["Quantity"]);

            int MaterialID = _context.tbl_MaterialMaster.Where(s => s.MaterialName == MaterialNam).Select(x=>x.MaterialID).FirstOrDefault();

            var MaterialQtyRecord = _context.tbl_MaterialQty.Where(s => s.MaterialID == MaterialID).FirstOrDefault();
            MaterialQtyRecord.Quantity = MaterialQuan;
            _context.SaveChanges();

            return View("AddMaterialMasterDetails");
        }

        public IActionResult TestLinq()
        {
            // Select Queries

            var selectAllQuery = _context.tbl_MaterialMaster.ToList();

            var selectParticularQuery = _context.tbl_MaterialMaster.Where(x => x.MaterialID == 15).ToList();

            var SingleRecordQuery = _context.tbl_MaterialMaster.Where(x => x.MaterialID == 15).FirstOrDefault();

            var OrderByDescQuery = _context.tbl_MaterialMaster.OrderByDescending(x => x.MaterialID).ToList();


            // Insert Queries
            // SaveChanges method only used for Insert, Update & Delete Queries

            // Single Record Insert Query
            tbl_MaterialMaster material = new tbl_MaterialMaster();
            material.MaterialName = "Silver Plate";
            _context.tbl_MaterialMaster.Add(material);
            _context.SaveChanges();


            //Single Record Insert with Return of Inserted Record Query
            tbl_MaterialMaster material1 = new tbl_MaterialMaster();
            material1.MaterialName = "Diamond Ring";
            var insertedRecord = _context.tbl_MaterialMaster.Add(material1);
            _context.SaveChanges();
            int MatId = insertedRecord.Entity.MaterialID;
            string MatName = insertedRecord.Entity.MaterialName;

            // Delete Query

            var deleteRecord = _context.tbl_MaterialMaster.Where(x => x.MaterialID == 14).FirstOrDefault();
            _context.tbl_MaterialMaster.Remove(deleteRecord);
            _context.SaveChanges();


            // Update Query

            var updateRecord = _context.tbl_MaterialMaster.Where(x => x.MaterialID == 2).FirstOrDefault();
            updateRecord.MaterialName = "Silver Brick";
            _context.SaveChanges();

            return View("AddMaterialMasterDetails");
        }
    }
}
