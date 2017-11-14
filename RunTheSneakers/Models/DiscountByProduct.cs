using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class DiscountByProduct : Discount
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
