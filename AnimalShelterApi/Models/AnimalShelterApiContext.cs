using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Resident> Residents { get; set; }
    
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

  }
}