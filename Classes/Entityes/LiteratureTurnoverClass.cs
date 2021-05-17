using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class LiteratureTurnoverClass
    {
        public enum e_literature_state:sbyte{ 
            storage,
            issuance,
            remove
        };

        [Key]
        public int idTurnover { get; set; }
        [Required, Index(IsUnique = true), MaxLength(32)]
        public string InventiryNum { get; set; }
        [Required]
        public Int16 year { get; set; }
        [Required]
        public virtual BookClass book { get; set; }
        [Required]
        public virtual PurchaseAccountingClass purchaseAccounting { get; set; }
        [Required]
        public e_literature_state status { get; set; }
        public override string ToString()
        {
            return book.ToString();
        }
    }
}
