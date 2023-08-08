using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SfeAdminPortal.Controllers
{
    [Route("api/APIController")]
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

        [Route("api/GetProjectResource")]
        [HttpGet]
        public IEnumerable<tbl_ProjectResources> GetProjectResource()
        {
            List<tbl_ProjectResources> res = new List<tbl_ProjectResources>();
            res = _context.tbl_ProjectResources.ToList();
            return res;
        }
             

    }
}
