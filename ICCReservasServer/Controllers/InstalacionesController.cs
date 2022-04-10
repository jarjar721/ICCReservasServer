#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entities.Data;
using Microsoft.AspNetCore.Authorization;
using ICCReservasServer.DTOs;
using Entities.Models;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstalacionesController : Controller
    {
        private readonly ApplicationDataContext _context;

        public InstalacionesController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: Instalaciones
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetAllInstalaciones()
        {
            return Ok(await _context.Instalaciones.ToListAsync());
        }

        // GET: Instalaciones/Details/5
        [HttpGet]
        //[Authorize]
        [Route("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instalacion = await _context.Instalaciones
                .FirstOrDefaultAsync(m => m.ID == id);
            if (instalacion == null)
            {
                return NotFound();
            }

            return Ok(instalacion);
        }

        // POST: Instalaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Codigo,Nombre,Tipo,Descripcion,Capacidad,Edificio,Piso,Status")] Instalaciones instalacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instalacion);
                var result = await _context.SaveChangesAsync();
                return Ok(result);
            }
            else
            {
                return BadRequest(new { code = "InstalacionNotCreated", message = "Error: no se pudo crear la instalación." });
            }
        }

        // PUT: Instalaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        [Route("Edit/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Codigo,Nombre,Tipo,Descripcion,Capacidad,Edificio,Piso,Status")] Instalaciones instalacion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instalacion);
                    var result = await _context.SaveChangesAsync();
                    return Ok(result);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstalacionesExists(id))
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
        
        // DELETE: Instalaciones/Delete/5
        [HttpDelete]
        [Route("Delete/{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instalacion = await _context.Instalaciones.FindAsync(id);
            _context.Instalaciones.Remove(instalacion);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }
        

        private bool InstalacionesExists(int id)
        {
            return _context.Instalaciones.Any(e => e.ID == id);
        }
    }
}
