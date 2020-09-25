using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.Models
{
    [Table("Transaction")]
   public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public Users Users { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        public TransactionStatus Status { get; set; }

    }
    public enum TransactionStatus
    {
        Success,Failed
    }
}
		

