using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VenueController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public VenueController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/venue
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Venue>>> GetAll()
    {
        var venues = await _context.Venues.ToListAsync();
        return Ok(venues);
    }

    // GET: api/venue/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Venue>> GetById(int id)
    {
        var venue = await _context.Venues.FindAsync(id);

        if (venue == null)
            return NotFound();

        return Ok(venue);
    }

    // GET: api/venue/byname?name=Arena
    [HttpGet("byname")]
    public async Task<ActionResult<IEnumerable<Venue>>> GetByName([FromQuery] string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return BadRequest("Name must be provided.");

        var venues = await _context.Venues
            .Where(v => v.Name.Contains(name))
            .ToListAsync();

        return Ok(venues);
    }

    // POST: api/venue
    [HttpPost]
    public async Task<ActionResult<Venue>> Create(Venue venue)
    {
        _context.Venues.Add(venue);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = venue.Id }, venue);
    }

    // PUT: api/venue/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Venue updatedVenue)
    {
        if (id != updatedVenue.Id)
            return BadRequest("Id in URL does not match body.");

        _context.Entry(updatedVenue).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            bool exists = await _context.Venues.AnyAsync(v => v.Id == id);
            if (!exists)
                return NotFound();

            throw;
        }

        return NoContent();
    }

    // DELETE: api/venue/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var venue = await _context.Venues.FindAsync(id);

        if (venue == null)
            return NotFound();

        _context.Venues.Remove(venue);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
