using Microsoft.AspNetCore.Mvc;
using SfeAdminPortal.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace SfeAdminPortal.Controllers
{
    [Route("api/DemoAPI/")]
    [Authorize]
    [ApiController]
    public class DemoAPIController : ControllerBase
    {
        private readonly DBContext _context;
        public DemoAPIController(DBContext Mycontext)
        {
            _context = Mycontext;
        }

        [HttpGet]
        [Authorize(Roles = "AdminUser")]
        [Route("GetProjectResource/")]
        public IEnumerable<tbl_MaterialMaster> GetProjectResource()
        {
            List<tbl_MaterialMaster> res = new List<tbl_MaterialMaster>();
            res = _context.tbl_MaterialMaster.ToList();
            return res;
        }
    }
}
