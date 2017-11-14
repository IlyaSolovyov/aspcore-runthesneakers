using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class SizeApparel : Size
    {
        public string ApparelSize { get; set; }
    }
}
