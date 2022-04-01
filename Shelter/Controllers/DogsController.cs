using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shelter.Models;
using System.Linq;
using System;

namespace Shelter.Controllers
{
  [Route("api/dogs")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private readonly ShelterContext _db;

    public DogsController(ShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dog>>> Get(string name, string breed, int minAge, string gender)
    {
      var query = _db.Dogs.AsQueryable();

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

    [HttpGet("random")]
    public async Task<ActionResult<Dog>> GetRandomDog()
    {
      var rand = new Random();
      var count = await _db.Dogs.CountAsync();
      var next = rand.Next(count);
      var randD = await _db.Dogs.Skip(next).FirstOrDefaultAsync();

      return randD;
    }

    [HttpPost]
    public async Task<ActionResult<Dog>> Post(Dog dog)
    {
      _db.Dogs.Add(dog);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = dog.DogId }, dog);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Dog>> GetDog(int id)
    {
      var dog = await _db.Dogs.FindAsync(id);

      if (dog == null)
      {
        return NotFound();
      }

      return dog;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Dog dog)
    {
      if (id != dog.DogId)
      {
        return BadRequest();
      }

      _db.Entry(dog).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DogExists(id))
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

    private bool DogExists(int id)
    {
      return _db.Dogs.Any(e => e.DogId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDog(int id)
    {
      var dog = await _db.Dogs.FindAsync(id);
      
      if (dog == null)
      {
        return NotFound();
      }

      _db.Dogs.Remove(dog);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }

  [ApiVersion("2.0")]
  [Route("api/{v:apiVersion}/dogs")]
  [ApiController]
  public class DogsV2Controller : ControllerBase
  {
    private readonly ShelterContext _db;

    public DogsV2Controller(ShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dog>>> Get(string name, string breed, int minAge, string gender)
    {
      var query = _db.Dogs.AsQueryable();

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

    [HttpGet("random")]
    public async Task<ActionResult<Dog>> GetRandomDog()
    {
      var rand = new Random();
      var count = await _db.Dogs.CountAsync();
      var next = rand.Next(count);
      var randD = await _db.Dogs.Skip(next).FirstOrDefaultAsync();

      return randD;
    }

    [HttpPost]
    public async Task<ActionResult<Dog>> Post(Dog dog)
    {
      _db.Dogs.Add(dog);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = dog.DogId }, dog);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Dog>> GetDog(int id)
    {
      var dog = await _db.Dogs.FindAsync(id);

      if (dog == null)
      {
        return NotFound();
      }

      return dog;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Dog dog)
    {
      if (id != dog.DogId)
      {
        return BadRequest();
      }

      _db.Entry(dog).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DogExists(id))
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

    private bool DogExists(int id)
    {
      return _db.Dogs.Any(e => e.DogId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDog(int id)
    {
      var dog = await _db.Dogs.FindAsync(id);
      
      if (dog == null)
      {
        return NotFound();
      }

      _db.Dogs.Remove(dog);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}