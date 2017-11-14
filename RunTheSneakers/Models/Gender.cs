﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public Gender()
        {
            Products = new List<Product>();
        }
    }
}
