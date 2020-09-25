using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApp.Data.Models
{    [Table("Product")]
    public  class Product
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal OrginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public int SellCount { get; set; }
        public string Detail { get; set; }
        public string Description { get; set; }
    }
}
