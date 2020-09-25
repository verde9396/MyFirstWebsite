using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebApp.Data.Models
{
    [Table("Cart")]
   public class Cart
    {
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Users Users { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
