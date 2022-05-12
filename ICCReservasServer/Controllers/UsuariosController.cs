using ICCReservasServer.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ICCReservasServer.Interfaces;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private readonly IUnitOfWork _uow;

        public UsuariosController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUnitOfWork uow)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _uow = uow;
        }

        // GET: Usuarios
        [HttpGet]
        //[Authorize]
        public IActionResult Index()
        {

            var usuarios = _uow.UsuariosRepository.Index();
            var applicationUserDTO = from usuario in usuarios
                             select new ApplicationUserDTO
                             {
                                 ID = usuario.Id,
                                 Names = usuario.Names,
                                 LastNames = usuario.LastNames,
                                 Email = usuario.Email,
                                 UserName = usuario.UserName
                             };

            return Ok(applicationUserDTO);
        }

        // GET: Usuarios/Details/string-id-goes-here
        [HttpGet("Details/{id}")]
        //[Authorize]
        public async Task<object> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _uow.UsuariosRepository.Details(id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            var applicationUserDTO = new ApplicationUserDTO {
                ID = applicationUser.Id,
                Names = applicationUser.Names,
                LastNames = applicationUser.LastNames,
                Email = applicationUser.Email,
                UserName = applicationUser.UserName
            };

            return Ok(applicationUserDTO);
        }

        // POST: Usuarios/Create
        [HttpPost("Create")]
        //[Authorize]
        public async Task<IActionResult> Create(ApplicationUserDTO applicationUserDTO)
        {
            if (ModelState.IsValid)
            {
                var applicationUser = new ApplicationUser()
                {
                    Names = applicationUserDTO.Names,
                    LastNames = applicationUserDTO.LastNames,
                    Email = applicationUserDTO.Email,
                    UserName = applicationUserDTO.Email.Split('@')[0]
                };

                //await _uow.UsuariosRepository.Create(applicationUser);
                return Ok(await _uow.UsuariosRepository.Create(applicationUser));
            }
            else
                return BadRequest(new { code = "UsuarioNotCreated", message = "Error: no se pudo crear el usuario." });
        }

        // PUT: Usuarios/Edit/5
        [HttpPut("Edit/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ApplicationUserDTO applicationUserDTO)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    //await _uow.UsuariosRepository.Edit(usuario);
                    return Ok(await _uow.UsuariosRepository.Edit(id, applicationUserDTO));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_uow.UsuariosRepository.ApplicationUserExists(id))
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

        // DELETE: Usuarios/Delete/5
        [HttpDelete("Delete/{id}")]
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            //await _uow.UsuariosRepository.DeleteConfirmed(id);
            return Ok(await _uow.UsuariosRepository.DeleteConfirmed(id));
        }

    }
}
