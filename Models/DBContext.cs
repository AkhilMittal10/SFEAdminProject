
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SfeAdminPortal.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<tbl_Projects> tbl_Projects{ get; set; }
        public DbSet<tbl_ResourceMaster> tbl_ResourceMaster{ get; set; }
        public DbSet<tbl_ProjectResources> tbl_ProjectResources { get; set; }
        public DbSet<tbl_MaterialMaster> tbl_MaterialMaster { get; set; }
        public DbSet<tbl_MaterialQty> tbl_MaterialQty { get; set; }
        public DbSet<tbl_ErrorLogs> tbl_ErrorLogs { get; set; }



    }
}
