using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[ApiController] // viktig for validering og swagger
[Route("api/[controller]")] // gir deg: api/athlete
public class AthleteController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AthleteController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/athlete
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Athlete>>> GetAll()
    {
        var athletes = await _context.Athletes.ToListAsync();
        return Ok(athletes);
    }

    // GET: api/athlete/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Athlete>> GetById(int id)
    {
        var athlete = await _context.Athletes.FindAsync(id);

        if (athlete == null)
            return NotFound();

        return Ok(athlete);
    }

    // GET: api/athlete/byname?name=Messi
    [HttpGet("byname")]
    public async Task<ActionResult<IEnumerable<Athlete>>> GetByName([FromQuery] string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return BadRequest("Name must be provided.");

        var athletes = await _context.Athletes
            .Where(a => a.Name.Contains(name))
            .ToListAsync();

        return Ok(athletes);
    }

    // POST: api/athlete
    [HttpPost]
    public async Task<ActionResult<Athlete>> Create(Athlete athlete)
    {
        // Ved registrering skal PurchaseStatus være false
        athlete.PurchaseStatus = false;

        _context.Athletes.Add(athlete);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = athlete.Id }, athlete);
    }

    // PUT: api/athlete/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Athlete updatedAthlete)
    {
        if (id != updatedAthlete.Id)
            return BadRequest("Id in URL does not match body.");

        _context.Entry(updatedAthlete).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            bool exists = await _context.Athletes.AnyAsync(a => a.Id == id);
            if (!exists)
                return NotFound();

            throw;
        }

        return NoContent();
    }

    // DELETE: api/athlete/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var athlete = await _context.Athletes.FindAsync(id);

        if (athlete == null)
            return NotFound();

        _context.Athletes.Remove(athlete);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
