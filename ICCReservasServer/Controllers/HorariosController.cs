using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Data;
using Entities.Models;
using ICCReservasServer.Interfaces;
using ICCReservasServer.DTOs;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosController : Controller
    {
        private readonly IUnitOfWork _uow;

        public HorariosController(IUnitOfWork uow)
        {
            this._uow = uow;
        }

        // GET: Horarios
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            var horarios = await _uow.HorariosRepository.Index();
            var horariosDTO = from horario in horarios
                              select new HorariosDTO { 
                                ID = horario.ID,
                                Nivel = horario.Nivel,
                                Numero = horario.Numero,
                                Nombre = horario.Nombre,
                                HoraInicio = horario.HoraInicio,
                                HoraFin = horario.HoraFin
                              };

            return Ok(horariosDTO);
        }

        // GET: Horarios
        [HttpGet("Nivel/{nivel}")]
        //[Authorize]
        public async Task<IActionResult> HorariosByNivel(string nivel)
        {
            var horarios = await _uow.HorariosRepository.Index();
            var horariosDTO = from horario in horarios
                              where horario.Nivel == nivel
                              select new HorariosDTO
                              {
                                  ID = horario.ID,
                                  Nivel = horario.Nivel,
                                  Numero = horario.Numero,
                                  Nombre = horario.Nombre,
                                  HoraInicio = horario.HoraInicio,
                                  HoraFin = horario.HoraFin
                              };

            return Ok(horariosDTO);
        }

        // GET: Horarios/Details/5
        [HttpGet("Details/{id}")]
        //[Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horarios = await _uow.HorariosRepository.Details(id);
            if (horarios == null)
            {
                return NotFound();
            }

            var horariosDTO = new HorariosDTO { 
                ID=horarios.ID,
                Nivel=horarios.Nivel,
                Numero = horarios.Numero,
                HoraInicio = horarios.HoraInicio,
                HoraFin=horarios.HoraFin
            };

            return Ok(horariosDTO);
        }

        // POST: Horarios/Create
        [HttpPost("Create")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HorariosDTO horariosDTO)
        {
            if (ModelState.IsValid)
            {
                var horario = new Horarios { 
                    ID = horariosDTO.ID,
                    Nivel = horariosDTO.Nivel,
                    Numero = horariosDTO.Numero,
                    HoraInicio = horariosDTO.HoraInicio,
                    HoraFin = horariosDTO.HoraFin
                };

                _uow.HorariosRepository.Create(horario);
                return Ok(await _uow.SaveAsync());
            }
            else
                return BadRequest(new { code = "HorarioNotCreated", message = "Error: no se pudo crear el horario." });
        }

        // PUT: Horarios/Edit/5
        [HttpPut("Edit/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, HorariosDTO horariosDTO)
        {
            if (ModelState.IsValid)
            {
                var horarios = new Horarios { 
                    ID = horariosDTO.ID,
                    Nivel = horariosDTO.Nivel,
                    Numero = horariosDTO.Numero,
                    HoraInicio = horariosDTO.HoraInicio,
                    HoraFin = horariosDTO.HoraFin
                };

                try
                {
                    _uow.HorariosRepository.Edit(horarios);
                    return Ok(await _uow.SaveAsync());
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_uow.HorariosRepository.HorariosExists(horarios.ID))
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
        [HttpDelete("Delete/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _uow.HorariosRepository.DeleteConfirmed(id);
            return Ok(await _uow.SaveAsync());
        }

    }
}
