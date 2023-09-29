using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SfeAdminPortal.Controllers
{
    [Route("api/API/")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly DBContext _context;
        public APIController(DBContext Mycontext)
        {
            _context = Mycontext;
        }

        [HttpGet]
        public IEnumerable<tbl_ResourceMaster> Get()
        {
            List<tbl_ResourceMaster> res = new List<tbl_ResourceMaster>();
            res = _context.tbl_ResourceMaster.ToList();
            return res;
        }

        
        [HttpGet]
        [Route("GetProjectResource/")]
        public IEnumerable<tbl_MaterialMaster> GetProjectResource()
        {
            List<tbl_MaterialMaster> res = new List<tbl_MaterialMaster>();
            res = _context.tbl_MaterialMaster.ToList();
            return res;
        }

        [HttpPost]
        [Route("AddMaterialMaster/")]
        public string AddMaterialMaster(string materialName)
        {
            tbl_MaterialMaster material = new tbl_MaterialMaster();
            material.MaterialName = materialName;
            _context.tbl_MaterialMaster.Add(material);
            _context.SaveChanges();

            return "Material Added Sucessfully!!";
        }


    }
}
