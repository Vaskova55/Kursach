using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class Author
    {
        [Key]
        public int idAuthor { get; set; }
        [Required, MaxLength(128)]
        public string family_name { get; set; }
        [Required, MaxLength(128)]
        public string first_name { get; set; }
        [Required, MaxLength(128)]
        public string middle_name { get; set; }
        public List<Book> Books { get; set; }

        public Author() {
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return family_name + " " + first_name.First() + "." + middle_name.First() + ".";
        }

    }
}
