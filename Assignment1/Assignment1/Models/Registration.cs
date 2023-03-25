using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Registration
    {

        public int CustomerId { get; set; }
        public Customer  Customers { get; set; }

        public int ProductId { get; set; }

        public Product Products { get; set; }

    }
}
