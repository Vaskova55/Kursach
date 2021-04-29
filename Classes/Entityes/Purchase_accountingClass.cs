using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class Purchase_accountingClass
    {
        [Key]
        public int idPurchase_accounting { get; set; }
        [Required]
        public decimal price { get; set; }
        [Required]
        public int count { get; set; }
    }
}
