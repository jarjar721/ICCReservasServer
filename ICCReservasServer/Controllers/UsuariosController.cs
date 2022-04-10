using ICCReservasServer.DTOs;
using Entities.Models;
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

        // GET api/<UsuariosController>/User/string-id-goes-here
        [HttpGet()]
        [Authorize]
        [Route("User/{userID}")]
        public async Task<object> GetUserDetails([FromRoute] string userID)
        {
            var user = await _userManager.FindByIdAsync(userID);
            var responseUser = new
            {
                userID = user.Id,
                firstName = user.FirstName,
                middleName = user.MiddleName,
                lastName = user.LastName,
                secondLastName = user.SecondLastName,
                email = user.Email,
                userName = user.UserName
            };

            return Ok(new { user = responseUser });
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
