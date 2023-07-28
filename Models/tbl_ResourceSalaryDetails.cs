using System.ComponentModel.DataAnnotations;
using System;

namespace SfeAdminPortal.Models
{
    public class tbl_ResourceSalaryDetails
    {
        [Key]
        public int ID { get; set; }
        public int ResourceID { get; set; }

        public int MonthlySalary { get; set; }

        public int YearlySalary { get; set; }

        public int TDS { get; set; }

        public int EPF { get; set; }
        public int Bonus { get; set; }

    }
}
