using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebApp.Data.Models
{
    [Table("OrderDetails")]
   public class OrderDetails
    {
        [Key]
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("UserId")]
        public Users Users { get; set; }
        public decimal Price { get; set; }

    }
}
