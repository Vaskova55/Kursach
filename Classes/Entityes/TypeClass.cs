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
        public virtual List<BookClass> Books { get; set; }
        public TypeClass() {
            Books = new List<BookClass>();
        }
        public override string ToString()
        {
            return type;
        }
    }
}
