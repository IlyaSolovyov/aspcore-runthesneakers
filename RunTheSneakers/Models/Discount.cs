using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public abstract class Discount
    {
        [Key]
        public int Id { get; set; }
        public int Percentage { get; set; }
        public int? DealId { get; set; }

        public Deal Deal { get; set; }
        
    }
}
