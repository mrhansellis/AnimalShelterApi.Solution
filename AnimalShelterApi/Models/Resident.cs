namespace AnimalShelterApi.Models
{
  public class Resident
  {
    public int ResidentId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public string Sex { get; set; }
    public bool Chipped { get; set; }
    public DateTime AdmissionDate { get; set; }
    public string Notes { get; set; }
  }
}