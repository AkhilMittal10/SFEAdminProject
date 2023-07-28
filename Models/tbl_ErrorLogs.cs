using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SfeAdminPortal.Models
{
    public class tbl_ErrorLogs
    {
       [Key]
        public int ErrorID { get; set; }
        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public string ErrorMessage { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}
