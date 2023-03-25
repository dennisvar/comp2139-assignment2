using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Incident
    {
        [Key]
        public int IncidentId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime DateOpened  { get; set; }
        public DateTime? DateClosed { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int TechnicianId { get; set; }
        public Technician Technician { get; set; }
    }
}
