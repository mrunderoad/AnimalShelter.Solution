using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shelter.Models;
using System.Linq;
using System;

namespace Shelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogParksController : ControllerBase
  {
    private readonly ShelterContext _db;

    public DogParksController(ShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DogPark>>> Get(string name)
    {
      var query = _db.DogParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<DogPark>> Post(DogPark dogPark)
    {
      _db.DogParks.Add(dogPark);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = dogPark.DogParkId }, dogPark);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DogPark>> GetDogPark(int id)
    {
      var dogPark = await _db.DogParks.FindAsync(id);

      if (dogPark == null)
      {
        return NotFound();
      }

      return dogPark;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, DogPark dogPark)
    {
      if (id != dogPark.DogParkId)
      {
        return BadRequest();
      }

      _db.Entry(dogPark).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DogParkExists(id))
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

    private bool DogParkExists(int id)
    {
      return _db.DogParks.Any(e => e.DogParkId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDogPark(int id)
    {
      var dogPark = await _db.DogParks.FindAsync(id);
      
      if (dogPark == null)
      {
        return NotFound();
      }

      _db.DogParks.Remove(dogPark);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }

  [ApiVersion("2.0")]
  [Route("api/{v:apiVersion}/dogparks")]
  [ApiController]
  public class DogParksV2Controller : ControllerBase
  {
    private readonly ShelterContext _db;

    public DogParksV2Controller(ShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DogPark>>> Get(string name)
    {
      var query = _db.DogParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<DogPark>> Post(DogPark dogPark)
    {
      _db.DogParks.Add(dogPark);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = dogPark.DogParkId }, dogPark);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DogPark>> GetDogPark(int id)
    {
      var dogPark = await _db.DogParks.FindAsync(id);

      if (dogPark == null)
      {
        return NotFound();
      }

      return dogPark;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, DogPark dogPark)
    {
      if (id != dogPark.DogParkId)
      {
        return BadRequest();
      }

      _db.Entry(dogPark).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DogParkExists(id))
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

    private bool DogParkExists(int id)
    {
      return _db.DogParks.Any(e => e.DogParkId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDogPark(int id)
    {
      var dogPark = await _db.DogParks.FindAsync(id);
      
      if (dogPark == null)
      {
        return NotFound();
      }

      _db.DogParks.Remove(dogPark);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}