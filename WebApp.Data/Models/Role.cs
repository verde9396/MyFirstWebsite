using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.Models
{
    [Table("Role")]
    public class Role
    {
       
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
