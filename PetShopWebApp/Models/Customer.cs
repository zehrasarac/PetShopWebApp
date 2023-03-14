using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopWebApp.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [ MaxLength(30)]
        public string FirstName { get; set; }
        [ MaxLength(30)]
        public string LastName { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [StringLength(24, MinimumLength = 8)]
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
