using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class PublisherClass
    {
        [Key]
        public int idPublisher { get; set; }
        [Required, MaxLength(128), Index("IX_Publisher", 1, IsUnique = true)]
        public string city { get; set; }
        [Required, MaxLength(128), Index("IX_Publisher",0,IsUnique =true)]
        public string name { get; set; }
        public virtual List<BookClass> Books { get; set; }

        public PublisherClass() {
            Books = new List<BookClass>();
        }

        public override string ToString()
        {
            return city.First() + ":"+name;
        }
    }
}
