using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class DiscountByBrand: Discount
    {
        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}
