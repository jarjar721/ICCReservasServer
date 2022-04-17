using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using ICCReservasServer.Repos;

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispositivosController : Controller
    {
        private readonly IDispositivosRepository _repo;

        public DispositivosController(IDispositivosRepository repo)
        {
            _repo = repo;
        }

        // GET: Dispositivos
        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            return Ok(await _repo.Index());
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

            var dispositivo = await _repo.Details(id);
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
        public async Task<IActionResult> Create([Bind("ID,Tipo,Observacion,Marca,Modelo,Serial,Uso,Ubicacion,Status")] Dispositivos dispositivo)
        {
            if (ModelState.IsValid)
            {
                _repo.Create(dispositivo);
                return Ok(await _repo.SaveAsync());
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
        public async Task<IActionResult> Edit(int id, [Bind("ID,Tipo,Observacion,Marca,Modelo,Serial,Uso,Ubicacion,Status")] Dispositivos dispositivo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Edit(id, dispositivo);
                    return Ok(await _repo.SaveAsync());
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_repo.DispositivosExists(id))
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
            _repo.DeleteConfirmed(id);
            return Ok(await _repo.SaveAsync());
        }

    }
}
