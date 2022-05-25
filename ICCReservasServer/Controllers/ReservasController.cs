using Entities.Models;
using ICCReservasServer.DTOs;
using ICCReservasServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : Controller
    {
        private readonly IUnitOfWork _uow;

        public ReservasController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: Reservas
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            var reservas = await _uow.ReservasRepository.Index();
            var reservasDTO = from reserva in reservas
                                  select new ReservasDTO
                                  {
                                      ID = reserva.ID,
                                      Titulo = reserva.Titulo,
                                      Descripcion = reserva.Descripcion,
                                      DatetimeCreacion = reserva.DatetimeCreacion,
                                      DatetimeInicialReservacion = reserva.DatetimeInicialReservacion,
                                      DatetimeFinalReservacion = reserva.DatetimeFinalReservacion,
                                      UserID = reserva.UserID,
                                      InstalacionID = reserva.InstalacionID
                                  };

            return Ok(reservasDTO);
        }

        // GET: Reservas/Details/5
        [HttpGet("Details/{id}")]
        //[Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _uow.ReservasRepository.Details(id);
            if (reserva == null)
            {
                return NotFound();
            }
            var reservaDispositivo = await _uow.ReservaDispositivoRepository.GetDispositivoIDs(id);
            var statusReserva = await _uow.StatusReservaRepository.GetDispositivoIDs(id);

            var reservaDTO = new ReservasDTO
            {
                ID = reserva.ID,
                Titulo = reserva.Titulo,
                Descripcion = reserva.Descripcion,
                DatetimeCreacion = reserva.DatetimeCreacion,
                DatetimeInicialReservacion = reserva.DatetimeInicialReservacion,
                DatetimeFinalReservacion = reserva.DatetimeFinalReservacion,
                UserID = reserva.UserID,
                InstalacionID = reserva.InstalacionID,
                ReservaDispositivo = reservaDispositivo.Select(
                    a => new ReservaDispositivoDTO()
                    {
                        ID = a.ID,
                        ReservaID = a.ReservaID,
                        DispositivoID = a.DispositivoID
                    }
                    ).ToList(),
                StatusReserva = statusReserva.Select(
                    a => new StatusReservaDTO()
                    {
                        ID = a.ID,
                        FechaStatus = a.FechaStatus,
                        ReservaID = a.ReservaID,
                        StatusID = a.StatusID
                    }
                    ).ToList()
            };

            return Ok(reservaDTO);
        }

        // POST: Reservas/Create
        [HttpPost("Create")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateReservaDTO reservaDTO)
        {
            if (ModelState.IsValid)
            {
                var reserva = new Reservas
                {
                    Titulo = reservaDTO.Titulo,
                    Descripcion = reservaDTO.Descripcion,
                    DatetimeCreacion = reservaDTO.DatetimeCreacion,
                    DatetimeInicialReservacion = reservaDTO.DatetimeInicialReservacion,
                    DatetimeFinalReservacion = reservaDTO.DatetimeFinalReservacion,
                    UserID = reservaDTO.UserID,
                    InstalacionID = reservaDTO.InstalacionID
                };

                
                var reservaDispositivos = reservaDTO.ReservaDispositivo.Select(
                        a => new ReservaDispositivo()
                        {
                            Reserva = reserva,
                            DispositivoID = a.DispositivoID,
                            DatetimeInicialReservacion = reservaDTO.DatetimeInicialReservacion,
                            DatetimeFinalReservacion = reservaDTO.DatetimeFinalReservacion
                        }
                        ).ToList();

                var statusReserva = reservaDTO.StatusReserva.Select(
                        a => new StatusReserva()
                        {
                            FechaStatus = a.FechaStatus,
                            Reserva = reserva,
                            StatusID = a.StatusID
                        }
                        ).ToList();
                

                _uow.ReservasRepository.Create(reserva);
                _uow.StatusReservaRepository.Create(statusReserva);
                _uow.ReservaDispositivoRepository.Create(reservaDispositivos);
                return Ok(await _uow.SaveAsync());
            }
            else
                return BadRequest(new { code = "ReservaNotCreated", message = "Error: no se pudo crear la reserva." });
        }

        // PUT: Reservas/Edit/5
        [HttpPut("Edit/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ReservasDTO reservaDTO)
        {
            if (ModelState.IsValid)
            {
                var reserva = new Reservas
                {
                    ID = reservaDTO.ID,
                    Titulo = reservaDTO.Titulo,
                    Descripcion = reservaDTO.Descripcion,
                    DatetimeCreacion = reservaDTO.DatetimeCreacion,
                    DatetimeInicialReservacion = reservaDTO.DatetimeInicialReservacion,
                    DatetimeFinalReservacion = reservaDTO.DatetimeFinalReservacion,
                    UserID = reservaDTO.UserID,
                    InstalacionID = reservaDTO.InstalacionID
                };

                var reservaDispositivos = reservaDTO.ReservaDispositivo.Select(
                        a => new ReservaDispositivo()
                        {
                            Reserva = reserva,
                            DispositivoID = a.DispositivoID
                        }
                        ).ToList();

                var statusReserva = reservaDTO.StatusReserva.Select(
                        a => new StatusReserva()
                        {
                            FechaStatus = a.FechaStatus,
                            Reserva = reserva,
                            StatusID = a.StatusID
                        }
                        ).ToList();

                try
                {
                    _uow.StatusReservaRepository.Edit(statusReserva);
                    _uow.ReservaDispositivoRepository.Edit(reservaDispositivos);
                    _uow.ReservasRepository.Edit(reserva);
                    return Ok(await _uow.SaveAsync());
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_uow.ReservasRepository.ReservasExists(reserva.ID))
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

        // DELETE: Reservas/Delete/5
        [HttpDelete("Delete/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _uow.ReservasRepository.DeleteConfirmed(id);
            return Ok(await _uow.SaveAsync());
        }
    }
}
