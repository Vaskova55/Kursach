using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class UserClass
    {
        [Key]
        public int idUser { get; set; }

        [Required, MaxLength(128)]
        public string family_name { get; set; }

        [Required, MaxLength(128)]
        public string first_name { get; set; }

        [Required]
        public int access_level { get; set; }

        [Required, MaxLength(128)]
        public string login { get; set; }

        [Required, MaxLength(128)]
        public string password { get; set; }

        public virtual List<IssuanceClass> issuance { get; set; }

        public UserClass()
        {
            issuance = new List<IssuanceClass>();
        }
    }
}
