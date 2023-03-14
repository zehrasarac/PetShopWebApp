using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopWebApp.Models.Entities
{
    [Table("CartItems")]
    public class CartItem
    {
        [Key]
        public int CartItemID { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
    }

}
