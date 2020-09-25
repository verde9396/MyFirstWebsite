using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApp.Data.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime  OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhoneNumber { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Total { get; set; }
        [ForeignKey("UserId")]
        public Users Users { get; set; }
    }
    public enum OrderStatus
    {
             InProgress
            ,Confirmed
            ,Shipping
            ,Sucess
            ,Canceled
    }
}
