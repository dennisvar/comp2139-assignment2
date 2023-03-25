using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage="First Name is required")]
        [StringLength(51, ErrorMessage = "Must be 1 - 51 character.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(51, ErrorMessage = "Must be 1 - 51 character.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(51, ErrorMessage = "Must be 1 - 51 character.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(51, ErrorMessage = "Must be 1 - 51 character.")]
        public string City { get; set; }

        [Required(ErrorMessage = "State/Province is required")]
        [DisplayName("State/Province")]
        [StringLength(51, ErrorMessage = "Must be 1 - 51 character.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [StringLength(21, ErrorMessage = "Invalid Postal Code. Must be 1 - 21 character.")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(51, ErrorMessage = "Must be 1 - 51 character.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-##-####}")]
        public string Phone { get; set; }

    }
}
