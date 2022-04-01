using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shelter.Models;
using System.Linq;

namespace Shelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MonkeysController : ControllerBase
  {
    private readonly ShelterContext _db;

    public MonkeysController(ShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Monkey>>> Get(string name, int minAge, string gender)
    {
      var query = _db.Monkeys.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
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
    public async Task<ActionResult<Monkey>> Post(Monkey monkey)
    {
      _db.Monkeys.Add(monkey);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = monkey.MonkeyId }, monkey);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Monkey>> GetMonkey(int id)
    {
      var monkey = await _db.Monkeys.FindAsync(id);

      if (monkey == null)
      {
        return NotFound();
      }

      return monkey;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Monkey monkey)
    {
      if (id != monkey.MonkeyId)
      {
        return BadRequest();
      }

      _db.Entry(monkey).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!MonkeyExists(id))
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

    private bool MonkeyExists(int id)
    {
      return _db.Monkeys.Any(e => e.MonkeyId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMonkey(int id)
    {
      var monkey = await _db.Monkeys.FindAsync(id);
      
      if (monkey == null)
      {
        return NotFound();
      }

      _db.Monkeys.Remove(monkey);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }

  [ApiVersion("2.0")]
  [Route("api/{v:apiVersion}/monkeys")]
  [ApiController]
  public class MonkeysV2Controller : ControllerBase
  {
    private readonly ShelterContext _db;

    public MonkeysV2Controller(ShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Monkey>>> Get(string name, int minAge, string gender)
    {
      var query = _db.Monkeys.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
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
    public async Task<ActionResult<Monkey>> Post(Monkey monkey)
    {
      _db.Monkeys.Add(monkey);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = monkey.MonkeyId }, monkey);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Monkey>> GetMonkey(int id)
    {
      var monkey = await _db.Monkeys.FindAsync(id);

      if (monkey == null)
      {
        return NotFound();
      }

      return monkey;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Monkey monkey)
    {
      if (id != monkey.MonkeyId)
      {
        return BadRequest();
      }

      _db.Entry(monkey).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!MonkeyExists(id))
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

    private bool MonkeyExists(int id)
    {
      return _db.Monkeys.Any(e => e.MonkeyId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMonkey(int id)
    {
      var monkey = await _db.Monkeys.FindAsync(id);
      
      if (monkey == null)
      {
        return NotFound();
      }

      _db.Monkeys.Remove(monkey);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}