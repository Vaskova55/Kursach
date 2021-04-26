using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class Book
    {
        [Key]
        public int idBook { get; set; }
        [Required]
        public int classnum { get; set; }
        [Required]
        public virtual TypeClass type { get; set; }
        [Required, MaxLength(128)]
        public string name_book { get; set; }
        [Required]
        public virtual Publisher publisher { get; set; }
        public virtual List<Author> Authors { get; set; }
        [Required]
        public Int16 publishing_year { get; set; }

        public Book() {
            Authors = new List<Author>();
        }

    }
}
