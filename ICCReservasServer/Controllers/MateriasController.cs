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
using ICCReservasServer.Interfaces;
using ICCReservasServer.DTOs;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : Controller
    {
        private readonly IUnitOfWork _uow;

        public MateriasController(IUnitOfWork uow)
        {
            this._uow = uow;
        }

        // GET: Materias
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            var materias = await _uow.MateriasRepository.Index();
            var materiaDTO = from materia in materias
                             select new MateriasDTO
                                 {
                                     ID = materia.ID,
                                     Codigo = materia.Codigo,
                                     Nivel = materia.Nivel,
                                     Grado = materia.Grado,
                                     Nombre = materia.Nombre,
                                     Descripcion = materia.Descripcion,
                                     Status = materia.Status
                                 };

            return Ok(materiaDTO);
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

            var materia = await _uow.MateriasRepository.Details(id);
            if (materia == null)
            {
                return NotFound();
            }

            var materiaDTO = new MateriasDTO { 
                ID = materia.ID,
                Codigo = materia.Codigo,
                Nivel = materia.Nivel,
                Grado = materia.Grado,
                Nombre = materia.Nombre,
                Descripcion = materia.Descripcion,
                Status = materia.Status
            };

            return Ok(materiaDTO);
        }

        // POST: Materias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[Authorize]
        [Route("Create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MateriasDTO materiasDTO)
        {
            if (ModelState.IsValid)
            {
                var materia = new Materias
                {
                    ID = materiasDTO.ID,
                    Codigo = materiasDTO.Codigo,
                    Nivel = materiasDTO.Nivel,
                    Grado = materiasDTO.Grado,
                    Nombre = materiasDTO.Nombre,
                    Descripcion = materiasDTO.Descripcion,
                    Status = materiasDTO.Status
                };

                _uow.MateriasRepository.Create(materia);
                return Ok(await _uow.SaveAsync());
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
        public async Task<IActionResult> Edit(int id, MateriasDTO materiasDTO)
        {
            if (ModelState.IsValid)
            {
                var materia = new Materias
                {
                    ID = materiasDTO.ID,
                    Codigo = materiasDTO.Codigo,
                    Nivel = materiasDTO.Nivel,
                    Grado = materiasDTO.Grado,
                    Nombre = materiasDTO.Nombre,
                    Descripcion = materiasDTO.Descripcion,
                    Status = materiasDTO.Status
                };

                try
                {
                    _uow.MateriasRepository.Edit(materia);
                    return Ok(await _uow.SaveAsync());
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_uow.MateriasRepository.MateriasExists(materia.ID))
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
            _uow.MateriasRepository.DeleteConfirmed(id);
            return Ok(await _uow.SaveAsync());
        }

    }
}
