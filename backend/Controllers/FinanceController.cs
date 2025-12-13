using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FinanceController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public FinanceController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/finance
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Finance>>> GetAll()
    {
        var finances = await _context.Finances.ToListAsync();
        return Ok(finances);
    }

    // GET: api/finance/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Finance>> GetById(int id)
    {
        var finance = await _context.Finances.FindAsync(id);

        if (finance == null)
            return NotFound();

        return Ok(finance);
    }

    // POST: api/finance
    // Brukes egentlig bare én gang for å sette opp startverdier
    [HttpPost]
    public async Task<ActionResult<Finance>> Create(Finance finance)
    {
        _context.Finances.Add(finance);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = finance.Id }, finance);
    }

    // PUT: api/finance/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Finance updatedFinance)
    {
        if (id != updatedFinance.Id)
            return BadRequest("Id in URL does not match body.");

        _context.Entry(updatedFinance).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            bool exists = await _context.Finances.AnyAsync(f => f.Id == id);
            if (!exists)
                return NotFound();

            throw;
        }

        return NoContent();
    }

    // POST: api/finance/loan
    // Body: { "amount": 5000 }
    public class LoanRequest
    {
        public decimal Amount { get; set; }
    }

    [HttpPost("loan")]
    public async Task<IActionResult> TakeLoan([FromBody] LoanRequest request)
    {
        if (request.Amount <= 0)
            return BadRequest("Amount must be positive.");

        // siden Finance i praksis bare har 1 rad:
        var finance = await _context.Finances.FirstOrDefaultAsync();

        if (finance == null)
            return NotFound("Finance row not found.");

        finance.MoneyLeft += request.Amount;

        _context.Finances.Update(finance);
        await _context.SaveChangesAsync();

        return Ok(finance);
    }
}
