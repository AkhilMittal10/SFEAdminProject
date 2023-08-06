using System;
using System.ComponentModel.DataAnnotations;

namespace SfeAdminPortal.Models
{
    public class tbl_MaterialPO
    {
        [Key]
        public int ID { get; set; }
        public int MaterialID { get; set; }
        public int Quantity { get; set; }
        public decimal PerPiecePrice { get; set; }
        public decimal POTotal { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
