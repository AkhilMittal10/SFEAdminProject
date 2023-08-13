using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SfeAdminPortal.Controllers
{
    [Route("api/ProjectAPI/")]
    [ApiController]
    public class ProjectAPIController : ControllerBase
    {
        private readonly DBContext _context;
        public ProjectAPIController(DBContext Mycontext)
        {
            _context = Mycontext;
        }

        [HttpGet]
        [Route("GetMaterialPOData")]
        public IEnumerable<tbl_MaterialPO> GetMaterialPOData()
        {
            List<tbl_MaterialPO> list= new List<tbl_MaterialPO>();
            list = _context.tbl_MaterialPO.ToList();
            return list;
        }

        [HttpPost]
        [Route("AddNewMaterial")]
        public string AddNewMaterial(string materialName)
        {
            tbl_MaterialMaster material = new tbl_MaterialMaster();
            material.MaterialName = materialName;
            var instertedRecord = _context.tbl_MaterialMaster.Add(material);
            _context.SaveChanges();

            return "Material ID:" + instertedRecord.Entity.MaterialID + " Added Sucessfully!!";
        }

        [HttpPost]
        [Route("UpdateMaterial")]
        public string UpdateMaterial(int MaterialID,string MaterialName)
        {
            var material = _context.tbl_MaterialMaster.Where(x => x.MaterialID == MaterialID).FirstOrDefault();
            material.MaterialName = MaterialName;
            _context.SaveChanges();
            return "Material Updated Sucessfully!!";
            
        }


        [HttpPost]
        [Route("DeleteMaterial")]
        public string DeleteMaterial(int MaterialID)
        {
            var material = _context.tbl_MaterialMaster.Where(x => x.MaterialID == MaterialID).FirstOrDefault();
            _context.tbl_MaterialMaster.Remove(material);
            _context.SaveChanges();
            return "Material Deleted Sucessfully!!";
        }



    }
}
