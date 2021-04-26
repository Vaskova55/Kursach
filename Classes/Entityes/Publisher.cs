﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class Publisher
    {
        [Key]
        public int idPublisher { get; set; }
        [Required, MaxLength(128)]
        public string city { get; set; }
        [Required, MaxLength(128), Index(IsUnique =true)]
        public string name { get; set; }
        public virtual List<Book> Books { get; set; }

        public Publisher() {
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return city.First() + ":"+name;
        }
    }
}
