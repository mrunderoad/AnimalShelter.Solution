using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shelter.Models;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Shelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private readonly ShelterContext _db;

    public CatsController(ShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cat>>> Get(string name, string breed, int minAge, string gender)
    {
      var query = _db.Cats.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (minAge > 0)
      {
        query = query.Where(entry => entry.Age >= minAge);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Cat>> Post(Cat cat)
    {
      _db.Cats.Add(cat);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = cat.CatId }, cat);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Cat>> GetCat(int id)
    {
      var cat = await _db.Cats.FindAsync(id);

      if (cat == null)
      {
        return NotFound();
      }

      return cat;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Cat cat)
    {
      if (id != cat.CatId)
      {
        return BadRequest();
      }

      _db.Entry(cat).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CatExists(id))
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

    private bool CatExists(int id)
    {
      return _db.Cats.Any(e => e.CatId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCat(int id)
    {
      var cat = await _db.Cats.FindAsync(id);
      
      if (cat == null)
      {
        return NotFound();
      }

      _db.Cats.Remove(cat);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }


  [ApiVersion("2.0")]
  [Route("api/[controller]")]
  [ApiController]
  public class CatsV2Controller : ControllerBase
  {
    private readonly ShelterContext _db;

    public CatsV2Controller(ShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cat>>> Get(string name, string breed, int minAge, string gender)
    {
      var query = _db.Cats.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (minAge > 0)
      {
        query = query.Where(entry => entry.Age >= minAge);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      return await query.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Cat>> Post(Cat cat)
    {
      _db.Cats.Add(cat);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = cat.CatId }, cat);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Cat>> GetCat(int id)
    {
      var cat = await _db.Cats.FindAsync(id);

      if (cat == null)
      {
        return NotFound();
      }

      return cat;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Cat cat)
    {
      if (id != cat.CatId)
      {
        return BadRequest();
      }

      _db.Entry(cat).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CatExists(id))
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

    private bool CatExists(int id)
    {
      return _db.Cats.Any(e => e.CatId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCat(int id)
    {
      var cat = await _db.Cats.FindAsync(id);
      
      if (cat == null)
      {
        return NotFound();
      }

      _db.Cats.Remove(cat);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}