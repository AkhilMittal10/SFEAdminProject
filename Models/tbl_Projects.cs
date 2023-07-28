using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SfeAdminPortal.Models
{
    public class tbl_Projects
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ClientName { get; set; }
        public string ProjectCity { get; set; }
        public string ProjectState { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectZip { get; set; }
    }
}
