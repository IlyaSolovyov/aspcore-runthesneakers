using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class Deal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public bool isActive()
        {
            return ((Start <= DateTime.Now) && (DateTime.Now <= End));
        }

        public List<Discount> Discounts { get; set; }

        public Deal()
        {
            Discounts = new List<Discount>();
        }
    }
}
