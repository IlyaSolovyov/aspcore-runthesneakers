using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public abstract class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AdditionalDescription { get; set; }
        public int ModelId { get; set; }
        public int MaterialId { get; set; }
        public int GenderId { get; set; }
        [Column(TypeName = "Money")]
        public Decimal Price { get; set; }
   
        public Model Model { get; set; }
        public Material Material { get; set; }
        public Gender Gender { get; set; }

        public List<ProductPhoto> Photos { get; set; }
        public List<DiscountByProduct> Discounts { get; set; }
        public List<ProductColor> Colors { get; set; }
        public List<ProductSize>  Sizes { get; set; }

        public Product()
        {
            Photos = new List<ProductPhoto>();
            Discounts = new List<DiscountByProduct>();
            Colors = new List<ProductColor>();
            Sizes = new List<ProductSize>();
        }
    }
}
