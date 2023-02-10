using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Resident
  {
    public int ResidentId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Sex { get; set; }
    public bool Chipped { get; set; }
    public DateTime AdmissionDate { get; set; }
    public string Notes { get; set; }
  }
}