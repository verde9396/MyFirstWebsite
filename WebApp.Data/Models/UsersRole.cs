
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Data.Models
{
    [Table("UserRole")]
  public   class UsersRole
    {
        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public Users Users { get; set; }
        public Role Role { get; set; }

    }
}
