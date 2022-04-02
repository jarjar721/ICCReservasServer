using ICCReservasServer.DTOs;
using ICCReservasServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICCReservasServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public UsuariosController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsuariosController>/User/5
        [HttpGet()]
        [Authorize]
        [Route("User/{id}")]
        public async Task<object> GetUserDetails()
        {
            string userID = User.Claims.First(claim => claim.Type == "UserID").Value;
            return await _userManager.FindByIdAsync(userID);
        }

        // POST api/Usuarios/AddUsuario
        [HttpPost]
        [Route("AddUsuario")] // POST --> api/Usuarios/Register
        public async Task<object> UserRegistration(AddUserDTO userDTO)
        {
            var applicationUser = new ApplicationUser()
            {
                FirstName = userDTO.FirstName,
                MiddleName = userDTO.MiddleName,
                LastName = userDTO.LastName,
                SecondLastName = userDTO.SecondLastName,
                Email = userDTO.Email,
                UserName = userDTO.Email.Split('@')[0]
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
