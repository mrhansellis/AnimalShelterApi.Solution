using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Resident> Residents { get; set; }
    
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Resident>()
        .HasData(
          new Resident { ResidentId = 1, Name = "Paul", Species = "Cat", Sex = "Male", Chipped = true, AdmissionDate = DateTime.Now, Notes = "Sunny Disposition" },
          new Resident { ResidentId = 2, Name = "Scruff", Species = "Dog", Sex = "Male", Chipped = false, AdmissionDate = DateTime.Now, Notes = "Does not like people" },
          new Resident { ResidentId = 3, Name = "Traci", Species = "Dog", Sex = "Female", Chipped = true, AdmissionDate = DateTime.Now, Notes = "I love this dog" }
        );
    }
  }
}