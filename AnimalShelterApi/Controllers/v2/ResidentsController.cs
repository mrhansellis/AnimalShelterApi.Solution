using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;


namespace AnimalShelterApi.Controllers.v2
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("2.0")]

  public class ResidentsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public ResidentsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    //get api/v2/residents
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Resident>>> Get(string name, string species, string sex, bool? chipped, DateTime? admissionDate, int pageNumber = 1, int pageSize = 5)
    {
      IQueryable<Resident> query = _db.Residents.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if (sex != null)
      {
        query = query.Where(entry => entry.Sex == sex);
      }

      if (chipped != null)
      {
        query = query.Where(entry => entry.Chipped == chipped);
      }

      if (admissionDate != null)
      {
        query = query.Where(entry => entry.AdmissionDate == admissionDate);
      }

      int skip = (pageNumber -1) * pageSize;

      return await query.Skip(skip).Take(pageSize).ToListAsync();
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

    [HttpPost]
    public async Task<ActionResult<Resident>> Post(Resident resident)
    {
      resident.AdmissionDate = DateTime.Today;
      _db.Residents.Add(resident);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetResident), new { id = resident.ResidentId }, resident);
    }

    //PUT: api/v2/Residents/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Resident resident)
    {
      if (id != resident.ResidentId)
      {
        return BadRequest();
      }

      _db.Residents.Update(resident);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if(!ResidentExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool ResidentExists(int id)
    {
      return _db.Residents.Any(e => e.ResidentId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMessage(int id)
    {
      Resident resident = await _db.Residents.FindAsync(id);
      if (resident == null)
      {
        return NotFound();
      }

      _db.Residents.Remove(resident);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}