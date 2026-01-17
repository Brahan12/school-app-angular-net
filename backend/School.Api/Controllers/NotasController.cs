using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Api.Data;
using School.Api.DTOs;
using School.Api.Models;

namespace School.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotasController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public NotasController(SchoolDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var notas = await _context.Notas
                .Include(n => n.Estudiante)
                .Include(n => n.Profesor)
                .ToListAsync();

            return Ok(notas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNota(int id)
        {
            var nota = await _context.Notas
                .Include(n => n.Estudiante)
                .Include(n => n.Profesor)
                .FirstOrDefaultAsync(n => n.Id == id);

            if (nota == null)
                return NotFound();

            return Ok(nota);
        }

        [HttpPost]
        public async Task<ActionResult<Nota>> PostNota(NotaCreateDto dto)
        {
            var nota = new Nota
            {
                Nombre = dto.Nombre,
                IdProfesor = dto.IdProfesor,
                IdEstudiante = dto.IdEstudiante,
                Valor = dto.Valor
            };

            _context.Notas.Add(nota);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNota), new { id = nota.Id }, nota);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, NotaCreateDto dto)
        {
            var nota = await _context.Notas.FindAsync(id);
            if (nota == null)
                return NotFound();

            nota.Nombre = dto.Nombre;
            nota.IdProfesor = dto.IdProfesor;
            nota.IdEstudiante = dto.IdEstudiante;
            nota.Valor = dto.Valor;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var nota = await _context.Notas.FindAsync(id);
            if (nota == null)
                return NotFound();

            _context.Notas.Remove(nota);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
