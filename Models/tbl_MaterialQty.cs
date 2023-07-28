using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SfeAdminPortal.Models
{
    public class tbl_MaterialQty
    {
        [Key]
        public int MaterialID { get; set; }
        public int Quantity { get; set; }
    }
}
