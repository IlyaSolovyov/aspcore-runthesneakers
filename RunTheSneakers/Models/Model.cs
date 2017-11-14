using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public Brand Brand { get; set; } 
        public List<Product> Products { get; set; }

        public Model()
        {
            Products = new List<Product>();
        }

    }
}
