#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entities.Data;
using Entities.Models;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : Controller
    {
        private readonly ApplicationDataContext _context;

        public MateriasController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: Materias
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            return Ok(await _context.Materias.ToListAsync());
        }

        // GET: Materias/Details/5
        [HttpGet]
        //[Authorize]
        [Route("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materias = await _context.Materias
                .FirstOrDefaultAsync(m => m.ID == id);
            if (materias == null)
            {
                return NotFound();
            }

            return Ok(materias);
        }

        // POST: Materias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[Authorize]
        [Route("Create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Codigo,Nombre,Grado,Nivel,Descripcion,Status")] Materias materias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materias);
                var result = await _context.SaveChangesAsync();
                return Ok(result);
            }
            else
                return BadRequest(new { code = "MateriaNotCreated", message = "Error: no se pudo crear la materia." });
        }

        // PUT: Materias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        [Route("Edit/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Codigo,Nombre,Grado,Nivel,Descripcion,Status")] Materias materias)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materias);
                    var result = await _context.SaveChangesAsync();
                    return Ok(result);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MateriasExists(materias.ID))
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

        // DELETE: Materias/Delete/5
        [HttpDelete]
        //[Authorize]
        [Route("Delete/{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materias = await _context.Materias.FindAsync(id);
            _context.Materias.Remove(materias);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }

        private bool MateriasExists(int id)
        {
            return _context.Materias.Any(e => e.ID == id);
        }
    }
}
