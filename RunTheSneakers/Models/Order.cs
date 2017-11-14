using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunTheSneakers.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int DeliveryMethodId { get; set; }

        public ApplicationUser User { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public List<OrderItem> OrderItems { get; set; }

      
    }
}
