namespace Assignment1.Models
{
    public class IncidentViewModel
    {
        public List<Incident> IncidentModel { get; set; } 
        public List<Customer> CustomerModel { get; set; }
        public List<Product> ProductModel { get; set; }
        public List<Technician> TechnicianModel { get; set; }
        public int IncidentId { get; set; }



    }
}
