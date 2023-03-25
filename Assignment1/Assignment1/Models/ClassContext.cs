using Microsoft.EntityFrameworkCore;

namespace Assignment1.Models
{
    public class ClassContext : DbContext
    {
        public ClassContext(DbContextOptions<ClassContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Incident> Incidents { get; set; }

        public DbSet<Country> Countries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { ProductId = 1,
                              Code = "TRNY10", 
                              Name = "Tournament Master 1.0",
                              Price = 4.99,
                              ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 2,
                    Code = "LEAG10",
                    Name = "League Scheduler 1.0",
                    Price = 4.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 3,
                    Code = "LEAG10",
                    Name = "League Scheduler Deluxe 1.0",
                    Price = 7.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 4,
                    Code = "DRAFT10",
                    Name = "Draft Manager 1.0",
                    Price = 4.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 5,
                    Code = "TEAM10",
                    Name = "Team Manager 1.0",
                    Price = 4.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 6,
                    Code = "TRNY20",
                    Name = "Tournament Master 2.0",
                    Price = 5.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 7,
                    Code = "DRAFT20",
                    Name = "Draft Manager 2.0",
                    Price = 5.99,
                    ReleaseDate = DateTime.Now
                }
                );

            modelBuilder.Entity<Technician>().HasData(
                new Technician { TechnicianId = 1,
                                 Name = "Alison Diaz",
                                 Email = "alison@sportsprosoftware.com",
                                 Phone = "800-555-0443"
                },
                new Technician
                {
                    TechnicianId = 2,
                    Name = "Andrew Wilson",
                    Email = "awilson@sportsprosoftware.com",
                    Phone = "800-555-0449"
                },
                new Technician
                {
                    TechnicianId = 3,
                    Name = "Gina Fiori",
                    Email = "gfiori@sportsprosoftware.com",
                    Phone = "800-555-0459"
                },
                new Technician
                {
                    TechnicianId = 4,
                    Name = "Gunter Wendt",
                    Email = "gunter@sportsprosoftware.com",
                    Phone = "800-555-0400"
                },
                new Technician
                {
                    TechnicianId = 5,
                    Name = "Jason Lee",
                    Email = "jason@sportsprosoftware.com",
                    Phone = "800-555-0445"
                }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1,
                               FirstName = "Kaitlyn",
                               LastName = "Anthoni",
                               Address = "",
                               City = "San Francisco",
                               State = "",
                               PostalCode = "",
                               Country = "",
                               Email = "kanthoni@pge.com",
                               Phone = ""
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Ania ",
                    LastName = "Irvin",
                    Address = "",
                    City = "Washington",
                    State = "",
                    PostalCode = "",
                    Country = "",
                    Email = "ania@mma.midc.com",  
                    Phone = ""
                },
                new Customer
                {
                    CustomerId = 3,
                    FirstName = "Gonzalo",
                    LastName = "Keeton",
                    Address = "",
                    City = "Mission Viejo",
                    State = "",
                    PostalCode = "",
                    Country = "",
                    Email = "",
                    Phone = ""
                },
                new Customer
                {
                    CustomerId = 4,
                    FirstName = "Anton",
                    LastName = "Mauro",
                    Address = "",
                    City = "Sacramento",
                    State = "",
                    PostalCode = "",
                    Country = "",
                    Email = "amauro@yahoo.com",
                    Phone = ""
                },
                new Customer
                {
                    CustomerId = 5,
                    FirstName = "Kendall",
                    LastName = "Mayte",
                    Address = "",
                    City = "Fresno",
                    State = "",
                    PostalCode = "",
                    Country = "",
                    Email = "knayte@fresno.ca.gov",
                    Phone = ""
                },
                new Customer
                {
                    CustomerId = 6,
                    FirstName = "Kenzie",
                    LastName = "Quinn",
                    Address = "",
                    City = "Los Angeles",
                    State = "",
                    PostalCode = "",
                    Country = "",
                    Email = "kenzie@mma.jobtrak.com",
                    Phone = ""
                },
                new Customer
                {
                    CustomerId = 7,
                    FirstName = "Marvin",
                    LastName = "Quintin",
                    Address = "",
                    City = "Fresno",
                    State = "",
                    PostalCode = "",
                    Country = "",
                    Email = "marvin@expedata.com",
                    Phone = ""
                }
                );

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, CountryName = "Canada"},
                new Country { CountryId = 2, CountryName = "China" },
                new Country { CountryId = 3, CountryName = "USA" },
                new Country { CountryId = 4, CountryName = "France" },
                new Country { CountryId = 5, CountryName = "Spain" },
                new Country { CountryId = 6, CountryName = "Sweden" }
                );

            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    IncidentId = 1,
                    CustomerId = 5,
                    ProductId = 4,
                    Title = "Could not install",
                    Description = "",
                    TechnicianId = 1,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now
                },
                new Incident
                {
                    IncidentId = 2,
                    CustomerId = 3,
                    ProductId = 1,
                    Title = "Could not install",
                    Description = "",
                    TechnicianId = 1,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now
                },
                new Incident
                {
                    IncidentId = 3,
                    CustomerId = 2,
                    ProductId = 3,
                    Title = "Error importing data",
                    Description = "",
                    TechnicianId = 1,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now
                },
                new Incident
                {
                    IncidentId = 4,
                    CustomerId = 5,
                    ProductId = 3,
                    Title = "Error launching program",
                    Description = "",
                    TechnicianId = 1,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now
                }
                );

            modelBuilder.Entity<Registration>().HasKey(r => new {r.CustomerId, r.ProductId});
/*            modelBuilder.Entity<Registration>()
                .HasOne(b => b.Customers).WithMany(b => b.Regs)
                .HasForeignKey(b => b.CustomerId);
            modelBuilder.Entity<Registration>()
                .HasOne(b => b.Products).WithMany(b => b.Regs)
                .HasForeignKey(b => b.ProductId);*/
        }

    }
}   
