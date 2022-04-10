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
    public class DispositivosController : Controller
    {
        private readonly ApplicationDataContext _context;

        public DispositivosController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: Dispositivos
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            return Ok(await _context.Dispositivos.ToListAsync());
        }

        // GET: Dispositivos/Details/5
        [HttpGet]
        //[Authorize]
        [Route("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dispositivo = await _context.Dispositivos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dispositivo == null)
            {
                return NotFound();
            }

            return Ok(dispositivo);
        }

        // POST: Dispositivos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[Authorize]
        [Route("Create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Tipo,Descripcion,Marca,Modelo,Serial,Status")] Dispositivos dispositivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dispositivo);
                var result = await _context.SaveChangesAsync();
                return Ok(result);
            }
            else
                return BadRequest(new { code = "InstalacionNotCreated", message = "Error: no se pudo crear la instalación." });
        }

        // PUT: Dispositivos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        [Route("Edit/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Tipo,Descripcion,Marca,Modelo,Serial,Status")] Dispositivos dispositivo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dispositivo);
                    var result = await _context.SaveChangesAsync();
                    return Ok(result);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DispositivosExists(id))
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

        // DELETE: Dispositivos/Delete/5
        [HttpDelete]
        //[Authorize]
        [Route("Delete/{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dispositivo = await _context.Dispositivos.FindAsync(id);
            _context.Dispositivos.Remove(dispositivo);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }

        private bool DispositivosExists(int id)
        {
            return _context.Dispositivos.Any(e => e.ID == id);
        }
    }
}
