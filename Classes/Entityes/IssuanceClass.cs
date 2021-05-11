﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class IssuanceClass
    {
        [Key]
        public int idIssuance { get; set; }
        [Required]
        public virtual TrainessClass trainess { get; set; }
        [Required]
        public virtual BookClass book { get; set; }
        [Required]
        public virtual UserClass user { get; set; }
        [Required]
        public DateTime date_of_issue { get; set; }

        public IssuanceClass()
        {
            user = new List<UserClass>();
        }
    }
}