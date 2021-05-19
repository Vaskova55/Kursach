using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class PurchaseListClass
    {
        [Key]
        public int idPurchaseList { get; set; }
        [Required]
        public DateTime datePurchase { get; set; }
        public virtual List<PurchaseAccountingClass> purchaseAccountings { get; set; }

        public PurchaseListClass()
        {
            purchaseAccountings = new List<PurchaseAccountingClass>();
        }
    }
}
