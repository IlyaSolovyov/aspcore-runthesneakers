using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public abstract class Size
    {
        [Required]
        public int Id { get; set; }

        public virtual List<ProductSize> ProductSizes { get; set; }
       
        public Size()
        {
            ProductSizes = new List<ProductSize>();
        }
    }
}
