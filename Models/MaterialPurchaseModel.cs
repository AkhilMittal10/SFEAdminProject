using System;

namespace SfeAdminPortal.Models
{
    public class MaterialPurchaseModel
    {
        public int MaterialID { get; set; }
        public int Quantity { get; set; }
        public decimal PerPiecePrice { get; set; }
        public decimal POTotal { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
        public string TransactionType { get; set; }

    }
}
