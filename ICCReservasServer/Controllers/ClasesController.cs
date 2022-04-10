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
    public class ClasesController : Controller
    {
        private readonly ApplicationDataContext _context;

        public ClasesController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: Clases
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            var applicationDataContext = _context.Clases.Include(c => c.Horario).Include(c => c.Materia).Include(c => c.User);
            return Ok(await applicationDataContext.ToListAsync());
        }

        // GET: Clases/Details/5
        [HttpGet]
        //[Authorize]
        [Route("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clases = await _context.Clases
                .Include(c => c.Horario)
                .Include(c => c.Materia)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (clases == null)
            {
                return NotFound();
            }

            return View(clases);
        }

        // POST: Clases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[Authorize]
        [Route("Create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,HorarioID,MateriaID,UserID")] Clases clases)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clases);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HorarioID"] = new SelectList(_context.Horarios, "ID", "HoraFin", clases.HorarioID);
            ViewData["MateriaID"] = new SelectList(_context.Materias, "ID", "Codigo", clases.MateriaID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", clases.UserID);
            return View(clases);
        }

        // PUT: Clases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        [Route("Edit/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,HorarioID,MateriaID,UserID")] Clases clases)
        {
            if (id != clases.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clases);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClasesExists(clases.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["HorarioID"] = new SelectList(_context.Horarios, "ID", "HoraFin", clases.HorarioID);
            ViewData["MateriaID"] = new SelectList(_context.Materias, "ID", "Codigo", clases.MateriaID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", clases.UserID);
            return View(clases);
        }

        // DELETE: Clases/Delete/5
        [HttpDelete]
        //[Authorize]
        [Route("Delete/{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clases = await _context.Clases.FindAsync(id);
            _context.Clases.Remove(clases);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClasesExists(int id)
        {
            return _context.Clases.Any(e => e.ID == id);
        }
    }
}
