﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class ProductColor
    {
        public int ProductId { get; set; }
        public int ColorId { get; set; }

        public Product Product { get; set; }
        public Color Color { get; set; }
    }
}
