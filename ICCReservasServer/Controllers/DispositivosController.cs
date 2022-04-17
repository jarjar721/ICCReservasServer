using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using ICCReservasServer.Interfaces;
using ICCReservasServer.DTOs;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispositivosController : Controller
    {
        private readonly IUnitOfWork _uow;

        public DispositivosController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: Dispositivos
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            var dispositivos = await _uow.DispositivosRepository.Index();
            var dispositivosDTO = from dispositivo in dispositivos
                                  select new DispositivosDTO {
                                      ID = dispositivo.ID,
                                      Tipo = dispositivo.Tipo,
                                      Marca = dispositivo.Marca,
                                      Modelo = dispositivo.Modelo,
                                      Observacion = dispositivo.Observacion,
                                      Serial = dispositivo.Serial,
                                      Status = dispositivo.Status,
                                      Ubicacion = dispositivo.Ubicacion,
                                      Uso = dispositivo.Uso
                                  };

            return Ok(dispositivosDTO);
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

            var dispositivo = await _uow.DispositivosRepository.Details(id);
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
        public async Task<IActionResult> Create(DispositivosDTO dispositivoDTO)
        {
            if (ModelState.IsValid)
            {
                var dispositivo = new Dispositivos { 
                    ID = dispositivoDTO.ID,
                    Tipo = dispositivoDTO.Tipo,
                    Marca = dispositivoDTO.Marca,
                    Modelo = dispositivoDTO.Modelo,
                    Observacion = dispositivoDTO.Observacion,
                    Serial = dispositivoDTO.Serial,
                    Status = dispositivoDTO.Status,
                    Ubicacion = dispositivoDTO.Ubicacion,
                    Uso = dispositivoDTO.Uso,
                    LastUpdatedOn = DateTime.UtcNow
                };

                _uow.DispositivosRepository.Create(dispositivo);
                return Ok(await _uow.SaveAsync());
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
        public async Task<IActionResult> Edit(int id, Dispositivos dispositivo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _uow.DispositivosRepository.Edit(id, dispositivo);
                    return Ok(await _uow.SaveAsync());
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_uow.DispositivosRepository.DispositivosExists(id))
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
            _uow.DispositivosRepository.DeleteConfirmed(id);
            return Ok(await _uow.SaveAsync());
        }

    }
}
