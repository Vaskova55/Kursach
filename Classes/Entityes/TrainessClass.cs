using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class TrainessClass
    {
        [Key]
        public int idTrainess { get; set; }
        [Required]
        public int classTrainess { get; set; }
        [Required, MaxLength(128)]
        public string family_name { get; set; }
        [Required, MaxLength(128)]
        public string first_name { get; set; }
        [MaxLength(128)]
        public string middle_name { get; set; }
        public virtual List<IssuanceClass> issuance { get; set; }

        public TrainessClass()
        {
            issuance = new List<IssuanceClass>();
        }
    }
}
