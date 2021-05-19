using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class PurchaseAccountingClass
    {
        [Key]
        public int idPurchase_accounting { get; set; }
        public decimal price { get; set; }
        [Required]
        public int count { get; set; }
        public virtual List<LiteratureTurnoverClass> literatureTurnover { get; set; }
        public virtual PurchaseListClass purchaseList { get; set; }

        public PurchaseAccountingClass()
        {
            literatureTurnover = new List<LiteratureTurnoverClass>();
        }
    }
}
