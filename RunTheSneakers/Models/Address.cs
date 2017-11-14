using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Building { get; set; }
        public int Apartment { get; set; }
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
