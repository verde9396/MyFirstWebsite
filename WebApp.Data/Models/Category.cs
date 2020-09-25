using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApp.Data.Models
{
    [Table("Category")]
   public class Category
    {
        [Key]
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string CateName { get; set; }
        public Product Product { get; set; }

    }
}
