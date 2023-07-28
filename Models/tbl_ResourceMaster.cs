using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SfeAdminPortal.Models
{
    public class tbl_ResourceMaster
    {
        [Key]
        public int ResourceID { get; set; }
        public string ResourcName { get; set; }
        public string ResourceType { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public decimal Salary { get; set; }

    }
}
