using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class AuthorClass
    {
        [Key]
        public int idAuthor { get; set; }
        [Required, MaxLength(128)]
        public string family_name { get; set; }
        [Required, MaxLength(128)]
        public string first_name { get; set; }
        [MaxLength(128)]
        public string middle_name { get; set; }
        public List<BookClass> Books { get; set; }

        public AuthorClass() {
            Books = new List<BookClass>();
        }

        public override string ToString()
        {
            return family_name + " " + first_name.First() + "." + middle_name.First() + ".";
        }

    }
}
