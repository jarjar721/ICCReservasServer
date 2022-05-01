using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Data;
using ICCReservasServer.DTOs;
using Entities.Models;
using ICCReservasServer.Interfaces;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstalacionesController : Controller
    {
        private readonly IUnitOfWork _uow;

        public InstalacionesController(IUnitOfWork uow)
        {
            this._uow = uow;
        }

        // GET: Instalaciones
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            var instalaciones = await _uow.InstalacionesRepository.Index();
            var instalacionDTO = from instalacion in instalaciones
                                 select new InstalacionesDTO
                                 {
                                  ID = instalacion.ID,
                                  Codigo = instalacion.Codigo,
                                  Nombre = instalacion.Nombre,
                                  Tipo = instalacion.Tipo,
                                  Descripcion = instalacion.Descripcion,
                                  Capacidad = instalacion.Capacidad,
                                  Edificio = instalacion.Edificio,
                                  Piso = instalacion.Piso,
                                  Status = instalacion.Status
                              };

            return Ok(instalacionDTO);
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

            var instalacion = await _uow.InstalacionesRepository.Details(id);
            if (instalacion == null)
            {
                return NotFound();
            }

            var instalacionDTO = new InstalacionesDTO {
                ID = instalacion.ID,
                Codigo = instalacion.Codigo,
                Tipo = instalacion.Tipo,
                Nombre = instalacion.Nombre,
                Capacidad = instalacion.Capacidad,
                Edificio = instalacion.Edificio,
                Piso = instalacion.Piso,
                Descripcion = instalacion.Descripcion,
                Status = instalacion.Status
            };

            return Ok(instalacionDTO);
        }

        // POST: Instalaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InstalacionesDTO instalacionDTO)
        {
            if (ModelState.IsValid)
            {
                var instalacion = new Instalaciones
                {
                    ID = instalacionDTO.ID,
                    Codigo = instalacionDTO.Codigo,
                    Nombre = instalacionDTO.Nombre,
                    Tipo = instalacionDTO.Tipo,
                    Descripcion = instalacionDTO.Descripcion,
                    Capacidad = instalacionDTO.Capacidad,
                    Edificio = instalacionDTO.Edificio,
                    Piso = instalacionDTO.Piso,
                    Status = instalacionDTO.Status
                };

                _uow.InstalacionesRepository.Create(instalacion);
                return Ok(await _uow.SaveAsync());
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
        public async Task<IActionResult> Edit(int id, InstalacionesDTO instalacionDTO)
        {
            if (ModelState.IsValid)
            {
                var instalacion = new Instalaciones
                {
                    ID = instalacionDTO.ID,
                    Codigo = instalacionDTO.Codigo,
                    Nombre = instalacionDTO.Nombre,
                    Tipo = instalacionDTO.Tipo,
                    Descripcion = instalacionDTO.Descripcion,
                    Capacidad = instalacionDTO.Capacidad,
                    Edificio = instalacionDTO.Edificio,
                    Piso = instalacionDTO.Piso,
                    Status = instalacionDTO.Status
                };

                try
                {
                    _uow.InstalacionesRepository.Edit(instalacion);
                    return Ok(await _uow.SaveAsync());
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_uow.InstalacionesRepository.InstalacionesExists(instalacion.ID))
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
            _uow.InstalacionesRepository.DeleteConfirmed(id);
            return Ok(await _uow.SaveAsync());
        }
        
    }
}
