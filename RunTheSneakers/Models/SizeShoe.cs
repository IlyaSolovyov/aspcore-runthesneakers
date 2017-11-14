using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class SizeShoe : Size
    {
        public string ShoeSize { get; set; }
    }
}
