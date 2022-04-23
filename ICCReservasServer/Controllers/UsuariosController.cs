using ICCReservasServer.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ICCReservasServer.Interfaces;

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
            this._uow = uow;
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

        // GET api/<UsuariosController>/User/string-id-goes-here
        [HttpGet()]
        //[Authorize]
        [Route("User/{id}")]
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

        // POST api/Usuarios/Create
        [HttpPost]
        [Route("Create")] // POST --> api/Usuarios/Create
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

                _uow.UsuariosRepository.Create(applicationUser);
                return Ok(await _uow.SaveAsync());
            }
            else
                return BadRequest(new { code = "UsuarioNotCreated", message = "Error: no se pudo crear el usuario." });
        }

    }
}
