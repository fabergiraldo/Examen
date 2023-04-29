using Examen.API.DATA;
using Examen.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Examen.API.Controllers
{
    [ApiController]
    [Route("/api/boletos")]

    public class BoletosController : ControllerBase
    {
        private readonly DataContext _context;

        public BoletosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
          return Ok(await _context.boletos.ToListAsync());
         }

        [HttpPost]
        public async Task<ActionResult> Post(Boleto boleto)
        {
            _context.Add(boleto);
            await _context.SaveChangesAsync();
            return Ok(boleto);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var boleto = await _context.boletos.FirstOrDefaultAsync(x => x.Id == id);
            if (boleto is null)
            {
                return NotFound();
            }

            return Ok(boleto);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Boleto boleto)
        {
            _context.Update(boleto);
            await _context.SaveChangesAsync();
            return Ok(boleto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows = await _context.boletos
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (afectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}

