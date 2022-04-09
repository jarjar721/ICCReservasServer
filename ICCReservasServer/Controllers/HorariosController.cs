#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ICCReservasServer.Data;
using ICCReservasServer.Models;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosController : Controller
    {
        private readonly ApplicationDataContext _context;

        public HorariosController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: Horarios
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            return Ok(await _context.Horarios.ToListAsync());
        }

        // GET: Horarios/Details/5
        [HttpGet]
        //[Authorize]
        [Route("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horarios = await _context.Horarios
                .FirstOrDefaultAsync(m => m.ID == id);
            if (horarios == null)
            {
                return NotFound();
            }

            return Ok(horarios);
        }

        // POST: Horarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[Authorize]
        [Route("Create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Numero,HoraInicio,HoraFin,Nivel")] Horarios horarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(horarios);
                var result = await _context.SaveChangesAsync();
                return Ok(result);
            }
            else
                return BadRequest(new { code = "HorarioNotCreated", message = "Error: no se pudo crear el horario." });
        }

        // PUT: Horarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        [Route("Edit/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Numero,HoraInicio,HoraFin,Nivel")] Horarios horarios)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(horarios);
                    var result = await _context.SaveChangesAsync();
                    return Ok(result);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorariosExists(horarios.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            else
                return BadRequest(new { code = "InvalidModelState", message = "Error: ModelState inválido." });

        }

        // DELETE: Horarios/Delete/5
        [HttpDelete]
        //[Authorize]
        [Route("Delete/{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var horarios = await _context.Horarios.FindAsync(id);
            _context.Horarios.Remove(horarios);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }

        private bool HorariosExists(int id)
        {
            return _context.Horarios.Any(e => e.ID == id);
        }
    }
}
