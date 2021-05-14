using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class LiteratureTurnoverClass
    {
        [Key]
        public int idTurnover { get; set; }
        [Required]
        public Int16 year { get; set; }
        [Required]
        public virtual BookClass book { get; set; }
        public virtual PurchaseAccountingClass purchaseAccounting { get; set; }
        [Required]
        public int status { get; set; }
    }
}
