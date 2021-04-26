using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class TypeClass
    {
        [Key]
        public int idType { get; set; }
        [Required, MaxLength(128), Index(IsUnique = true)]
        public string type { get; set; }
        public virtual List<Book> Books { get; set; }
        public TypeClass() {
            Books = new List<Book>();
        }
        public override string ToString()
        {
            return type;
        }
    }
}
