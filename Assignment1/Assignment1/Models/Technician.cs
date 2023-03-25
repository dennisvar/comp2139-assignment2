using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Technician
    {
        [Key]
        [Required(ErrorMessage = "Name is required")]
        public int TechnicianId { get; set; }
        public string Name  { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(51, ErrorMessage = "Must be 1 - 51 character.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-##-####}")]
        public string Phone { get; set; }

    }
}
