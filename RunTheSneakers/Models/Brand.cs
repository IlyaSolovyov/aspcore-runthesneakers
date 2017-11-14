using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandLogoUrl { get; set; }

     
        public List<DiscountByBrand> Discounts { get; set; }
        public List<Model> Models { get; set; }

        public Brand()
        {
            Discounts = new List<DiscountByBrand>();
            Models = new List<Model>();
        }
    }
}
