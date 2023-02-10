using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers.v1
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]

  public class ResidentsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public ResidentsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    //get api/v1/residents
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Resident>>> Get()
    {
      return await _db.Residents.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Resident>> GetResident(int id)
    {
      Resident resident = await _db.Residents.FindAsync(id);

      if (resident == null)
      {
        return NotFound();
      }

      return resident;
    }
  }
}