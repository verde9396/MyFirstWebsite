
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)] 
        public string UserName { get; set; }
        [Required]
        
        public string Email { get; set; }
        public DateTime  DOB { get; set; }
        [Required]
        public string Password { get; set; }

        public bool  UserState { get; set; }
        public string Gender { get; set; }



    }
    
}
