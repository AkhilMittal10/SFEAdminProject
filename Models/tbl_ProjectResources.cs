using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SfeAdminPortal.Models
{

    public class tbl_ProjectResources
    {
            [Key]
            public int ID { get; set; }
            public string ProjectName { get; set; }
            public int ProjectID { get; set; }
            public string ResourceName { get; set; }
            public int ResourceID { get; set; }
           
    }
}
